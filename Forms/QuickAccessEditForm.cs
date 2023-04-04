﻿using QuickDBAccess.Model;
using System;
using System.Windows.Forms;

namespace QuickDBAccess.Forms {
	public partial class QuickAccessEditForm : Form {
		QuickAccessModel Model;
		public QuickAccessEditForm(QuickAccessModel Model) {
			this.Model = Model;
			InitializeComponent();
			InitializeViewModel();
		}
		private void InitializeViewModel() {
			RefreshConnectionList();
			RefreshDataSourcesList();
			RefreshTableViewsList();
		}
		private void RefreshConnectionList() {
			ConnectionsListView.Items.Clear();
			foreach (var connection in Model.Connections) {
				ListViewItem item = new ListViewItem(connection.Name);
				item.SubItems.Add(connection.server);
				item.SubItems.Add(connection.database);
				item.SubItems.Add(connection.user);
				ConnectionsListView.Items.Add(item);
			}
		}
		private void RefreshDataSourcesList() {
			foreach (var dataSource in Model.DataSources) {
				ListViewItem item = new ListViewItem(dataSource.Name);
				item.SubItems.Add(dataSource.ConnectionName);
				item.SubItems.Add(dataSource.Query.Command);
				DataSourcesListView.Items.Add(item);
			}
		}
		private void RefreshTableViewsList() {
			foreach (var tableView in Model.TableViews) {
				ListViewItem item = new ListViewItem(tableView.Name);
				item.SubItems.Add(tableView.ContentDataSourceName);
				item.SubItems.Add(tableView.ChildTableViews.Count.ToString());
				TableViewsListView.Items.Add(item);
			}
		}
	}
}
