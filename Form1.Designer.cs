namespace SQL_SERVER_IMPORT_EXPORT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ImportPath = new System.Windows.Forms.Label();
            this.Extension = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ImportPathTextBox = new System.Windows.Forms.TextBox();
            this.Server = new System.Windows.Forms.Label();
            this.Database = new System.Windows.Forms.Label();
            this.ExtensionListBoxImport = new System.Windows.Forms.ListBox();
            this.TablesToExportCommaList = new System.Windows.Forms.TextBox();
            this.TablesToExportRegex = new System.Windows.Forms.TextBox();
            this.ImportPathNotes = new System.Windows.Forms.Label();
            this.OutputTypeListBox = new System.Windows.Forms.ListBox();
            this.ExportPathTextBox = new System.Windows.Forms.TextBox();
            this.ExportPath = new System.Windows.Forms.Label();
            this.ExportPathNotes = new System.Windows.Forms.Label();
            this.IncludeHeadersCheckBox = new System.Windows.Forms.CheckBox();
            this.ImportDelimeterListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExportDelimeterListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ExportQualifierListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.ImportPanel = new System.Windows.Forms.Panel();
            this.ColumnTypeFilePathTextBox = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ColumnTypeVarcharDefaultRadioButton = new System.Windows.Forms.RadioButton();
            this.ColumnTypeUseFileRadioButton = new System.Windows.Forms.RadioButton();
            this.label30 = new System.Windows.Forms.Label();
            this.FasterImportCheckBox = new System.Windows.Forms.CheckBox();
            this.ImportTemplate = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.ImportChooseFileButton = new System.Windows.Forms.Button();
            this.InsertToExistingTableCheckBox = new System.Windows.Forms.CheckBox();
            this.DoubleQuoted = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ImportToSingleTableTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.FixedWidthColumnFilePathLabel = new System.Windows.Forms.Label();
            this.FixedWidthColumnFilePathTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ExportPanel = new System.Windows.Forms.Panel();
            this.RemoveQualInValCheckBox = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.QualifyAllRadioButton = new System.Windows.Forms.RadioButton();
            this.QualifyIfDelimeterRadioButton = new System.Windows.Forms.RadioButton();
            this.FromTextBox = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.ExportTemplate = new System.Windows.Forms.ComboBox();
            this.ListColumnsForSelectedTablesButton = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.SelectTextBox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.GroupByTextBox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.WhereTextBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.TablesToExportListFromSql = new System.Windows.Forms.ListBox();
            this.SplitAmounNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.IncludeHeaderInSplitFilesCheckBox = new System.Windows.Forms.CheckBox();
            this.OrderByTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SizeSplit1024RadioButton = new System.Windows.Forms.RadioButton();
            this.NoSplitRadioButton = new System.Windows.Forms.RadioButton();
            this.SizeSplitRadioButton = new System.Windows.Forms.RadioButton();
            this.RowSplitRadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExportChooseFileButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.LoadSqlTables = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TablePickerRadioButton = new System.Windows.Forms.RadioButton();
            this.RegexPatternTableSearchRadioButton = new System.Windows.Forms.RadioButton();
            this.CommaSeperatedListTableSearchRadioButton = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ServerComboBox = new System.Windows.Forms.ComboBox();
            this.DatabaseComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ImportPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.ExportPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitAmounNumericUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImportPath
            // 
            this.ImportPath.AutoSize = true;
            this.ImportPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportPath.Location = new System.Drawing.Point(8, 680);
            this.ImportPath.Name = "ImportPath";
            this.ImportPath.Size = new System.Drawing.Size(95, 16);
            this.ImportPath.TabIndex = 1;
            this.ImportPath.Text = "Import Path *";
            // 
            // Extension
            // 
            this.Extension.AutoSize = true;
            this.Extension.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Extension.Location = new System.Drawing.Point(10, 32);
            this.Extension.Name = "Extension";
            this.Extension.Size = new System.Drawing.Size(130, 16);
            this.Extension.TabIndex = 3;
            this.Extension.Text = "Import File Type *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Export File Type *";
            // 
            // ImportPathTextBox
            // 
            this.ImportPathTextBox.Location = new System.Drawing.Point(2, 748);
            this.ImportPathTextBox.Name = "ImportPathTextBox";
            this.ImportPathTextBox.Size = new System.Drawing.Size(291, 20);
            this.ImportPathTextBox.TabIndex = 12;
            // 
            // Server
            // 
            this.Server.AutoSize = true;
            this.Server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server.Location = new System.Drawing.Point(8, 8);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(78, 20);
            this.Server.TabIndex = 10;
            this.Server.Text = "Server: *";
            // 
            // Database
            // 
            this.Database.AutoSize = true;
            this.Database.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Database.Location = new System.Drawing.Point(294, 8);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(104, 20);
            this.Database.TabIndex = 11;
            this.Database.Text = "Database: *";
            // 
            // ExtensionListBoxImport
            // 
            this.ExtensionListBoxImport.FormattingEnabled = true;
            this.ExtensionListBoxImport.Items.AddRange(new object[] {
            "csv",
            "txt",
            "xls*"});
            this.ExtensionListBoxImport.Location = new System.Drawing.Point(13, 48);
            this.ExtensionListBoxImport.Name = "ExtensionListBoxImport";
            this.ExtensionListBoxImport.Size = new System.Drawing.Size(127, 69);
            this.ExtensionListBoxImport.TabIndex = 4;
            this.ExtensionListBoxImport.SelectedIndexChanged += new System.EventHandler(this.ExtensionListBoxImport_SelectedIndexChanged);
            // 
            // TablesToExportCommaList
            // 
            this.TablesToExportCommaList.Location = new System.Drawing.Point(151, 48);
            this.TablesToExportCommaList.Multiline = true;
            this.TablesToExportCommaList.Name = "TablesToExportCommaList";
            this.TablesToExportCommaList.Size = new System.Drawing.Size(302, 36);
            this.TablesToExportCommaList.TabIndex = 53;
            this.TablesToExportCommaList.TextChanged += new System.EventHandler(this.TablesToExportCommaList_TextChanged);
            // 
            // TablesToExportRegex
            // 
            this.TablesToExportRegex.Location = new System.Drawing.Point(151, 91);
            this.TablesToExportRegex.Name = "TablesToExportRegex";
            this.TablesToExportRegex.Size = new System.Drawing.Size(302, 20);
            this.TablesToExportRegex.TabIndex = 55;
            this.TablesToExportRegex.TextChanged += new System.EventHandler(this.TablesToExportRegex_TextChanged);
            // 
            // ImportPathNotes
            // 
            this.ImportPathNotes.AutoSize = true;
            this.ImportPathNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ImportPathNotes.Location = new System.Drawing.Point(3, 696);
            this.ImportPathNotes.Name = "ImportPathNotes";
            this.ImportPathNotes.Size = new System.Drawing.Size(253, 13);
            this.ImportPathNotes.TabIndex = 18;
            this.ImportPathNotes.Text = "  -Enter file path (w/extension) to import only that file.";
            // 
            // OutputTypeListBox
            // 
            this.OutputTypeListBox.FormattingEnabled = true;
            this.OutputTypeListBox.Items.AddRange(new object[] {
            "csv",
            "txt",
            "xlsx"});
            this.OutputTypeListBox.Location = new System.Drawing.Point(12, 298);
            this.OutputTypeListBox.Name = "OutputTypeListBox";
            this.OutputTypeListBox.Size = new System.Drawing.Size(127, 69);
            this.OutputTypeListBox.TabIndex = 59;
            this.OutputTypeListBox.SelectedIndexChanged += new System.EventHandler(this.OutputTypeListBox_SelectedIndexChanged);
            // 
            // ExportPathTextBox
            // 
            this.ExportPathTextBox.Location = new System.Drawing.Point(7, 745);
            this.ExportPathTextBox.Name = "ExportPathTextBox";
            this.ExportPathTextBox.Size = new System.Drawing.Size(291, 20);
            this.ExportPathTextBox.TabIndex = 75;
            // 
            // ExportPath
            // 
            this.ExportPath.AutoSize = true;
            this.ExportPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportPath.Location = new System.Drawing.Point(4, 711);
            this.ExportPath.Name = "ExportPath";
            this.ExportPath.Size = new System.Drawing.Size(96, 16);
            this.ExportPath.TabIndex = 28;
            this.ExportPath.Text = "Export Path *";
            // 
            // ExportPathNotes
            // 
            this.ExportPathNotes.AutoSize = true;
            this.ExportPathNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ExportPathNotes.Location = new System.Drawing.Point(4, 729);
            this.ExportPathNotes.Name = "ExportPathNotes";
            this.ExportPathNotes.Size = new System.Drawing.Size(160, 13);
            this.ExportPathNotes.TabIndex = 30;
            this.ExportPathNotes.Text = "Enter a folder path (no file name)";
            // 
            // IncludeHeadersCheckBox
            // 
            this.IncludeHeadersCheckBox.AutoSize = true;
            this.IncludeHeadersCheckBox.Checked = true;
            this.IncludeHeadersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IncludeHeadersCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IncludeHeadersCheckBox.Location = new System.Drawing.Point(9, 373);
            this.IncludeHeadersCheckBox.Name = "IncludeHeadersCheckBox";
            this.IncludeHeadersCheckBox.Size = new System.Drawing.Size(130, 21);
            this.IncludeHeadersCheckBox.TabIndex = 62;
            this.IncludeHeadersCheckBox.Text = "Include Headers";
            this.IncludeHeadersCheckBox.UseVisualStyleBackColor = true;
            // 
            // ImportDelimeterListBox
            // 
            this.ImportDelimeterListBox.FormattingEnabled = true;
            this.ImportDelimeterListBox.Items.AddRange(new object[] {
            "COMMA",
            "PIPE",
            "TAB",
            "FIXED WIDTH"});
            this.ImportDelimeterListBox.Location = new System.Drawing.Point(169, 48);
            this.ImportDelimeterListBox.Name = "ImportDelimeterListBox";
            this.ImportDelimeterListBox.Size = new System.Drawing.Size(127, 69);
            this.ImportDelimeterListBox.TabIndex = 5;
            this.ImportDelimeterListBox.SelectedIndexChanged += new System.EventHandler(this.ImportDelimeterListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Import Delimeter *";
            // 
            // ExportDelimeterListBox
            // 
            this.ExportDelimeterListBox.FormattingEnabled = true;
            this.ExportDelimeterListBox.Items.AddRange(new object[] {
            "COMMA",
            "PIPE",
            "TAB",
            "FIXED WIDTH"});
            this.ExportDelimeterListBox.Location = new System.Drawing.Point(160, 298);
            this.ExportDelimeterListBox.Name = "ExportDelimeterListBox";
            this.ExportDelimeterListBox.Size = new System.Drawing.Size(127, 69);
            this.ExportDelimeterListBox.TabIndex = 60;
            this.ExportDelimeterListBox.SelectedIndexChanged += new System.EventHandler(this.ExportDelimeterListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Export Delimiter *";
            // 
            // ExportQualifierListBox
            // 
            this.ExportQualifierListBox.FormattingEnabled = true;
            this.ExportQualifierListBox.Items.AddRange(new object[] {
            "\"",
            "\'",
            "<NO QUALIFIER>"});
            this.ExportQualifierListBox.Location = new System.Drawing.Point(299, 298);
            this.ExportQualifierListBox.Name = "ExportQualifierListBox";
            this.ExportQualifierListBox.Size = new System.Drawing.Size(127, 69);
            this.ExportQualifierListBox.TabIndex = 61;
            this.ExportQualifierListBox.SelectedIndexChanged += new System.EventHandler(this.ExportQualifierListBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label6.Location = new System.Drawing.Point(296, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Export Qualifier";
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(14, 774);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(175, 42);
            this.ExportButton.TabIndex = 77;
            this.ExportButton.Text = "EXPORT";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(10, 774);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(175, 42);
            this.ImportButton.TabIndex = 14;
            this.ImportButton.Text = "IMPORT";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // ImportPanel
            // 
            this.ImportPanel.Controls.Add(this.ColumnTypeFilePathTextBox);
            this.ImportPanel.Controls.Add(this.label29);
            this.ImportPanel.Controls.Add(this.label33);
            this.ImportPanel.Controls.Add(this.label32);
            this.ImportPanel.Controls.Add(this.label31);
            this.ImportPanel.Controls.Add(this.panel3);
            this.ImportPanel.Controls.Add(this.label30);
            this.ImportPanel.Controls.Add(this.FasterImportCheckBox);
            this.ImportPanel.Controls.Add(this.ImportTemplate);
            this.ImportPanel.Controls.Add(this.label24);
            this.ImportPanel.Controls.Add(this.label23);
            this.ImportPanel.Controls.Add(this.ImportChooseFileButton);
            this.ImportPanel.Controls.Add(this.InsertToExistingTableCheckBox);
            this.ImportPanel.Controls.Add(this.DoubleQuoted);
            this.ImportPanel.Controls.Add(this.label10);
            this.ImportPanel.Controls.Add(this.ImportToSingleTableTextBox);
            this.ImportPanel.Controls.Add(this.label12);
            this.ImportPanel.Controls.Add(this.FixedWidthColumnFilePathLabel);
            this.ImportPanel.Controls.Add(this.FixedWidthColumnFilePathTextBox);
            this.ImportPanel.Controls.Add(this.label9);
            this.ImportPanel.Controls.Add(this.label7);
            this.ImportPanel.Controls.Add(this.ImportButton);
            this.ImportPanel.Controls.Add(this.ImportDelimeterListBox);
            this.ImportPanel.Controls.Add(this.ExtensionListBoxImport);
            this.ImportPanel.Controls.Add(this.label2);
            this.ImportPanel.Controls.Add(this.Extension);
            this.ImportPanel.Controls.Add(this.ImportPath);
            this.ImportPanel.Controls.Add(this.ImportPathNotes);
            this.ImportPanel.Controls.Add(this.ImportPathTextBox);
            this.ImportPanel.Location = new System.Drawing.Point(12, 35);
            this.ImportPanel.Name = "ImportPanel";
            this.ImportPanel.Size = new System.Drawing.Size(386, 819);
            this.ImportPanel.TabIndex = 50;
            // 
            // ColumnTypeFilePathTextBox
            // 
            this.ColumnTypeFilePathTextBox.Location = new System.Drawing.Point(5, 565);
            this.ColumnTypeFilePathTextBox.Name = "ColumnTypeFilePathTextBox";
            this.ColumnTypeFilePathTextBox.Size = new System.Drawing.Size(291, 20);
            this.ColumnTypeFilePathTextBox.TabIndex = 10;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(11, 521);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(144, 52);
            this.label29.TabIndex = 85;
            this.label29.Text = "ex:\r\nFIRST VARCHAR(30)\r\n[CREDIT SCORE] INTEGER\r\n\r\n";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label33.Location = new System.Drawing.Point(11, 160);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(246, 39);
            this.label33.TabIndex = 91;
            this.label33.Text = "(If the file is quoted, please select this)\r\n(un-select when dealing with files w" +
    "ith un-escaped \r\ndouble quotes!)";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("MS UI Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label32.Location = new System.Drawing.Point(0, 672);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(182, 8);
            this.label32.TabIndex = 90;
            this.label32.Text = "_________________________________________________________________________________" +
    "________\r\n";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("MS UI Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label31.Location = new System.Drawing.Point(-2, 435);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(182, 8);
            this.label31.TabIndex = 86;
            this.label31.Text = "_________________________________________________________________________________" +
    "________\r\n";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ColumnTypeVarcharDefaultRadioButton);
            this.panel3.Controls.Add(this.ColumnTypeUseFileRadioButton);
            this.panel3.Location = new System.Drawing.Point(6, 467);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 73);
            this.panel3.TabIndex = 73;
            // 
            // ColumnTypeVarcharDefaultRadioButton
            // 
            this.ColumnTypeVarcharDefaultRadioButton.AutoSize = true;
            this.ColumnTypeVarcharDefaultRadioButton.Checked = true;
            this.ColumnTypeVarcharDefaultRadioButton.Location = new System.Drawing.Point(7, 7);
            this.ColumnTypeVarcharDefaultRadioButton.Name = "ColumnTypeVarcharDefaultRadioButton";
            this.ColumnTypeVarcharDefaultRadioButton.Size = new System.Drawing.Size(329, 17);
            this.ColumnTypeVarcharDefaultRadioButton.TabIndex = 63;
            this.ColumnTypeVarcharDefaultRadioButton.TabStop = true;
            this.ColumnTypeVarcharDefaultRadioButton.Text = "Default to VARCHAR(255) for Delimeted/VARCHAR(N) for Fixed";
            this.ColumnTypeVarcharDefaultRadioButton.UseVisualStyleBackColor = true;
            // 
            // ColumnTypeUseFileRadioButton
            // 
            this.ColumnTypeUseFileRadioButton.AutoSize = true;
            this.ColumnTypeUseFileRadioButton.Location = new System.Drawing.Point(8, 35);
            this.ColumnTypeUseFileRadioButton.Name = "ColumnTypeUseFileRadioButton";
            this.ColumnTypeUseFileRadioButton.Size = new System.Drawing.Size(158, 17);
            this.ColumnTypeUseFileRadioButton.TabIndex = 65;
            this.ColumnTypeUseFileRadioButton.Text = "File Path with Column Types";
            this.ColumnTypeUseFileRadioButton.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label30.Location = new System.Drawing.Point(3, 447);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(91, 17);
            this.label30.TabIndex = 84;
            this.label30.Text = "Column Type";
            // 
            // FasterImportCheckBox
            // 
            this.FasterImportCheckBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.FasterImportCheckBox.AutoSize = true;
            this.FasterImportCheckBox.Location = new System.Drawing.Point(5, 628);
            this.FasterImportCheckBox.Name = "FasterImportCheckBox";
            this.FasterImportCheckBox.Size = new System.Drawing.Size(277, 43);
            this.FasterImportCheckBox.TabIndex = 11;
            this.FasterImportCheckBox.Text = "Faster Import \r\n(more error-prone: doesn\'t remove irregular chars and \r\ndoesn\'t l" +
    "imit fields to 255 chars)";
            this.FasterImportCheckBox.UseVisualStyleBackColor = true;
            // 
            // ImportTemplate
            // 
            this.ImportTemplate.FormattingEnabled = true;
            this.ImportTemplate.Items.AddRange(new object[] {
            "BMW GENESCO (UNQUOTED PIPE)",
            "BMW ALWAYS ON (UNQUOTED PIPE)"});
            this.ImportTemplate.Location = new System.Drawing.Point(72, 8);
            this.ImportTemplate.Name = "ImportTemplate";
            this.ImportTemplate.Size = new System.Drawing.Size(301, 21);
            this.ImportTemplate.TabIndex = 3;
            this.ImportTemplate.SelectedIndexChanged += new System.EventHandler(this.ImportTemplate_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("MS UI Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label24.Location = new System.Drawing.Point(-2, 211);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(182, 8);
            this.label24.TabIndex = 82;
            this.label24.Text = "_________________________________________________________________________________" +
    "________\r\n";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("MS UI Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label23.Location = new System.Drawing.Point(-2, 325);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(182, 8);
            this.label23.TabIndex = 81;
            this.label23.Text = "_________________________________________________________________________________" +
    "________\r\n";
            // 
            // ImportChooseFileButton
            // 
            this.ImportChooseFileButton.Location = new System.Drawing.Point(298, 732);
            this.ImportChooseFileButton.Name = "ImportChooseFileButton";
            this.ImportChooseFileButton.Size = new System.Drawing.Size(66, 36);
            this.ImportChooseFileButton.TabIndex = 13;
            this.ImportChooseFileButton.Text = "Choose File";
            this.ImportChooseFileButton.UseVisualStyleBackColor = true;
            this.ImportChooseFileButton.Click += new System.EventHandler(this.ImportChooseFileButton_Click);
            // 
            // InsertToExistingTableCheckBox
            // 
            this.InsertToExistingTableCheckBox.AutoSize = true;
            this.InsertToExistingTableCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InsertToExistingTableCheckBox.Location = new System.Drawing.Point(10, 224);
            this.InsertToExistingTableCheckBox.Name = "InsertToExistingTableCheckBox";
            this.InsertToExistingTableCheckBox.Size = new System.Drawing.Size(170, 21);
            this.InsertToExistingTableCheckBox.TabIndex = 7;
            this.InsertToExistingTableCheckBox.Text = "Insert to Existing Table";
            this.InsertToExistingTableCheckBox.UseVisualStyleBackColor = true;
            // 
            // DoubleQuoted
            // 
            this.DoubleQuoted.AutoSize = true;
            this.DoubleQuoted.Checked = true;
            this.DoubleQuoted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DoubleQuoted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DoubleQuoted.Location = new System.Drawing.Point(10, 136);
            this.DoubleQuoted.Name = "DoubleQuoted";
            this.DoubleQuoted.Size = new System.Drawing.Size(128, 21);
            this.DoubleQuoted.TabIndex = 6;
            this.DoubleQuoted.Text = "Double-Quoted ";
            this.DoubleQuoted.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(5, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(257, 39);
            this.label10.TabIndex = 56;
            this.label10.Text = "Enter a Table Name to Import all files to a single table\r\n(must have identical he" +
    "aders)\r\n(or if a single file, enter a name here to re-name it)";
            // 
            // ImportToSingleTableTextBox
            // 
            this.ImportToSingleTableTextBox.Location = new System.Drawing.Point(11, 302);
            this.ImportToSingleTableTextBox.Name = "ImportToSingleTableTextBox";
            this.ImportToSingleTableTextBox.Size = new System.Drawing.Size(287, 20);
            this.ImportToSingleTableTextBox.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 372);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 39);
            this.label12.TabIndex = 53;
            this.label12.Text = "ex:\r\nFIRST 25\r\n[CREDIT SCORE] 3\r\n";
            // 
            // FixedWidthColumnFilePathLabel
            // 
            this.FixedWidthColumnFilePathLabel.AutoSize = true;
            this.FixedWidthColumnFilePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FixedWidthColumnFilePathLabel.Location = new System.Drawing.Point(2, 338);
            this.FixedWidthColumnFilePathLabel.Name = "FixedWidthColumnFilePathLabel";
            this.FixedWidthColumnFilePathLabel.Size = new System.Drawing.Size(309, 34);
            this.FixedWidthColumnFilePathLabel.TabIndex = 52;
            this.FixedWidthColumnFilePathLabel.Text = "Fixed Width Column File Path\r\n (^required with FIXED WIDTH Import Delimeter)";
            // 
            // FixedWidthColumnFilePathTextBox
            // 
            this.FixedWidthColumnFilePathTextBox.Location = new System.Drawing.Point(5, 414);
            this.FixedWidthColumnFilePathTextBox.Name = "FixedWidthColumnFilePathTextBox";
            this.FixedWidthColumnFilePathTextBox.Size = new System.Drawing.Size(291, 20);
            this.FixedWidthColumnFilePathTextBox.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(3, 713);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 26);
            this.label9.TabIndex = 50;
            this.label9.Text = "  -Enter folder path (no extension) to import every file in \r\n   that folder that" +
    " matches Import File Type.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 49;
            this.label7.Text = "Import";
            // 
            // ExportPanel
            // 
            this.ExportPanel.Controls.Add(this.RemoveQualInValCheckBox);
            this.ExportPanel.Controls.Add(this.panel4);
            this.ExportPanel.Controls.Add(this.FromTextBox);
            this.ExportPanel.Controls.Add(this.label28);
            this.ExportPanel.Controls.Add(this.ExportTemplate);
            this.ExportPanel.Controls.Add(this.ListColumnsForSelectedTablesButton);
            this.ExportPanel.Controls.Add(this.label27);
            this.ExportPanel.Controls.Add(this.label20);
            this.ExportPanel.Controls.Add(this.SelectTextBox);
            this.ExportPanel.Controls.Add(this.label26);
            this.ExportPanel.Controls.Add(this.GroupByTextBox);
            this.ExportPanel.Controls.Add(this.label25);
            this.ExportPanel.Controls.Add(this.label18);
            this.ExportPanel.Controls.Add(this.WhereTextBox);
            this.ExportPanel.Controls.Add(this.label22);
            this.ExportPanel.Controls.Add(this.TablesToExportListFromSql);
            this.ExportPanel.Controls.Add(this.SplitAmounNumericUpDown);
            this.ExportPanel.Controls.Add(this.label21);
            this.ExportPanel.Controls.Add(this.label19);
            this.ExportPanel.Controls.Add(this.IncludeHeaderInSplitFilesCheckBox);
            this.ExportPanel.Controls.Add(this.OrderByTextBox);
            this.ExportPanel.Controls.Add(this.label17);
            this.ExportPanel.Controls.Add(this.panel2);
            this.ExportPanel.Controls.Add(this.label5);
            this.ExportPanel.Controls.Add(this.label1);
            this.ExportPanel.Controls.Add(this.ExportChooseFileButton);
            this.ExportPanel.Controls.Add(this.label14);
            this.ExportPanel.Controls.Add(this.LoadSqlTables);
            this.ExportPanel.Controls.Add(this.label8);
            this.ExportPanel.Controls.Add(this.ExportButton);
            this.ExportPanel.Controls.Add(this.TablesToExportCommaList);
            this.ExportPanel.Controls.Add(this.ExportQualifierListBox);
            this.ExportPanel.Controls.Add(this.label4);
            this.ExportPanel.Controls.Add(this.label6);
            this.ExportPanel.Controls.Add(this.TablesToExportRegex);
            this.ExportPanel.Controls.Add(this.ExportDelimeterListBox);
            this.ExportPanel.Controls.Add(this.OutputTypeListBox);
            this.ExportPanel.Controls.Add(this.label3);
            this.ExportPanel.Controls.Add(this.ExportPath);
            this.ExportPanel.Controls.Add(this.ExportPathTextBox);
            this.ExportPanel.Controls.Add(this.IncludeHeadersCheckBox);
            this.ExportPanel.Controls.Add(this.ExportPathNotes);
            this.ExportPanel.Controls.Add(this.panel1);
            this.ExportPanel.Location = new System.Drawing.Point(404, 35);
            this.ExportPanel.Name = "ExportPanel";
            this.ExportPanel.Size = new System.Drawing.Size(558, 819);
            this.ExportPanel.TabIndex = 51;
            // 
            // RemoveQualInValCheckBox
            // 
            this.RemoveQualInValCheckBox.AutoSize = true;
            this.RemoveQualInValCheckBox.Checked = true;
            this.RemoveQualInValCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RemoveQualInValCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveQualInValCheckBox.Location = new System.Drawing.Point(437, 353);
            this.RemoveQualInValCheckBox.Name = "RemoveQualInValCheckBox";
            this.RemoveQualInValCheckBox.Size = new System.Drawing.Size(113, 30);
            this.RemoveQualInValCheckBox.TabIndex = 90;
            this.RemoveQualInValCheckBox.Text = "Remove qualifiers \r\nalready in value";
            this.RemoveQualInValCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.QualifyAllRadioButton);
            this.panel4.Controls.Add(this.QualifyIfDelimeterRadioButton);
            this.panel4.Location = new System.Drawing.Point(432, 298);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(123, 58);
            this.panel4.TabIndex = 73;
            // 
            // QualifyAllRadioButton
            // 
            this.QualifyAllRadioButton.AutoSize = true;
            this.QualifyAllRadioButton.Location = new System.Drawing.Point(7, 7);
            this.QualifyAllRadioButton.Name = "QualifyAllRadioButton";
            this.QualifyAllRadioButton.Size = new System.Drawing.Size(71, 17);
            this.QualifyAllRadioButton.TabIndex = 63;
            this.QualifyAllRadioButton.Text = "Qualify All";
            this.QualifyAllRadioButton.UseVisualStyleBackColor = true;
            // 
            // QualifyIfDelimeterRadioButton
            // 
            this.QualifyIfDelimeterRadioButton.AutoSize = true;
            this.QualifyIfDelimeterRadioButton.Checked = true;
            this.QualifyIfDelimeterRadioButton.Location = new System.Drawing.Point(7, 24);
            this.QualifyIfDelimeterRadioButton.Name = "QualifyIfDelimeterRadioButton";
            this.QualifyIfDelimeterRadioButton.Size = new System.Drawing.Size(113, 30);
            this.QualifyIfDelimeterRadioButton.TabIndex = 64;
            this.QualifyIfDelimeterRadioButton.TabStop = true;
            this.QualifyIfDelimeterRadioButton.Text = "Qualify if delimeter \r\nin field";
            this.QualifyIfDelimeterRadioButton.UseVisualStyleBackColor = true;
            // 
            // FromTextBox
            // 
            this.FromTextBox.Location = new System.Drawing.Point(123, 502);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.Size = new System.Drawing.Size(347, 20);
            this.FromTextBox.TabIndex = 70;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(5, 505);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(118, 13);
            this.label28.TabIndex = 89;
            this.label28.Text = "FROM [TABLE_NAME]";
            // 
            // ExportTemplate
            // 
            this.ExportTemplate.FormattingEnabled = true;
            this.ExportTemplate.Items.AddRange(new object[] {
            "BMW GENESCO (UNQUOTED PIPE)",
            "BMW ALWAYS ON (UNQUOTED PIPE)",
            "ADROLL (NO HEADER, MAX SIZE 10MB)",
            "LINKEDIN (MAX SIZE 19MB)",
            "TIKTOK (MAX SIZE 1000MB)",
            "DIGI ORDERED BY PRIORITY"});
            this.ExportTemplate.Location = new System.Drawing.Point(184, 8);
            this.ExportTemplate.Name = "ExportTemplate";
            this.ExportTemplate.Size = new System.Drawing.Size(301, 21);
            this.ExportTemplate.TabIndex = 51;
            this.ExportTemplate.SelectedIndexChanged += new System.EventHandler(this.ExportTemplate_SelectedIndexChanged);
            // 
            // ListColumnsForSelectedTablesButton
            // 
            this.ListColumnsForSelectedTablesButton.Location = new System.Drawing.Point(369, 610);
            this.ListColumnsForSelectedTablesButton.Name = "ListColumnsForSelectedTablesButton";
            this.ListColumnsForSelectedTablesButton.Size = new System.Drawing.Size(109, 36);
            this.ListColumnsForSelectedTablesButton.TabIndex = 74;
            this.ListColumnsForSelectedTablesButton.Text = "List Columns for Selected Tables";
            this.ListColumnsForSelectedTablesButton.UseVisualStyleBackColor = true;
            this.ListColumnsForSelectedTablesButton.Click += new System.EventHandler(this.ListColumnsForSelectedTablesButton_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label27.Location = new System.Drawing.Point(7, 451);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(116, 17);
            this.label27.TabIndex = 87;
            this.label27.Text = "Modify the Query";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 602);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(355, 52);
            this.label20.TabIndex = 83;
            this.label20.Text = resources.GetString("label20.Text");
            // 
            // SelectTextBox
            // 
            this.SelectTextBox.Location = new System.Drawing.Point(76, 476);
            this.SelectTextBox.Name = "SelectTextBox";
            this.SelectTextBox.Size = new System.Drawing.Size(394, 20);
            this.SelectTextBox.TabIndex = 69;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(5, 479);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(48, 13);
            this.label26.TabIndex = 85;
            this.label26.Text = "SELECT";
            // 
            // GroupByTextBox
            // 
            this.GroupByTextBox.Location = new System.Drawing.Point(77, 553);
            this.GroupByTextBox.Name = "GroupByTextBox";
            this.GroupByTextBox.Size = new System.Drawing.Size(394, 20);
            this.GroupByTextBox.TabIndex = 72;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 556);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 13);
            this.label25.TabIndex = 83;
            this.label25.Text = "GROUP BY";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("MS UI Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label18.Location = new System.Drawing.Point(-2, 699);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(182, 8);
            this.label18.TabIndex = 82;
            this.label18.Text = "_________________________________________________________________________________" +
    "________\r\n";
            // 
            // WhereTextBox
            // 
            this.WhereTextBox.Location = new System.Drawing.Point(77, 528);
            this.WhereTextBox.Name = "WhereTextBox";
            this.WhereTextBox.Size = new System.Drawing.Size(394, 20);
            this.WhereTextBox.TabIndex = 71;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 531);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 13);
            this.label22.TabIndex = 80;
            this.label22.Text = "WHERE";
            // 
            // TablesToExportListFromSql
            // 
            this.TablesToExportListFromSql.FormattingEnabled = true;
            this.TablesToExportListFromSql.Location = new System.Drawing.Point(14, 133);
            this.TablesToExportListFromSql.Name = "TablesToExportListFromSql";
            this.TablesToExportListFromSql.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.TablesToExportListFromSql.Size = new System.Drawing.Size(471, 134);
            this.TablesToExportListFromSql.TabIndex = 58;
            this.TablesToExportListFromSql.SelectedIndexChanged += new System.EventHandler(this.TablesToExportListFromSql_SelectedIndexChanged);
            // 
            // SplitAmounNumericUpDown
            // 
            this.SplitAmounNumericUpDown.Location = new System.Drawing.Point(76, 423);
            this.SplitAmounNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.SplitAmounNumericUpDown.Name = "SplitAmounNumericUpDown";
            this.SplitAmounNumericUpDown.Size = new System.Drawing.Size(177, 20);
            this.SplitAmounNumericUpDown.TabIndex = 67;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("MS UI Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label21.Location = new System.Drawing.Point(0, 390);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(182, 8);
            this.label21.TabIndex = 79;
            this.label21.Text = "_________________________________________________________________________________" +
    "________\r\n";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("MS UI Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label19.Location = new System.Drawing.Point(-28, 443);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(182, 8);
            this.label19.TabIndex = 58;
            this.label19.Text = "_________________________________________________________________________________" +
    "________\r\n";
            // 
            // IncludeHeaderInSplitFilesCheckBox
            // 
            this.IncludeHeaderInSplitFilesCheckBox.AutoSize = true;
            this.IncludeHeaderInSplitFilesCheckBox.Checked = true;
            this.IncludeHeaderInSplitFilesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IncludeHeaderInSplitFilesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IncludeHeaderInSplitFilesCheckBox.Location = new System.Drawing.Point(138, 373);
            this.IncludeHeaderInSplitFilesCheckBox.Name = "IncludeHeaderInSplitFilesCheckBox";
            this.IncludeHeaderInSplitFilesCheckBox.Size = new System.Drawing.Size(293, 21);
            this.IncludeHeaderInSplitFilesCheckBox.TabIndex = 68;
            this.IncludeHeaderInSplitFilesCheckBox.Text = "Include Headers In Split Files after the first";
            this.IncludeHeaderInSplitFilesCheckBox.UseVisualStyleBackColor = true;
            // 
            // OrderByTextBox
            // 
            this.OrderByTextBox.Location = new System.Drawing.Point(76, 579);
            this.OrderByTextBox.Name = "OrderByTextBox";
            this.OrderByTextBox.Size = new System.Drawing.Size(394, 20);
            this.OrderByTextBox.TabIndex = 73;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 582);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 73;
            this.label17.Text = "ORDER BY";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SizeSplit1024RadioButton);
            this.panel2.Controls.Add(this.NoSplitRadioButton);
            this.panel2.Controls.Add(this.SizeSplitRadioButton);
            this.panel2.Controls.Add(this.RowSplitRadioButton);
            this.panel2.Location = new System.Drawing.Point(77, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 27);
            this.panel2.TabIndex = 72;
            // 
            // SizeSplit1024RadioButton
            // 
            this.SizeSplit1024RadioButton.AutoSize = true;
            this.SizeSplit1024RadioButton.Location = new System.Drawing.Point(257, 7);
            this.SizeSplit1024RadioButton.Name = "SizeSplit1024RadioButton";
            this.SizeSplit1024RadioButton.Size = new System.Drawing.Size(128, 17);
            this.SizeSplit1024RadioButton.TabIndex = 66;
            this.SizeSplit1024RadioButton.Text = "Size MB (1,024 bytes)\r\n";
            this.SizeSplit1024RadioButton.UseVisualStyleBackColor = true;
            // 
            // NoSplitRadioButton
            // 
            this.NoSplitRadioButton.AutoSize = true;
            this.NoSplitRadioButton.Checked = true;
            this.NoSplitRadioButton.Location = new System.Drawing.Point(7, 7);
            this.NoSplitRadioButton.Name = "NoSplitRadioButton";
            this.NoSplitRadioButton.Size = new System.Drawing.Size(62, 17);
            this.NoSplitRadioButton.TabIndex = 63;
            this.NoSplitRadioButton.TabStop = true;
            this.NoSplitRadioButton.Text = "No Split";
            this.NoSplitRadioButton.UseVisualStyleBackColor = true;
            // 
            // SizeSplitRadioButton
            // 
            this.SizeSplitRadioButton.AutoSize = true;
            this.SizeSplitRadioButton.Location = new System.Drawing.Point(123, 7);
            this.SizeSplitRadioButton.Name = "SizeSplitRadioButton";
            this.SizeSplitRadioButton.Size = new System.Drawing.Size(128, 17);
            this.SizeSplitRadioButton.TabIndex = 65;
            this.SizeSplitRadioButton.Text = "Size MB (1,000 bytes)";
            this.SizeSplitRadioButton.UseVisualStyleBackColor = true;
            // 
            // RowSplitRadioButton
            // 
            this.RowSplitRadioButton.AutoSize = true;
            this.RowSplitRadioButton.Location = new System.Drawing.Point(70, 7);
            this.RowSplitRadioButton.Name = "RowSplitRadioButton";
            this.RowSplitRadioButton.Size = new System.Drawing.Size(52, 17);
            this.RowSplitRadioButton.TabIndex = 64;
            this.RowSplitRadioButton.Text = "Rows";
            this.RowSplitRadioButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Split Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Split Files By:";
            // 
            // ExportChooseFileButton
            // 
            this.ExportChooseFileButton.Location = new System.Drawing.Point(305, 729);
            this.ExportChooseFileButton.Name = "ExportChooseFileButton";
            this.ExportChooseFileButton.Size = new System.Drawing.Size(66, 36);
            this.ExportChooseFileButton.TabIndex = 76;
            this.ExportChooseFileButton.Text = "Choose Folder";
            this.ExportChooseFileButton.UseVisualStyleBackColor = true;
            this.ExportChooseFileButton.Click += new System.EventHandler(this.ExportChooseFileButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(222, 16);
            this.label14.TabIndex = 54;
            this.label14.Text = "Choose Table Export Method: *";
            // 
            // LoadSqlTables
            // 
            this.LoadSqlTables.Location = new System.Drawing.Point(149, 113);
            this.LoadSqlTables.Name = "LoadSqlTables";
            this.LoadSqlTables.Size = new System.Drawing.Size(152, 19);
            this.LoadSqlTables.TabIndex = 57;
            this.LoadSqlTables.Text = "LOAD TABLES BELOW";
            this.LoadSqlTables.UseVisualStyleBackColor = true;
            this.LoadSqlTables.Click += new System.EventHandler(this.LoadSqlTables_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 24);
            this.label8.TabIndex = 50;
            this.label8.Text = "Export";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TablePickerRadioButton);
            this.panel1.Controls.Add(this.RegexPatternTableSearchRadioButton);
            this.panel1.Controls.Add(this.CommaSeperatedListTableSearchRadioButton);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 100);
            this.panel1.TabIndex = 55;
            // 
            // TablePickerRadioButton
            // 
            this.TablePickerRadioButton.AutoSize = true;
            this.TablePickerRadioButton.Checked = true;
            this.TablePickerRadioButton.Location = new System.Drawing.Point(13, 68);
            this.TablePickerRadioButton.Name = "TablePickerRadioButton";
            this.TablePickerRadioButton.Size = new System.Drawing.Size(87, 17);
            this.TablePickerRadioButton.TabIndex = 56;
            this.TablePickerRadioButton.TabStop = true;
            this.TablePickerRadioButton.Text = "Table picker:";
            this.TablePickerRadioButton.UseVisualStyleBackColor = true;
            // 
            // RegexPatternTableSearchRadioButton
            // 
            this.RegexPatternTableSearchRadioButton.AutoSize = true;
            this.RegexPatternTableSearchRadioButton.Location = new System.Drawing.Point(13, 45);
            this.RegexPatternTableSearchRadioButton.Name = "RegexPatternTableSearchRadioButton";
            this.RegexPatternTableSearchRadioButton.Size = new System.Drawing.Size(95, 17);
            this.RegexPatternTableSearchRadioButton.TabIndex = 54;
            this.RegexPatternTableSearchRadioButton.Text = "Regex pattern:";
            this.RegexPatternTableSearchRadioButton.UseVisualStyleBackColor = true;
            // 
            // CommaSeperatedListTableSearchRadioButton
            // 
            this.CommaSeperatedListTableSearchRadioButton.AutoSize = true;
            this.CommaSeperatedListTableSearchRadioButton.Location = new System.Drawing.Point(13, 3);
            this.CommaSeperatedListTableSearchRadioButton.Name = "CommaSeperatedListTableSearchRadioButton";
            this.CommaSeperatedListTableSearchRadioButton.Size = new System.Drawing.Size(128, 17);
            this.CommaSeperatedListTableSearchRadioButton.TabIndex = 52;
            this.CommaSeperatedListTableSearchRadioButton.Text = "Comma seperated list:";
            this.CommaSeperatedListTableSearchRadioButton.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(615, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 16);
            this.label13.TabIndex = 52;
            this.label13.Text = "* required";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(710, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(169, 16);
            this.label15.TabIndex = 53;
            this.label15.Text = "^ conditionally required";
            // 
            // ServerComboBox
            // 
            this.ServerComboBox.FormattingEnabled = true;
            this.ServerComboBox.Items.AddRange(new object[] {
            "SQL04",
            "SQL05"});
            this.ServerComboBox.Location = new System.Drawing.Point(92, 7);
            this.ServerComboBox.Name = "ServerComboBox";
            this.ServerComboBox.Size = new System.Drawing.Size(169, 21);
            this.ServerComboBox.TabIndex = 1;
            this.ServerComboBox.Text = "SQL04";
            // 
            // DatabaseComboBox
            // 
            this.DatabaseComboBox.FormattingEnabled = true;
            this.DatabaseComboBox.Items.AddRange(new object[] {
            "BMW",
            "TEMP_BMW",
            "TEMP_EA",
            "TEMP_J",
            "TEMP_JC",
            "TEMP_LG",
            "TEMP_NS",
            "TEMP_OK"});
            this.DatabaseComboBox.Location = new System.Drawing.Point(404, 7);
            this.DatabaseComboBox.Name = "DatabaseComboBox";
            this.DatabaseComboBox.Size = new System.Drawing.Size(169, 21);
            this.DatabaseComboBox.TabIndex = 2;
            this.DatabaseComboBox.Text = "TEMP_OK";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Location = new System.Drawing.Point(391, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 744);
            this.label11.TabIndex = 56;
            this.label11.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n" +
    "|\r\n|\r\n|\r\n\r\n";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label16.Location = new System.Drawing.Point(24, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(745, 12);
            this.label16.TabIndex = 57;
            this.label16.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "________________________\r\n";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 866);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DatabaseComboBox);
            this.Controls.Add(this.ServerComboBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Database);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.ImportPanel);
            this.Controls.Add(this.ExportPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ImportPanel.ResumeLayout(false);
            this.ImportPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ExportPanel.ResumeLayout(false);
            this.ExportPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitAmounNumericUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ImportPath;
        private System.Windows.Forms.Label Extension;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ImportPathTextBox;
        private System.Windows.Forms.Label Server;
        private System.Windows.Forms.Label Database;
        private System.Windows.Forms.ListBox ExtensionListBoxImport;
        private System.Windows.Forms.TextBox TablesToExportCommaList;
        private System.Windows.Forms.TextBox TablesToExportRegex;
        private System.Windows.Forms.Label ImportPathNotes;
        private System.Windows.Forms.ListBox OutputTypeListBox;
        private System.Windows.Forms.TextBox ExportPathTextBox;
        private System.Windows.Forms.Label ExportPath;
        private System.Windows.Forms.Label ExportPathNotes;
        private System.Windows.Forms.CheckBox IncludeHeadersCheckBox;
        private System.Windows.Forms.ListBox ImportDelimeterListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ExportDelimeterListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ExportQualifierListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Panel ImportPanel;
        private System.Windows.Forms.Panel ExportPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox TablesToExportListFromSql;
        private System.Windows.Forms.Label FixedWidthColumnFilePathLabel;
        private System.Windows.Forms.TextBox FixedWidthColumnFilePathTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ImportToSingleTableTextBox;
        private System.Windows.Forms.Button LoadSqlTables;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton TablePickerRadioButton;
        private System.Windows.Forms.RadioButton RegexPatternTableSearchRadioButton;
        private System.Windows.Forms.RadioButton CommaSeperatedListTableSearchRadioButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox ServerComboBox;
        private System.Windows.Forms.ComboBox DatabaseComboBox;
        private System.Windows.Forms.CheckBox DoubleQuoted;
        private System.Windows.Forms.CheckBox InsertToExistingTableCheckBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button ImportChooseFileButton;
        private System.Windows.Forms.Button ExportChooseFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown SplitAmounNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton RowSplitRadioButton;
        private System.Windows.Forms.RadioButton SizeSplitRadioButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox OrderByTextBox;
        private System.Windows.Forms.RadioButton NoSplitRadioButton;
        private System.Windows.Forms.CheckBox IncludeHeaderInSplitFilesCheckBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox WhereTextBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox SelectTextBox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox GroupByTextBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button ListColumnsForSelectedTablesButton;
        private System.Windows.Forms.ComboBox ImportTemplate;
        private System.Windows.Forms.ComboBox ExportTemplate;
        private System.Windows.Forms.CheckBox FasterImportCheckBox;
        private System.Windows.Forms.TextBox FromTextBox;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.RadioButton SizeSplit1024RadioButton;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox ColumnTypeFilePathTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton ColumnTypeVarcharDefaultRadioButton;
        private System.Windows.Forms.RadioButton ColumnTypeUseFileRadioButton;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton QualifyAllRadioButton;
        private System.Windows.Forms.RadioButton QualifyIfDelimeterRadioButton;
        private System.Windows.Forms.CheckBox RemoveQualInValCheckBox;
    }
}

