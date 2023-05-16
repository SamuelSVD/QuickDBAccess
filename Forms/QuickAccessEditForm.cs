using QuickDBAccess.Model;
using QuickDBAccess.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuickDBAccess.Forms {
	public partial class QuickAccessEditForm : Form {
		QuickAccessModel Model;
		public bool Changed = false;
		public SQLConnectionModel SelectedConnection {
			get {
				if (ConnectionsListView.SelectedIndices.Count <= 0) return null;
				return Model.Connections[ConnectionsListView.SelectedIndices[0]];
			}
			set {
				if (ConnectionsListView.SelectedIndices.Count <= 0) return;
				SQLConnectionModel originalModel = Model.Connections[ConnectionsListView.SelectedIndices[0]];
				if (originalModel.Name != value.Name && Model.DataSources.Exists(t => t.ConnectionName == originalModel.Name)) {
					if(MessageBox.Show("There exist references to this connection. Do you want to update those as well?", "Update References", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
						foreach(var dataSource in Model.DataSources.FindAll(t => t.ConnectionName == originalModel.Name)) {
							dataSource.ConnectionName = value.Name;
						}
					}
				}
				Model.Connections[ConnectionsListView.SelectedIndices[0]].Apply(value);
				ListViewItem item = ConnectionsListView.SelectedItems[0];
				item.SubItems[0].Text = value.Name;
				item.SubItems[1].Text = value.server;
				item.SubItems[2].Text = value.database;
				item.SubItems[3].Text = value.user;
				item.SubItems[4].Text = value.useIntegratedSecurity ? "Yes" : "No";
				Changed = true;
			}
		}
		public DataSourceModel SelectedDataSource {
			get {
				if (DataSourcesListView.SelectedIndices.Count <= 0) return null;
				return Model.DataSources[DataSourcesListView.SelectedIndices[0]];
			}
			set {
				if (DataSourcesListView.SelectedIndices.Count <= 0) return;
				Model.DataSources[DataSourcesListView.SelectedIndices[0]].Apply(value);
				ListViewItem item = DataSourcesListView.SelectedItems[0];
				item.SubItems[0].Text = value.Name;
				item.SubItems[1].Text = value.ConnectionName;
				item.SubItems[2].Text = value.Query.Command;
				Changed = true;
			}
		}
		public TableViewModel SelectedTableView {
			get {
				if (TableViewsListView.SelectedIndices.Count <= 0) return null;
				return Model.TableViews[TableViewsListView.SelectedIndices[0]];
			}
			set {
				if (TableViewsListView.SelectedIndices.Count <= 0) return;
				Model.TableViews[TableViewsListView.SelectedIndices[0]].Apply(value);
				ListViewItem item = TableViewsListView.SelectedItems[0];
				item.SubItems[0].Text = value.Name;
				item.SubItems[1].Text = value.ContentDataSourceName;
				item.SubItems[2].Text = value.ChildTableViews.Count.ToString();
				Changed = true;
			}
		}
		public QuickAccessEditForm(QuickAccessModel Model) {
			this.Model = Model;
			InitializeComponent();
			ProjectNameTextBox.TextChanged += ProjectNameTextBox_TextChanged;
			InitializeViewModel();
			ConnectionsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			DataSourcesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			TableViewsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			ConnectionsListView.MultiSelect = false;
			ProjectNameTextBox_TextChanged(null, null);
		}
		private void InitializeViewModel() {
			RefreshConnectionList();
			RefreshDataSourcesList();
			RefreshTableViewsList();
			ProjectNameTextBox.Text = Model.ProjectName;
		}

		private void ProjectNameTextBox_TextChanged(object sender, EventArgs e) {
			if (Model.ProjectName != ProjectNameTextBox.Text) {
				Changed = true;
			}
			Model.ProjectName = ProjectNameTextBox.Text;
			ProjectNameTextBox.Valid = !string.IsNullOrEmpty(Model.ProjectName);
		}

		private void RefreshConnectionList() {
			ConnectionsListView.Items.Clear();
			foreach (var connection in Model.Connections) {
				AddConnection(connection);
			}
		}
		private ListViewItem AddConnection(SQLConnectionModel connection) {
			ListViewItem item = new ListViewItem(connection.Name);
			item.SubItems.Add(connection.server);
			item.SubItems.Add(connection.database);
			item.SubItems.Add(connection.user);
			item.SubItems.Add(connection.useIntegratedSecurity ? "Yes" : "No");
			ConnectionsListView.Items.Add(item);
			ConnectionsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			return item;
		}
		private void RefreshDataSourcesList() {
			foreach (var dataSource in Model.DataSources) {
				AddDataSource(dataSource);
			}
		}
		private ListViewItem AddDataSource(DataSourceModel dataSource) {
			ListViewItem item = new ListViewItem(dataSource.Name);
			item.SubItems.Add(dataSource.ConnectionName);
			item.SubItems.Add(dataSource.Query.Command);
			DataSourcesListView.Items.Add(item);
			DataSourcesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			return item;
		}
		private void RefreshTableViewsList() {
			foreach (var tableView in Model.TableViews) {
				AddTableView(tableView);
			}
		}
		private ListViewItem AddTableView(TableViewModel tableView) {
			ListViewItem item = new ListViewItem(tableView.Name);
			item.SubItems.Add(tableView.ContentDataSourceName);
			item.SubItems.Add(tableView.ChildTableViews.Count.ToString());
			TableViewsListView.Items.Add(item);
			TableViewsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			return item;
		}
		private void ConnectionsListView_SelectedIndexChanged(object sender, EventArgs e) {
			AddConnectionButton.Enabled = true;
			EditConnectionButton.Enabled = SelectedConnection != null;
			DeleteConnectionButton.Enabled = SelectedConnection != null;
			ConnectionsUpButton.Enabled = Model.Connections.Count > 1 && ConnectionsListView.SelectedIndices.Count > 0 && ConnectionsListView.SelectedIndices[0] > 0;
			ConnectionsDownButton.Enabled = Model.Connections.Count > 1 && ConnectionsListView.SelectedIndices.Count > 0 && ConnectionsListView.SelectedIndices[0] < Model.Connections.Count - 1;
		}

		private void DataSourcesListView_SelectedIndexChanged(object sender, EventArgs e) {
			NewDataSourceButton.Enabled = true;
			EditDataSourceButton.Enabled = SelectedDataSource != null;
			DeleteDataSourceButton.Enabled = SelectedDataSource != null;
			DataSourcesUpButton.Enabled = Model.DataSources.Count > 1 && DataSourcesListView.SelectedIndices.Count > 0 && DataSourcesListView.SelectedIndices[0] > 0;
			DataSourcesDownButton.Enabled = Model.DataSources.Count > 1 && DataSourcesListView.SelectedIndices.Count > 0 && DataSourcesListView.SelectedIndices[0] < Model.DataSources.Count - 1;
		}

		private void TableViewsListView_SelectedIndexChanged(object sender, EventArgs e) {
			NewTableViewButton.Enabled = true;
			EditTableViewButton.Enabled = SelectedTableView != null;
			DeleteTableViewButton.Enabled = SelectedTableView != null;
			TableViewsUpButton.Enabled = Model.TableViews.Count > 1 && TableViewsListView.SelectedIndices.Count > 0 && TableViewsListView.SelectedIndices[0] > 0;
			TableViewsDownButton.Enabled = Model.TableViews.Count > 1 && TableViewsListView.SelectedIndices.Count > 0 && TableViewsListView.SelectedIndices[0] < Model.TableViews.Count - 1;
		}

		private void AddConnectionButton_Click(object sender, EventArgs e) {
			SQLConnectionModel connectionModel = new SQLConnectionModel();
			ConnectionEditForm connectionEditForm = new ConnectionEditForm(connectionModel, null, Model);
			if (connectionEditForm.ShowNewDialog() == DialogResult.OK) {
				Model.Connections.Add(connectionModel);
				AddConnection(connectionModel);
				Changed = true;
			}
			connectionEditForm.Dispose();
		}

		private void EditConnectionButton_Click(object sender, EventArgs e) {
			SQLConnectionModel connectionModel = new SQLConnectionModel(SelectedConnection);
			ConnectionEditForm connectionEditForm = new ConnectionEditForm(connectionModel, SelectedConnection, Model);
			if (connectionEditForm.ShowDialog() == DialogResult.OK) {
				SelectedConnection = connectionModel;
			}
			connectionEditForm.Dispose();
		}

		private void DeleteConnectionButton_Click(object sender, EventArgs e) {
			try {
				if (MessageBox.Show("Delete this connection?", "Delete Connection", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
					if (Model.DataSources.Exists(t => t.ConnectionName == SelectedConnection.Name)) {
						if (MessageBox.Show("There exist references to this connection. Are you sure you want to delete?", "Delete Connection", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) {
							return;
						}
					}
					Model.Connections.Remove(SelectedConnection);
					ConnectionsListView.Items.RemoveAt(ConnectionsListView.SelectedIndices[0]);
					Changed = true;
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void NewDataSourceButton_Click(object sender, EventArgs e) {
			DataSourceModel dataSourceModel = new DataSourceModel();
			DataSourceEditForm dataSourceEditForm = new DataSourceEditForm(dataSourceModel, null, Model);
			if (dataSourceEditForm.ShowNewDialog() == DialogResult.OK) {
				Model.DataSources.Add(dataSourceModel);
				AddDataSource(dataSourceModel);
				Changed = true;
			}
			dataSourceEditForm.Dispose();
		}

		private void EditDataSourceButton_Click(object sender, EventArgs e) {
			DataSourceModel dataSourceModel = new DataSourceModel(SelectedDataSource);
			DataSourceEditForm dataSourceEditForm = new DataSourceEditForm(dataSourceModel, SelectedDataSource, Model);
			if (dataSourceEditForm.ShowDialog() == DialogResult.OK) {
				SelectedDataSource = dataSourceModel;
			}
			dataSourceEditForm.Dispose();
		}

		private void DeleteDataSourceButton_Click(object sender, EventArgs e) {
			try {
				if (MessageBox.Show("Delete this data source?", "Delete Data Source", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
					if (Model.TableViews.Exists(t => t.UsesDataSource(SelectedDataSource))) {
						if (MessageBox.Show("There exist references to this data source. Are you sure you want to delete?", "Delete Data Source", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) {
							return;
						}
					}
					Model.DataSources.Remove(SelectedDataSource);
					DataSourcesListView.Items.RemoveAt(DataSourcesListView.SelectedIndices[0]);
					Changed = true;
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}
		private void NewTableViewButton_Click(object sender, EventArgs e) {
			TableViewModel tableViewModel = new TableViewModel();
			TableViewEditForm tableViewEditForm = new TableViewEditForm(tableViewModel, Model);
			if (tableViewEditForm.ShowNewDialog() == DialogResult.OK) {
				Model.TableViews.Add(tableViewModel);
				AddTableView(tableViewModel);
				Changed = true;
			}
			tableViewEditForm.Dispose();
		}

		private void EditTableViewButton_Click(object sender, EventArgs e) {
			TableViewModel tableViewModel = new TableViewModel(SelectedTableView);
			TableViewEditForm tableViewEditForm = new TableViewEditForm(tableViewModel, Model);
			if (tableViewEditForm.ShowDialog() == DialogResult.OK) {
				SelectedTableView = tableViewModel;
			}
			tableViewEditForm.Dispose();
		}

		private void DeleteTableViewButton_Click(object sender, EventArgs e) {
			try {
				if (MessageBox.Show("Delete this table view?", "Delete Table View", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
					Model.TableViews.Remove(SelectedTableView);
					TableViewsListView.Items.RemoveAt(TableViewsListView.SelectedIndices[0]);
					Changed = true;
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void ChangeEnableDisable(Button button, Bitmap enabledImage, Bitmap disabledImage) {
			if (button.Enabled) {
				button.BackgroundImage = enabledImage;
			} else {
				button.BackgroundImage = disabledImage;
			}
		}

		private void EditConnectionButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(EditConnectionButton, Properties.Resources.edit, Properties.Resources.edit_disabled);
		}

		private void DeleteConnectionButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(DeleteConnectionButton, Properties.Resources.delete, Properties.Resources.delete_disabled);
		}

		private void EditDataSourceButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(EditDataSourceButton, Properties.Resources.edit, Properties.Resources.edit_disabled);
		}

		private void DeleteDataSourceButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(DeleteDataSourceButton, Properties.Resources.delete, Properties.Resources.delete_disabled);
		}

		private void EditTableViewButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(EditTableViewButton, Properties.Resources.edit, Properties.Resources.edit_disabled);
		}

		private void DeleteTableViewButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(DeleteTableViewButton, Properties.Resources.delete, Properties.Resources.delete_disabled);
		}

		private void OkButton_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
			Close();
		}

		private void ConnectionsUpButton_Click(object sender, EventArgs e) {
			SQLConnectionModel c = SelectedConnection;
			int oldIndex = Model.Connections.IndexOf(c);
			ListViewItem item = ConnectionsListView.Items[oldIndex];
			Model.Connections.RemoveAt(oldIndex);
			Model.Connections.Insert(oldIndex - 1, c);
			ConnectionsListView.Items.RemoveAt(oldIndex);
			ConnectionsListView.Items.Insert(oldIndex - 1, item);
			Changed = true;
		}

		private void ConnectionsDownButton_Click(object sender, EventArgs e) {
			SQLConnectionModel c = SelectedConnection;
			int oldIndex = Model.Connections.IndexOf(c);
			ListViewItem item = ConnectionsListView.Items[oldIndex];
			Model.Connections.RemoveAt(oldIndex);
			Model.Connections.Insert(oldIndex+1, c);
			ConnectionsListView.Items.RemoveAt(oldIndex);
			ConnectionsListView.Items.Insert(oldIndex+1, item);
			Changed = true;
		}

		private void DataSourcesUpButton_Click(object sender, EventArgs e) {
			DataSourceModel ds = SelectedDataSource;
			int oldIndex = Model.DataSources.IndexOf(ds);
			ListViewItem item = DataSourcesListView.Items[oldIndex];
			Model.DataSources.RemoveAt(oldIndex);
			Model.DataSources.Insert(oldIndex - 1, ds);
			DataSourcesListView.Items.RemoveAt(oldIndex);
			DataSourcesListView.Items.Insert(oldIndex - 1, item);
			Changed = true;
		}

		private void DataSourcesDownButton_Click(object sender, EventArgs e) {
			DataSourceModel ds = SelectedDataSource;
			int oldIndex = Model.DataSources.IndexOf(ds);
			ListViewItem item = DataSourcesListView.Items[oldIndex];
			Model.DataSources.RemoveAt(oldIndex);
			Model.DataSources.Insert(oldIndex + 1, ds);
			DataSourcesListView.Items.RemoveAt(oldIndex);
			DataSourcesListView.Items.Insert(oldIndex + 1, item);
			Changed = true;
		}

		private void TableViewsUpButton_Click(object sender, EventArgs e) {
			TableViewModel tvm = SelectedTableView;
			int oldIndex = Model.TableViews.IndexOf(tvm);
			ListViewItem item = TableViewsListView.Items[oldIndex];
			Model.TableViews.RemoveAt(oldIndex);
			Model.TableViews.Insert(oldIndex - 1, tvm);
			TableViewsListView.Items.RemoveAt(oldIndex);
			TableViewsListView.Items.Insert(oldIndex - 1, item);
			Changed = true;
		}

		private void TableViewsDownButton_Click(object sender, EventArgs e) {
			TableViewModel tvm = SelectedTableView;
			int oldIndex = Model.TableViews.IndexOf(tvm);
			ListViewItem item = TableViewsListView.Items[oldIndex];
			Model.TableViews.RemoveAt(oldIndex);
			Model.TableViews.Insert(oldIndex + 1, tvm);
			TableViewsListView.Items.RemoveAt(oldIndex);
			TableViewsListView.Items.Insert(oldIndex + 1, item);
			Changed = true;
		}

		private void ConnectionsUpButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(ConnectionsUpButton, Properties.Resources.up, Properties.Resources.up_disabled);
		}

		private void ConnectionsDownButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(ConnectionsDownButton, Properties.Resources.down, Properties.Resources.down_disabled);
		}

		private void DataSourcesUpButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(DataSourcesUpButton, Properties.Resources.up, Properties.Resources.up_disabled);
		}

		private void DataSourcesDownButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(DataSourcesDownButton, Properties.Resources.down, Properties.Resources.down_disabled);
		}
		private void TableViewsUpButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(TableViewsUpButton, Properties.Resources.up, Properties.Resources.up_disabled);
		}
		private void TableViewsDownButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(TableViewsDownButton, Properties.Resources.down, Properties.Resources.down_disabled);
		}
		private void ConnectionsListView_DoubleClick(object sender, EventArgs e) {
			if (SelectedConnection != null) {
				EditConnectionButton_Click(sender, e);
			}
		}
		private void DataSourcesListView_DoubleClick(object sender, EventArgs e) {
			if (SelectedDataSource != null) {
				EditDataSourceButton_Click(sender, e);
			}
		}
		private void TableViewsListView_DoubleClick(object sender, EventArgs e) {
			if (SelectedTableView != null) {
				EditTableViewButton_Click(sender, e);
			}
		}
		private void ConnectionsListView_KeyDown(object sender, KeyEventArgs e) {
			if (e.Control) {
				switch (e.KeyCode) {
					case Keys.Up:
						if (ConnectionsUpButton.Enabled) {
							ConnectionsUpButton_Click(sender, e);
						}
						break;
					case Keys.Down:
						if (ConnectionsDownButton.Enabled) {
							ConnectionsDownButton_Click(sender, e);
						}
						break;
				}
			} else {
				switch (e.KeyCode) {
					case Keys.Enter:
					case Keys.F2:
						if (EditConnectionButton.Enabled) {
							EditConnectionButton_Click(sender, e);
						}
						break;
				}
			}
		}

		private void DataSourcesListView_KeyDown(object sender, KeyEventArgs e) {
			if (e.Control) {
				switch (e.KeyCode) {
					case Keys.Up:
						if (DataSourcesUpButton.Enabled) {
							DataSourcesUpButton_Click(sender, e);
						}
						break;
					case Keys.Down:
						if (DataSourcesDownButton.Enabled) {
							DataSourcesDownButton_Click(sender, e);
						}
						break;
				}
			} else {
				switch (e.KeyCode) {
					case Keys.Enter:
					case Keys.F2:
						if (EditDataSourceButton.Enabled) {
							EditDataSourceButton_Click(sender, e);
						}
						break;
				}
			}
		}

		private void TableViewsListView_KeyDown(object sender, KeyEventArgs e) {
			if (e.Control) {
				switch (e.KeyCode) {
					case Keys.Up:
						if (TableViewsUpButton.Enabled) {
							TableViewsUpButton_Click(sender, e);
						}
						break;
					case Keys.Down:
						if (TableViewsDownButton.Enabled) {
							TableViewsDownButton_Click(sender, e);
						}
						break;
				}
			} else {
				switch (e.KeyCode) {
					case Keys.Enter:
					case Keys.F2:
						if (EditTableViewButton.Enabled) {
							EditTableViewButton_Click(sender, e);
						}
						break;
				}
			}
		}

		private void DuplicateConnectionToolStripMenuItem_Click(object sender, EventArgs e) {
			SQLConnectionModel modelOriginal = SelectedConnection;
			SQLConnectionModel modelNew = new SQLConnectionModel(modelOriginal);
			int i = 1;
			string name = modelNew.Name + "-" + i.ToString();
			while (Model.Connections.Exists(c => c.Name == name)) {
				i++;
				name = modelNew.Name + "-" + i.ToString();
			}
			modelNew.Name = name;
			int oldIndex = Model.Connections.IndexOf(modelOriginal);
			Model.Connections.Insert(oldIndex + 1, modelNew);
			ListViewItem item = AddConnection(modelNew);
			ConnectionsListView.Items.Remove(item);
			ConnectionsListView.Items.Insert(oldIndex + 1, item);
		}
		private void ConnectionsListView_MouseClick(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Right) {
				var focusedItem = ConnectionsListView.FocusedItem;
				if (focusedItem != null && focusedItem.Bounds.Contains(e.Location)) {
					ConnectionsContextMenu.Show(Cursor.Position);
				}
			}
		}
		private void DuplicateDataSourcesMenuItem_Click(object sender, EventArgs e) {
			DataSourceModel modelOriginal = SelectedDataSource;
			DataSourceModel modelNew = new DataSourceModel(modelOriginal);
			int i = 1;
			string name = modelNew.Name + "-" + i.ToString();
			while (Model.DataSources.Exists(c => c.Name == name)) {
				i++;
				name = modelNew.Name + "-" + i.ToString();
			}
			modelNew.Name = name;
			int oldIndex = Model.DataSources.IndexOf(modelOriginal);
			Model.DataSources.Insert(oldIndex + 1, modelNew);
			ListViewItem item = AddDataSource(modelNew);
			DataSourcesListView.Items.Remove(item);
			DataSourcesListView.Items.Insert(oldIndex + 1, item);
		}
		private void DataSourcesListView_MouseClick(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Right) {
				var focusedItem = DataSourcesListView.FocusedItem;
				if (focusedItem != null && focusedItem.Bounds.Contains(e.Location)) {
					DataSourcesContextMenu.Show(Cursor.Position);
				}
			}
		}
		private void DuplicateTableViewsMenuItem_Click(object sender, EventArgs e) {
			TableViewModel modelOriginal = SelectedTableView;
			TableViewModel modelNew = new TableViewModel(modelOriginal);
			int i = 1;
			string name = modelNew.Name + "-" + i.ToString();
			while (Model.TableViews.Exists(c => c.Name == name)) {
				i++;
				name = modelNew.Name + "-" + i.ToString();
			}
			modelNew.Name = name;
			int oldIndex = Model.TableViews.IndexOf(modelOriginal);
			Model.TableViews.Insert(oldIndex + 1, modelNew);
			ListViewItem item = AddTableView(modelNew);
			TableViewsListView.Items.Remove(item);
			TableViewsListView.Items.Insert(oldIndex + 1, item);
		}
		private void TableViewsListView_MouseClick(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Right) {
				var focusedItem = TableViewsListView.FocusedItem;
				if (focusedItem != null && focusedItem.Bounds.Contains(e.Location)) {
					TableViewsContextMenu.Show(Cursor.Position);
				}
			}
		}
	}
}
