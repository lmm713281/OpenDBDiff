using System.ComponentModel;
using System.Windows.Forms;
using ScintillaNET;

namespace DBDiff.Front
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lblMessage = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtNewObject = new ScintillaNET.Scintilla();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtOldObject = new ScintillaNET.Scintilla();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.txtDiff = new ScintillaNET.Scintilla();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.schemaTreeView1 = new DBDiff.Front.SchemaTreeView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSyncScript = new ScintillaNET.Scintilla();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUpdateAll = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnCompareTableData = new System.Windows.Forms.Button();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SourceGroupBox = new System.Windows.Forms.GroupBox();
            this.DestinationGroupBox = new System.Windows.Forms.GroupBox();
            this.SwapConnectionsButton = new System.Windows.Forms.Button();
            this.GroupDb = new System.Windows.Forms.GroupBox();
            this.optSybase = new System.Windows.Forms.RadioButton();
            this.optMySQL = new System.Windows.Forms.RadioButton();
            this.optSQL2005 = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewObject)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldObject)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiff)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyncScript)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.GroupDb.SuspendLayout();
            this.SuspendLayout();
            //
            // lblMessage
            //
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(6, 528);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 4;
            //
            // tabControl1
            //
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(7, 225);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(855, 500);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            //
            // tabPage2
            //
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(847, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Schema";
            this.tabPage2.UseVisualStyleBackColor = true;
            //
            // tabControl2
            //
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Location = new System.Drawing.Point(350, 50);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(491, 419);
            this.tabControl2.TabIndex = 3;
            //
            // tabPage4
            //
            this.tabPage4.Controls.Add(this.txtNewObject);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(483, 393);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "New object";
            this.tabPage4.UseVisualStyleBackColor = true;
            //
            // txtNewObject
            //
            this.txtNewObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewObject.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewObject.Location = new System.Drawing.Point(3, 3);
            this.txtNewObject.Name = "txtNewObject";
            this.txtNewObject.Size = new System.Drawing.Size(477, 387);
            this.txtNewObject.Styles.BraceBad.Size = 9F;
            this.txtNewObject.Styles.BraceLight.Size = 9F;
            this.txtNewObject.Styles.ControlChar.Size = 9F;
            this.txtNewObject.Styles.Default.BackColor = System.Drawing.SystemColors.Window;
            this.txtNewObject.Styles.Default.Size = 9F;
            this.txtNewObject.Styles.IndentGuide.Size = 9F;
            this.txtNewObject.Styles.LastPredefined.Size = 9F;
            this.txtNewObject.Styles.LineNumber.Size = 9F;
            this.txtNewObject.Styles.Max.Size = 9F;
            this.txtNewObject.TabIndex = 0;
            //
            // tabPage5
            //
            this.tabPage5.Controls.Add(this.txtOldObject);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(483, 393);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Old object";
            this.tabPage5.UseVisualStyleBackColor = true;
            //
            // txtOldObject
            //
            this.txtOldObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOldObject.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldObject.Location = new System.Drawing.Point(3, 3);
            this.txtOldObject.Name = "txtOldObject";
            this.txtOldObject.Size = new System.Drawing.Size(477, 387);
            this.txtOldObject.Styles.BraceBad.Size = 9F;
            this.txtOldObject.Styles.BraceLight.Size = 9F;
            this.txtOldObject.Styles.ControlChar.Size = 9F;
            this.txtOldObject.Styles.Default.BackColor = System.Drawing.SystemColors.Window;
            this.txtOldObject.Styles.Default.Size = 9F;
            this.txtOldObject.Styles.IndentGuide.Size = 9F;
            this.txtOldObject.Styles.LastPredefined.Size = 9F;
            this.txtOldObject.Styles.LineNumber.Size = 9F;
            this.txtOldObject.Styles.Max.Size = 9F;
            this.txtOldObject.TabIndex = 0;
            //
            // tabPage6
            //
            this.tabPage6.Controls.Add(this.txtDiff);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(483, 393);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Diff";
            this.tabPage6.UseVisualStyleBackColor = true;
            //
            // txtDiff
            //
            this.txtDiff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiff.Location = new System.Drawing.Point(0, 0);
            this.txtDiff.Name = "txtDiff";
            this.txtDiff.Size = new System.Drawing.Size(483, 393);
            this.txtDiff.TabIndex = 0;
            //
            // groupBox2
            //
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Location = new System.Drawing.Point(350, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 40);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Drop object";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alter existing object";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Create new object";
            //
            // panel5
            //
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(310, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(32, 20);
            this.panel5.TabIndex = 2;
            //
            // panel4
            //
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(160, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(32, 20);
            this.panel4.TabIndex = 1;
            //
            // panel3
            //
            this.panel3.BackColor = System.Drawing.Color.Lime;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(10, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(32, 20);
            this.panel3.TabIndex = 0;
            //
            // groupBox1
            //
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.schemaTreeView1);
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 462);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            //
            // schemaTreeView1
            //
            this.schemaTreeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.schemaTreeView1.DatabaseDestination = null;
            this.schemaTreeView1.DatabaseSource = null;
            this.schemaTreeView1.Location = new System.Drawing.Point(7, 10);
            this.schemaTreeView1.Name = "schemaTreeView1";
            this.schemaTreeView1.ShowChangedItems = true;
            this.schemaTreeView1.ShowMissingItems = true;
            this.schemaTreeView1.ShowNewItems = true;
            this.schemaTreeView1.ShowUnchangedItems = true;
            this.schemaTreeView1.Size = new System.Drawing.Size(322, 446);
            this.schemaTreeView1.TabIndex = 0;
            //
            // tabPage1
            //
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.lblMessage);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(847, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Synchronized script";
            this.tabPage1.UseVisualStyleBackColor = true;
            //
            // panel1
            //
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtSyncScript);
            this.panel1.Location = new System.Drawing.Point(9, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 453);
            this.panel1.TabIndex = 6;
            //
            // txtSyncScript
            //
            this.txtSyncScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSyncScript.IsReadOnly = true;
            this.txtSyncScript.Location = new System.Drawing.Point(0, 0);
            this.txtSyncScript.Name = "txtSyncScript";
            this.txtSyncScript.Size = new System.Drawing.Size(802, 449);
            this.txtSyncScript.Styles.LineNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtSyncScript.Styles.LineNumber.IsVisible = false;
            this.txtSyncScript.TabIndex = 0;
            //
            // tabPage3
            //
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(847, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Action report";
            this.tabPage3.UseVisualStyleBackColor = true;
            //
            // textBox1
            //
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(9, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(806, 453);
            this.textBox1.TabIndex = 0;
            //
            // saveFileDialog1
            //
            this.saveFileDialog1.DefaultExt = "sql";
            this.saveFileDialog1.Filter = "SQL File|*.sql";
            //
            // btnOptions
            //
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.Image = global::DBDiff.Properties.Resources.setting_tools;
            this.btnOptions.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOptions.Location = new System.Drawing.Point(868, 308);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(95, 55);
            this.btnOptions.TabIndex = 5;
            this.btnOptions.Text = "Options";
            this.btnOptions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            //
            // btnCopy
            //
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Enabled = false;
            this.btnCopy.Image = global::DBDiff.Properties.Resources.clipboard_invoice;
            this.btnCopy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCopy.Location = new System.Drawing.Point(868, 430);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(95, 55);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "Copy script";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            //
            // btnUpdate
            //
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Image = global::DBDiff.Properties.Resources.refresh_all;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.Location = new System.Drawing.Point(868, 491);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 55);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update selected";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            //
            // btnUpdateAll
            //
            this.btnUpdateAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateAll.Enabled = false;
            this.btnUpdateAll.Image = global::DBDiff.Properties.Resources.database_refresh;
            this.btnUpdateAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdateAll.Location = new System.Drawing.Point(868, 670);
            this.btnUpdateAll.Name = "btnUpdateAll";
            this.btnUpdateAll.Size = new System.Drawing.Size(95, 55);
            this.btnUpdateAll.TabIndex = 10;
            this.btnUpdateAll.Text = "Update all";
            this.btnUpdateAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdateAll.UseVisualStyleBackColor = true;
            this.btnUpdateAll.Click += new System.EventHandler(this.btnUpdateAll_Click);
            //
            // btnSaveAs
            //
            this.btnSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAs.Enabled = false;
            this.btnSaveAs.Image = global::DBDiff.Properties.Resources.save_as;
            this.btnSaveAs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveAs.Location = new System.Drawing.Point(868, 369);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(95, 55);
            this.btnSaveAs.TabIndex = 6;
            this.btnSaveAs.Text = "Save as";
            this.btnSaveAs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            //
            // btnCompare
            //
            this.btnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompare.Image = global::DBDiff.Properties.Resources.compare;
            this.btnCompare.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompare.Location = new System.Drawing.Point(868, 247);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(95, 55);
            this.btnCompare.TabIndex = 4;
            this.btnCompare.Text = "Compare";
            this.btnCompare.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.button1_Click);
            //
            // btnCompareTableData
            //
            this.btnCompareTableData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompareTableData.Enabled = false;
            this.btnCompareTableData.Image = global::DBDiff.Properties.Resources.table_analysis;
            this.btnCompareTableData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompareTableData.Location = new System.Drawing.Point(868, 552);
            this.btnCompareTableData.Name = "btnCompareTableData";
            this.btnCompareTableData.Size = new System.Drawing.Size(95, 55);
            this.btnCompareTableData.TabIndex = 9;
            this.btnCompareTableData.Text = "Compare data";
            this.btnCompareTableData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompareTableData.UseVisualStyleBackColor = true;
            this.btnCompareTableData.Click += new System.EventHandler(this.btnCompareTableData_Click);
            //
            // MainMenuStrip
            //
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(975, 24);
            this.MainMenuStrip.TabIndex = 11;
            this.MainMenuStrip.Text = "menuStrip1";
            //
            // projectToolStripMenuItem
            //
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.openProjectToolStripMenuItem,
            this.saveProjectToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "&Project";
            //
            // newProjectToolStripMenuItem
            //
            this.newProjectToolStripMenuItem.Image = global::DBDiff.Properties.Resources.new_window;
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.newProjectToolStripMenuItem.Text = "&New project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            //
            // openProjectToolStripMenuItem
            //
            this.openProjectToolStripMenuItem.Image = global::DBDiff.Properties.Resources.folder;
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.openProjectToolStripMenuItem.Text = "&Open project";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            //
            // saveProjectToolStripMenuItem
            //
            this.saveProjectToolStripMenuItem.Image = global::DBDiff.Properties.Resources.diskette;
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.saveProjectToolStripMenuItem.Text = "&Save project";
            this.saveProjectToolStripMenuItem.Click += new System.EventHandler(this.saveProjectToolStripMenuItem_Click);
            //
            // toolStripSeparator1
            //
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            //
            // exitToolStripMenuItem
            //
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            //
            // panel2
            //
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 180);
            this.panel2.TabIndex = 12;
            //
            // tableLayoutPanel1
            //
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.SourceGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DestinationGroupBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.SwapConnectionsButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(975, 180);
            this.tableLayoutPanel1.TabIndex = 13;
            //
            // SourceGroupBox
            //
            this.SourceGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SourceGroupBox.Name = "SourceGroupBox";
            this.SourceGroupBox.Size = new System.Drawing.Size(446, 174);
            this.SourceGroupBox.TabIndex = 15;
            this.SourceGroupBox.TabStop = false;
            //
            // DestinationGroupBox
            //
            this.DestinationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DestinationGroupBox.Location = new System.Drawing.Point(525, 3);
            this.DestinationGroupBox.Name = "DestinationGroupBox";
            this.DestinationGroupBox.Size = new System.Drawing.Size(447, 174);
            this.DestinationGroupBox.TabIndex = 16;
            this.DestinationGroupBox.TabStop = false;
            //
            // SwapConnectionsButton
            //
            this.SwapConnectionsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SwapConnectionsButton.Image = global::DBDiff.Properties.Resources.arrow_switch;
            this.SwapConnectionsButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SwapConnectionsButton.Location = new System.Drawing.Point(459, 62);
            this.SwapConnectionsButton.Name = "SwapConnectionsButton";
            this.SwapConnectionsButton.Size = new System.Drawing.Size(55, 55);
            this.SwapConnectionsButton.TabIndex = 14;
            this.SwapConnectionsButton.Text = "Swap";
            this.SwapConnectionsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SwapConnectionsButton.UseVisualStyleBackColor = true;
            this.SwapConnectionsButton.Click += new System.EventHandler(this.SwapConnectionsButton_Click);
            //
            // GroupDb
            //
            this.GroupDb.Controls.Add(this.optSybase);
            this.GroupDb.Controls.Add(this.optMySQL);
            this.GroupDb.Controls.Add(this.optSQL2005);
            this.GroupDb.Location = new System.Drawing.Point(551, 207);
            this.GroupDb.Name = "GroupDb";
            this.GroupDb.Size = new System.Drawing.Size(421, 36);
            this.GroupDb.TabIndex = 13;
            this.GroupDb.TabStop = false;
            this.GroupDb.Text = "(not implemented)";
            this.GroupDb.Visible = false;
            //
            // optSybase
            //
            this.optSybase.AutoSize = true;
            this.optSybase.Location = new System.Drawing.Point(291, 15);
            this.optSybase.Name = "optSybase";
            this.optSybase.Size = new System.Drawing.Size(84, 17);
            this.optSybase.TabIndex = 3;
            this.optSybase.Text = "Sybase 12.5";
            this.optSybase.UseVisualStyleBackColor = true;
            this.optSybase.Visible = false;
            //
            // optMySQL
            //
            this.optMySQL.AutoSize = true;
            this.optMySQL.Location = new System.Drawing.Point(163, 15);
            this.optMySQL.Name = "optMySQL";
            this.optMySQL.Size = new System.Drawing.Size(122, 17);
            this.optMySQL.TabIndex = 2;
            this.optMySQL.Text = "MySQL 5.0 or higher";
            this.optMySQL.UseVisualStyleBackColor = true;
            this.optMySQL.Visible = false;
            //
            // optSQL2005
            //
            this.optSQL2005.AutoSize = true;
            this.optSQL2005.Checked = true;
            this.optSQL2005.Location = new System.Drawing.Point(6, 12);
            this.optSQL2005.Name = "optSQL2005";
            this.optSQL2005.Size = new System.Drawing.Size(107, 17);
            this.optSQL2005.TabIndex = 1;
            this.optSQL2005.TabStop = true;
            this.optSQL2005.Text = "SQL Server 2005";
            this.optSQL2005.UseVisualStyleBackColor = true;
            //
            // Form1
            //
            this.AcceptButton = this.btnCompare;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 729);
            this.Controls.Add(this.GroupDb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCompareTableData);
            this.Controls.Add(this.btnUpdateAll);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Open DBDiff Beta ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNewObject)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtOldObject)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDiff)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSyncScript)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GroupDb.ResumeLayout(false);
            this.GroupDb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMessage;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnCompare;
        private Button btnSaveAs;
        private SaveFileDialog saveFileDialog1;
        private Button btnCopy;
        private Button btnUpdate;
        private Button btnUpdateAll;
        private Button btnOptions;
        private TabPage tabPage2;
        private SchemaTreeView schemaTreeView1;
        private GroupBox groupBox1;
        private TabPage tabPage3;
        private TextBox textBox1;
        private Panel panel1;
        private Scintilla txtSyncScript;
        private GroupBox groupBox2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private Label label3;
        private Label label2;
        private TabControl tabControl2;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Scintilla txtNewObject;
        private Scintilla txtOldObject;
        private Button btnCompareTableData;
        private TabPage tabPage6;
        private Scintilla txtDiff;
        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem projectToolStripMenuItem;
        private ToolStripMenuItem openProjectToolStripMenuItem;
        private ToolStripMenuItem newProjectToolStripMenuItem;
        private ToolStripMenuItem saveProjectToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button SwapConnectionsButton;
        private GroupBox SourceGroupBox;
        private GroupBox DestinationGroupBox;
        private GroupBox GroupDb;
        private RadioButton optSybase;
        private RadioButton optMySQL;
        private RadioButton optSQL2005;
    }
}
