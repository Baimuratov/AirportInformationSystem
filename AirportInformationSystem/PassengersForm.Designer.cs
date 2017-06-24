namespace AirportInformationSystem
{
    partial class PassengersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassengersForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.пассажирToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авиарейсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пассажирыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.сброситьРезультатПоискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airportDataBaseDataSet = new AirportInformationSystem.AirportDataBaseDataSet();
            this.пассажирBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пассажирTableAdapter = new AirportInformationSystem.AirportDataBaseDataSetTableAdapters.ПассажирTableAdapter();
            this.tableAdapterManager = new AirportInformationSystem.AirportDataBaseDataSetTableAdapters.TableAdapterManager();
            this.пассажирBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._changeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.пассажирBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._searchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._resetSearchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.пассажирDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пассажирBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пассажирBindingNavigator)).BeginInit();
            this.пассажирBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пассажирDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пассажирToolStripMenuItem,
            this.поискToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // пассажирToolStripMenuItem
            // 
            this.пассажирToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.пассажирToolStripMenuItem.Name = "пассажирToolStripMenuItem";
            this.пассажирToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.пассажирToolStripMenuItem.Text = "Пассажир";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авиарейсыToolStripMenuItem,
            this.пассажирыToolStripMenuItem,
            this.toolStripSeparator1,
            this.сброситьРезультатПоискаToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // авиарейсыToolStripMenuItem
            // 
            this.авиарейсыToolStripMenuItem.Name = "авиарейсыToolStripMenuItem";
            this.авиарейсыToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.авиарейсыToolStripMenuItem.Text = "Авиарейсы";
            this.авиарейсыToolStripMenuItem.Click += new System.EventHandler(this.авиарейсыToolStripMenuItem_Click);
            // 
            // пассажирыToolStripMenuItem
            // 
            this.пассажирыToolStripMenuItem.Name = "пассажирыToolStripMenuItem";
            this.пассажирыToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.пассажирыToolStripMenuItem.Text = "Пассажиры";
            this.пассажирыToolStripMenuItem.Click += new System.EventHandler(this.пассажирыToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(222, 6);
            // 
            // сброситьРезультатПоискаToolStripMenuItem
            // 
            this.сброситьРезультатПоискаToolStripMenuItem.Name = "сброситьРезультатПоискаToolStripMenuItem";
            this.сброситьРезультатПоискаToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.сброситьРезультатПоискаToolStripMenuItem.Text = "Сбросить результат поиска";
            this.сброситьРезультатПоискаToolStripMenuItem.Click += new System.EventHandler(this.сброситьРезультатПоискаToolStripMenuItem_Click);
            // 
            // airportDataBaseDataSet
            // 
            this.airportDataBaseDataSet.DataSetName = "AirportDataBaseDataSet";
            this.airportDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пассажирBindingSource
            // 
            this.пассажирBindingSource.DataMember = "Пассажир";
            this.пассажирBindingSource.DataSource = this.airportDataBaseDataSet;
            // 
            // пассажирTableAdapter
            // 
            this.пассажирTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = AirportInformationSystem.AirportDataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвиарейсTableAdapter = null;
            this.tableAdapterManager.ПассажирTableAdapter = this.пассажирTableAdapter;
            // 
            // пассажирBindingNavigator
            // 
            this.пассажирBindingNavigator.AddNewItem = null;
            this.пассажирBindingNavigator.BindingSource = this.пассажирBindingSource;
            this.пассажирBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.пассажирBindingNavigator.DeleteItem = null;
            this.пассажирBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this._addToolStripButton,
            this._changeToolStripButton,
            this._deleteToolStripButton,
            this.пассажирBindingNavigatorSaveItem,
            this.toolStripSeparator2,
            this._searchToolStripButton,
            this._resetSearchToolStripButton});
            this.пассажирBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.пассажирBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.пассажирBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.пассажирBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.пассажирBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.пассажирBindingNavigator.Name = "пассажирBindingNavigator";
            this.пассажирBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.пассажирBindingNavigator.Size = new System.Drawing.Size(736, 25);
            this.пассажирBindingNavigator.TabIndex = 1;
            this.пассажирBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // _addToolStripButton
            // 
            this._addToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._addToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_addToolStripButton.Image")));
            this._addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._addToolStripButton.Name = "_addToolStripButton";
            this._addToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._addToolStripButton.Text = "toolStripButton1";
            this._addToolStripButton.ToolTipText = "Добавить данные о пассажире";
            this._addToolStripButton.Click += new System.EventHandler(this._addToolStripButton_Click);
            // 
            // _changeToolStripButton
            // 
            this._changeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._changeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_changeToolStripButton.Image")));
            this._changeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._changeToolStripButton.Name = "_changeToolStripButton";
            this._changeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._changeToolStripButton.Text = "toolStripButton1";
            this._changeToolStripButton.ToolTipText = "Изменить данные о пассажире";
            this._changeToolStripButton.Click += new System.EventHandler(this._changeToolStripButton_Click);
            // 
            // _deleteToolStripButton
            // 
            this._deleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._deleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_deleteToolStripButton.Image")));
            this._deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._deleteToolStripButton.Name = "_deleteToolStripButton";
            this._deleteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._deleteToolStripButton.Text = "toolStripButton1";
            this._deleteToolStripButton.ToolTipText = "Удалить данные о пассажире";
            this._deleteToolStripButton.Click += new System.EventHandler(this._deleteToolStripButton_Click);
            // 
            // пассажирBindingNavigatorSaveItem
            // 
            this.пассажирBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.пассажирBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("пассажирBindingNavigatorSaveItem.Image")));
            this.пассажирBindingNavigatorSaveItem.Name = "пассажирBindingNavigatorSaveItem";
            this.пассажирBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.пассажирBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.пассажирBindingNavigatorSaveItem.Click += new System.EventHandler(this.пассажирBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // _searchToolStripButton
            // 
            this._searchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._searchToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_searchToolStripButton.Image")));
            this._searchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._searchToolStripButton.Name = "_searchToolStripButton";
            this._searchToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._searchToolStripButton.Text = "toolStripButton1";
            this._searchToolStripButton.ToolTipText = "Поиск пассажиров";
            this._searchToolStripButton.Click += new System.EventHandler(this._searchToolStripButton_Click);
            // 
            // _resetSearchToolStripButton
            // 
            this._resetSearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._resetSearchToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_resetSearchToolStripButton.Image")));
            this._resetSearchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._resetSearchToolStripButton.Name = "_resetSearchToolStripButton";
            this._resetSearchToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._resetSearchToolStripButton.Text = "toolStripButton1";
            this._resetSearchToolStripButton.ToolTipText = "Сбросить результаты поиска";
            this._resetSearchToolStripButton.Click += new System.EventHandler(this._resetSearchToolStripButton_Click);
            // 
            // пассажирDataGridView
            // 
            this.пассажирDataGridView.AllowUserToAddRows = false;
            this.пассажирDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.пассажирDataGridView.AutoGenerateColumns = false;
            this.пассажирDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.пассажирDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.пассажирDataGridView.DataSource = this.пассажирBindingSource;
            this.пассажирDataGridView.Location = new System.Drawing.Point(12, 52);
            this.пассажирDataGridView.Name = "пассажирDataGridView";
            this.пассажирDataGridView.ReadOnly = true;
            this.пассажирDataGridView.Size = new System.Drawing.Size(712, 398);
            this.пассажирDataGridView.TabIndex = 2;
            this.пассажирDataGridView.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.пассажирDataGridView_CellStateChanged);
            this.пассажирDataGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.пассажирDataGridView_RowStateChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Серия паспорта";
            this.dataGridViewTextBoxColumn1.HeaderText = "Серия паспорта";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 104;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Номер паспорта";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер паспорта";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 106;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Номер рейса";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер рейса";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 91;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn4.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 81;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn5.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 54;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn6.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 79;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Дата рождения";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 102;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Пол";
            this.dataGridViewTextBoxColumn8.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 52;
            // 
            // PassengersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 462);
            this.Controls.Add(this.пассажирDataGridView);
            this.Controls.Add(this.пассажирBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PassengersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таблица пассажиров";
            this.Load += new System.EventHandler(this.PassengersForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пассажирBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пассажирBindingNavigator)).EndInit();
            this.пассажирBindingNavigator.ResumeLayout(false);
            this.пассажирBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пассажирDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private AirportDataBaseDataSet airportDataBaseDataSet;
        private AirportDataBaseDataSetTableAdapters.ПассажирTableAdapter пассажирTableAdapter;
        private AirportDataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator пассажирBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton пассажирBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView пассажирDataGridView;
        private System.Windows.Forms.ToolStripMenuItem пассажирToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.BindingSource пассажирBindingSource;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авиарейсыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пассажирыToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem сброситьРезультатПоискаToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ToolStripButton _addToolStripButton;
        private System.Windows.Forms.ToolStripButton _changeToolStripButton;
        private System.Windows.Forms.ToolStripButton _deleteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton _searchToolStripButton;
        private System.Windows.Forms.ToolStripButton _resetSearchToolStripButton;
    }
}