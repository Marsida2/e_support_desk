namespace e_support_desk
{
    partial class Ceshtje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ceshtje));
            System.Windows.Forms.Label id_ceshtjeLabel;
            System.Windows.Forms.Label id_klientiLabel;
            System.Windows.Forms.Label id_pergjegjesiLabel;
            System.Windows.Forms.Label id_sherbimiLabel;
            System.Windows.Forms.Label prioritetiLabel;
            System.Windows.Forms.Label statusiLabel;
            System.Windows.Forms.Label garanciLabel;
            System.Windows.Forms.Label raportiLabel;
            System.Windows.Forms.Label problemiLabel;
            System.Windows.Forms.Label afati_kohor1Label;
            this.e_supportDataSet = new e_support_desk.e_supportDataSet();
            this.ceshtjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ceshtjaTableAdapter = new e_support_desk.e_supportDataSetTableAdapters.ceshtjaTableAdapter();
            this.tableAdapterManager = new e_support_desk.e_supportDataSetTableAdapters.TableAdapterManager();
            this.ceshtjaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.ceshtjaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_ceshtjeTextBox = new System.Windows.Forms.TextBox();
            this.id_klientiTextBox = new System.Windows.Forms.TextBox();
            this.id_pergjegjesiTextBox = new System.Windows.Forms.TextBox();
            this.id_sherbimiTextBox = new System.Windows.Forms.TextBox();
            this.prioritetiTextBox = new System.Windows.Forms.TextBox();
            this.statusiTextBox = new System.Windows.Forms.TextBox();
            this.garanciTextBox = new System.Windows.Forms.TextBox();
            this.raportiTextBox = new System.Windows.Forms.TextBox();
            this.problemiTextBox = new System.Windows.Forms.TextBox();
            this.afati_kohor1DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            id_ceshtjeLabel = new System.Windows.Forms.Label();
            id_klientiLabel = new System.Windows.Forms.Label();
            id_pergjegjesiLabel = new System.Windows.Forms.Label();
            id_sherbimiLabel = new System.Windows.Forms.Label();
            prioritetiLabel = new System.Windows.Forms.Label();
            statusiLabel = new System.Windows.Forms.Label();
            garanciLabel = new System.Windows.Forms.Label();
            raportiLabel = new System.Windows.Forms.Label();
            problemiLabel = new System.Windows.Forms.Label();
            afati_kohor1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.e_supportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceshtjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceshtjaBindingNavigator)).BeginInit();
            this.ceshtjaBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // e_supportDataSet
            // 
            this.e_supportDataSet.DataSetName = "e_supportDataSet";
            this.e_supportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ceshtjaBindingSource
            // 
            this.ceshtjaBindingSource.DataMember = "ceshtja";
            this.ceshtjaBindingSource.DataSource = this.e_supportDataSet;
            // 
            // ceshtjaTableAdapter
            // 
            this.ceshtjaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ceshtjaTableAdapter = this.ceshtjaTableAdapter;
            this.tableAdapterManager.dokumentimTableAdapter = null;
            this.tableAdapterManager.fatureTableAdapter = null;
            this.tableAdapterManager.klientiTableAdapter = null;
            this.tableAdapterManager.krk_delegimTableAdapter = null;
            this.tableAdapterManager.krk_sh_afatiTableAdapter = null;
            this.tableAdapterManager.pajisjaTableAdapter = null;
            this.tableAdapterManager.prioritetiTableAdapter = null;
            this.tableAdapterManager.punonjesiTableAdapter = null;
            this.tableAdapterManager.roliTableAdapter = null;
            this.tableAdapterManager.sherbimiTableAdapter = null;
            this.tableAdapterManager.shitjeTableAdapter = null;
            this.tableAdapterManager.statusiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = e_support_desk.e_supportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ceshtjaBindingNavigator
            // 
            this.ceshtjaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ceshtjaBindingNavigator.BindingSource = this.ceshtjaBindingSource;
            this.ceshtjaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ceshtjaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ceshtjaBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ceshtjaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ceshtjaBindingNavigatorSaveItem});
            this.ceshtjaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ceshtjaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ceshtjaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ceshtjaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ceshtjaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ceshtjaBindingNavigator.Name = "ceshtjaBindingNavigator";
            this.ceshtjaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ceshtjaBindingNavigator.Size = new System.Drawing.Size(1254, 33);
            this.ceshtjaBindingNavigator.TabIndex = 0;
            this.ceshtjaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // ceshtjaBindingNavigatorSaveItem
            // 
            this.ceshtjaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ceshtjaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ceshtjaBindingNavigatorSaveItem.Image")));
            this.ceshtjaBindingNavigatorSaveItem.Name = "ceshtjaBindingNavigatorSaveItem";
            this.ceshtjaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.ceshtjaBindingNavigatorSaveItem.Text = "Save Data";
            this.ceshtjaBindingNavigatorSaveItem.Click += new System.EventHandler(this.ceshtjaBindingNavigatorSaveItem_Click_1);
            // 
            // id_ceshtjeLabel
            // 
            id_ceshtjeLabel.AutoSize = true;
            id_ceshtjeLabel.Location = new System.Drawing.Point(64, 77);
            id_ceshtjeLabel.Name = "id_ceshtjeLabel";
            id_ceshtjeLabel.Size = new System.Drawing.Size(80, 20);
            id_ceshtjeLabel.TabIndex = 1;
            id_ceshtjeLabel.Text = "id ceshtje:";
            // 
            // id_ceshtjeTextBox
            // 
            this.id_ceshtjeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ceshtjaBindingSource, "id_ceshtje", true));
            this.id_ceshtjeTextBox.Location = new System.Drawing.Point(175, 74);
            this.id_ceshtjeTextBox.Name = "id_ceshtjeTextBox";
            this.id_ceshtjeTextBox.Size = new System.Drawing.Size(385, 26);
            this.id_ceshtjeTextBox.TabIndex = 2;
            // 
            // id_klientiLabel
            // 
            id_klientiLabel.AutoSize = true;
            id_klientiLabel.Location = new System.Drawing.Point(64, 109);
            id_klientiLabel.Name = "id_klientiLabel";
            id_klientiLabel.Size = new System.Drawing.Size(69, 20);
            id_klientiLabel.TabIndex = 3;
            id_klientiLabel.Text = "id klienti:";
            // 
            // id_klientiTextBox
            // 
            this.id_klientiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ceshtjaBindingSource, "id_klienti", true));
            this.id_klientiTextBox.Location = new System.Drawing.Point(175, 106);
            this.id_klientiTextBox.Name = "id_klientiTextBox";
            this.id_klientiTextBox.Size = new System.Drawing.Size(385, 26);
            this.id_klientiTextBox.TabIndex = 4;
            // 
            // id_pergjegjesiLabel
            // 
            id_pergjegjesiLabel.AutoSize = true;
            id_pergjegjesiLabel.Location = new System.Drawing.Point(64, 141);
            id_pergjegjesiLabel.Name = "id_pergjegjesiLabel";
            id_pergjegjesiLabel.Size = new System.Drawing.Size(105, 20);
            id_pergjegjesiLabel.TabIndex = 5;
            id_pergjegjesiLabel.Text = "id pergjegjesi:";
            // 
            // id_pergjegjesiTextBox
            // 
            this.id_pergjegjesiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ceshtjaBindingSource, "id_pergjegjesi", true));
            this.id_pergjegjesiTextBox.Location = new System.Drawing.Point(175, 138);
            this.id_pergjegjesiTextBox.Name = "id_pergjegjesiTextBox";
            this.id_pergjegjesiTextBox.Size = new System.Drawing.Size(385, 26);
            this.id_pergjegjesiTextBox.TabIndex = 6;
            // 
            // id_sherbimiLabel
            // 
            id_sherbimiLabel.AutoSize = true;
            id_sherbimiLabel.Location = new System.Drawing.Point(64, 173);
            id_sherbimiLabel.Name = "id_sherbimiLabel";
            id_sherbimiLabel.Size = new System.Drawing.Size(88, 20);
            id_sherbimiLabel.TabIndex = 7;
            id_sherbimiLabel.Text = "id sherbimi:";
            // 
            // id_sherbimiTextBox
            // 
            this.id_sherbimiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ceshtjaBindingSource, "id_sherbimi", true));
            this.id_sherbimiTextBox.Location = new System.Drawing.Point(175, 170);
            this.id_sherbimiTextBox.Name = "id_sherbimiTextBox";
            this.id_sherbimiTextBox.Size = new System.Drawing.Size(385, 26);
            this.id_sherbimiTextBox.TabIndex = 8;
            // 
            // prioritetiLabel
            // 
            prioritetiLabel.AutoSize = true;
            prioritetiLabel.Location = new System.Drawing.Point(64, 205);
            prioritetiLabel.Name = "prioritetiLabel";
            prioritetiLabel.Size = new System.Drawing.Size(69, 20);
            prioritetiLabel.TabIndex = 9;
            prioritetiLabel.Text = "prioriteti:";
            // 
            // prioritetiTextBox
            // 
            this.prioritetiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ceshtjaBindingSource, "prioriteti", true));
            this.prioritetiTextBox.Location = new System.Drawing.Point(175, 202);
            this.prioritetiTextBox.Name = "prioritetiTextBox";
            this.prioritetiTextBox.Size = new System.Drawing.Size(385, 26);
            this.prioritetiTextBox.TabIndex = 10;
            // 
            // statusiLabel
            // 
            statusiLabel.AutoSize = true;
            statusiLabel.Location = new System.Drawing.Point(64, 237);
            statusiLabel.Name = "statusiLabel";
            statusiLabel.Size = new System.Drawing.Size(60, 20);
            statusiLabel.TabIndex = 11;
            statusiLabel.Text = "statusi:";
            // 
            // statusiTextBox
            // 
            this.statusiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ceshtjaBindingSource, "statusi", true));
            this.statusiTextBox.Location = new System.Drawing.Point(175, 234);
            this.statusiTextBox.Name = "statusiTextBox";
            this.statusiTextBox.Size = new System.Drawing.Size(385, 26);
            this.statusiTextBox.TabIndex = 12;
            // 
            // garanciLabel
            // 
            garanciLabel.AutoSize = true;
            garanciLabel.Location = new System.Drawing.Point(64, 269);
            garanciLabel.Name = "garanciLabel";
            garanciLabel.Size = new System.Drawing.Size(65, 20);
            garanciLabel.TabIndex = 13;
            garanciLabel.Text = "garanci:";
            // 
            // garanciTextBox
            // 
            this.garanciTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ceshtjaBindingSource, "garanci", true));
            this.garanciTextBox.Location = new System.Drawing.Point(175, 266);
            this.garanciTextBox.Name = "garanciTextBox";
            this.garanciTextBox.Size = new System.Drawing.Size(385, 26);
            this.garanciTextBox.TabIndex = 14;
            // 
            // raportiLabel
            // 
            raportiLabel.AutoSize = true;
            raportiLabel.Location = new System.Drawing.Point(64, 301);
            raportiLabel.Name = "raportiLabel";
            raportiLabel.Size = new System.Drawing.Size(58, 20);
            raportiLabel.TabIndex = 15;
            raportiLabel.Text = "raporti:";
            // 
            // raportiTextBox
            // 
            this.raportiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ceshtjaBindingSource, "raporti", true));
            this.raportiTextBox.Location = new System.Drawing.Point(175, 298);
            this.raportiTextBox.Name = "raportiTextBox";
            this.raportiTextBox.Size = new System.Drawing.Size(385, 26);
            this.raportiTextBox.TabIndex = 16;
            // 
            // problemiLabel
            // 
            problemiLabel.AutoSize = true;
            problemiLabel.Location = new System.Drawing.Point(64, 333);
            problemiLabel.Name = "problemiLabel";
            problemiLabel.Size = new System.Drawing.Size(73, 20);
            problemiLabel.TabIndex = 17;
            problemiLabel.Text = "problemi:";
            // 
            // problemiTextBox
            // 
            this.problemiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ceshtjaBindingSource, "problemi", true));
            this.problemiTextBox.Location = new System.Drawing.Point(175, 330);
            this.problemiTextBox.Name = "problemiTextBox";
            this.problemiTextBox.Size = new System.Drawing.Size(385, 26);
            this.problemiTextBox.TabIndex = 18;
            // 
            // afati_kohor1Label
            // 
            afati_kohor1Label.AutoSize = true;
            afati_kohor1Label.Location = new System.Drawing.Point(64, 366);
            afati_kohor1Label.Name = "afati_kohor1Label";
            afati_kohor1Label.Size = new System.Drawing.Size(88, 20);
            afati_kohor1Label.TabIndex = 19;
            afati_kohor1Label.Text = "afati kohor:";
            // 
            // afati_kohor1DateTimePicker
            // 
            this.afati_kohor1DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ceshtjaBindingSource, "afati_kohor1", true));
            this.afati_kohor1DateTimePicker.Location = new System.Drawing.Point(175, 362);
            this.afati_kohor1DateTimePicker.Name = "afati_kohor1DateTimePicker";
            this.afati_kohor1DateTimePicker.Size = new System.Drawing.Size(385, 26);
            this.afati_kohor1DateTimePicker.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prioritetiTextBox);
            this.groupBox1.Controls.Add(id_ceshtjeLabel);
            this.groupBox1.Controls.Add(this.afati_kohor1DateTimePicker);
            this.groupBox1.Controls.Add(this.id_ceshtjeTextBox);
            this.groupBox1.Controls.Add(afati_kohor1Label);
            this.groupBox1.Controls.Add(id_klientiLabel);
            this.groupBox1.Controls.Add(this.problemiTextBox);
            this.groupBox1.Controls.Add(this.id_klientiTextBox);
            this.groupBox1.Controls.Add(problemiLabel);
            this.groupBox1.Controls.Add(id_pergjegjesiLabel);
            this.groupBox1.Controls.Add(this.raportiTextBox);
            this.groupBox1.Controls.Add(this.id_pergjegjesiTextBox);
            this.groupBox1.Controls.Add(raportiLabel);
            this.groupBox1.Controls.Add(id_sherbimiLabel);
            this.groupBox1.Controls.Add(this.garanciTextBox);
            this.groupBox1.Controls.Add(this.id_sherbimiTextBox);
            this.groupBox1.Controls.Add(garanciLabel);
            this.groupBox1.Controls.Add(prioritetiLabel);
            this.groupBox1.Controls.Add(this.statusiTextBox);
            this.groupBox1.Controls.Add(statusiLabel);
            this.groupBox1.Location = new System.Drawing.Point(48, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 458);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ceshtje Ekzistente";
            // 
            // Ceshtje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 678);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ceshtjaBindingNavigator);
            this.Name = "Ceshtje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ceshtje";
            this.Load += new System.EventHandler(this.Ceshtje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.e_supportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceshtjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceshtjaBindingNavigator)).EndInit();
            this.ceshtjaBindingNavigator.ResumeLayout(false);
            this.ceshtjaBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private e_supportDataSet e_supportDataSet;
        private System.Windows.Forms.BindingSource ceshtjaBindingSource;
        private e_supportDataSetTableAdapters.ceshtjaTableAdapter ceshtjaTableAdapter;
        private e_supportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ceshtjaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ceshtjaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_ceshtjeTextBox;
        private System.Windows.Forms.TextBox id_klientiTextBox;
        private System.Windows.Forms.TextBox id_pergjegjesiTextBox;
        private System.Windows.Forms.TextBox id_sherbimiTextBox;
        private System.Windows.Forms.TextBox prioritetiTextBox;
        private System.Windows.Forms.TextBox statusiTextBox;
        private System.Windows.Forms.TextBox garanciTextBox;
        private System.Windows.Forms.TextBox raportiTextBox;
        private System.Windows.Forms.TextBox problemiTextBox;
        private System.Windows.Forms.DateTimePicker afati_kohor1DateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}