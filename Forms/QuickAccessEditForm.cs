using QuickDBAccess.Model;
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
		}
		public QuickAccessEditForm(QuickAccessModel Model) {
			this.Model = Model;
			InitializeComponent();
			InitializeViewModel();
			ConnectionsListView.MultiSelect = false;
		}
		private void InitializeViewModel() {
			RefreshConnectionList();
			RefreshDataSourcesList();
			RefreshTableViewsList();
		}
		private void RefreshConnectionList() {
			ConnectionsListView.Items.Clear();
			foreach (var connection in Model.Connections) {
				AddConnection(connection);
			}
		}
		private void AddConnection(SQLConnectionModel connection) {
			ListViewItem item = new ListViewItem(connection.Name);
			item.SubItems.Add(connection.server);
			item.SubItems.Add(connection.database);
			item.SubItems.Add(connection.user);
			ConnectionsListView.Items.Add(item);
		}
		private void RefreshDataSourcesList() {
			foreach (var dataSource in Model.DataSources) {
				AddDataSource(dataSource);
			}
		}
		private void AddDataSource(DataSourceModel dataSource) {
			ListViewItem item = new ListViewItem(dataSource.Name);
			item.SubItems.Add(dataSource.ConnectionName);
			item.SubItems.Add(dataSource.Query.Command);
			DataSourcesListView.Items.Add(item);
		}
		private void RefreshTableViewsList() {
			foreach (var tableView in Model.TableViews) {
				AddTableView(tableView);
			}
		}
		private void AddTableView(TableViewModel tableView) {
			ListViewItem item = new ListViewItem(tableView.Name);
			item.SubItems.Add(tableView.ContentDataSourceName);
			item.SubItems.Add(tableView.ChildTableViews.Count.ToString());
			TableViewsListView.Items.Add(item);
		}
        private void ConnectionsListView_SelectedIndexChanged(object sender, EventArgs e) {
			AddConnectionButton.Enabled = true;
			EditConnectionButton.Enabled = SelectedConnection != null;
			DeleteConnectionButton.Enabled = SelectedConnection != null;
		}

		private void DataSourcesListView_SelectedIndexChanged(object sender, EventArgs e) {
			NewDataSourceButton.Enabled = true;
			EditDataSourceButton.Enabled = SelectedDataSource != null;
			DeleteDataSourceButton.Enabled = SelectedDataSource != null;
		}

		private void TableViewsListView_SelectedIndexChanged(object sender, EventArgs e) {
			NewTableViewButton.Enabled = true;
			EditTableViewButton.Enabled = SelectedTableView != null;
			DeleteTableViewButton.Enabled = SelectedTableView != null;
		}

		private void AddConnectionButton_Click(object sender, EventArgs e) {
			SQLConnectionModel connectionModel = new SQLConnectionModel();
			ConnectionEditForm connectionEditForm = new ConnectionEditForm(connectionModel);
			if (connectionEditForm.ShowNewDialog() == DialogResult.OK) {
				ProgramData.Instance.Connections.Add(connectionModel);
				AddConnection(connectionModel);
			}
		}

		private void EditConnectionButton_Click(object sender, EventArgs e) {
			SQLConnectionModel connectionModel = new SQLConnectionModel(SelectedConnection);
			ConnectionEditForm connectionEditForm = new ConnectionEditForm(connectionModel);
			if (connectionEditForm.ShowNewDialog() == DialogResult.OK) {
				SelectedConnection = connectionModel;
			}
		}

		private void DeleteConnectionButton_Click(object sender, EventArgs e) {
			try {
				if (MessageBox.Show("Are you sure you want to delete this connection?", "Delete Connection", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
					throw new NotImplementedException();
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void NewDataSourceButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void EditDataSourceButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void DeleteDataSourceButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}
		private void NewTableViewButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void EditTableViewButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void DeleteTableViewButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
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
	}
}
