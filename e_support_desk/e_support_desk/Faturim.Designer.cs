
namespace e_support_desk
{
    partial class Faturim
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label id_bleresiLabel;
            this.cb_pajisja = new System.Windows.Forms.ComboBox();
            this.pajisjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e_supportDataSet = new e_support_desk.e_supportDataSet();
            this.chb_garanci = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.nr_sasia = new System.Windows.Forms.NumericUpDown();
            this.cb_sherbime = new System.Windows.Forms.ComboBox();
            this.sherbimiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rb_sherbim = new System.Windows.Forms.RadioButton();
            this.rb_pajisje = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_faturo = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_klienti = new System.Windows.Forms.ComboBox();
            this.btn_anullo = new System.Windows.Forms.Button();
            this.pajisjaTableAdapter = new e_support_desk.e_supportDataSetTableAdapters.pajisjaTableAdapter();
            this.sherbimiTableAdapter = new e_support_desk.e_supportDataSetTableAdapters.sherbimiTableAdapter();
            label2 = new System.Windows.Forms.Label();
            id_bleresiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pajisjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_supportDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nr_sasia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sherbimiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(144, 97);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(62, 25);
            label2.TabIndex = 21;
            label2.Text = "Sasia";
            // 
            // id_bleresiLabel
            // 
            id_bleresiLabel.AutoSize = true;
            id_bleresiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_bleresiLabel.Location = new System.Drawing.Point(77, 92);
            id_bleresiLabel.Name = "id_bleresiLabel";
            id_bleresiLabel.Size = new System.Drawing.Size(65, 25);
            id_bleresiLabel.TabIndex = 1;
            id_bleresiLabel.Text = "Klienti";
            // 
            // cb_pajisja
            // 
            this.cb_pajisja.DataSource = this.pajisjaBindingSource;
            this.cb_pajisja.DisplayMember = "emertimi";
            this.cb_pajisja.Enabled = false;
            this.cb_pajisja.FormattingEnabled = true;
            this.cb_pajisja.Location = new System.Drawing.Point(149, 42);
            this.cb_pajisja.Name = "cb_pajisja";
            this.cb_pajisja.Size = new System.Drawing.Size(318, 33);
            this.cb_pajisja.TabIndex = 12;
            this.cb_pajisja.ValueMember = "kod_pajisje";
            // 
            // pajisjaBindingSource
            // 
            this.pajisjaBindingSource.DataMember = "pajisja";
            this.pajisjaBindingSource.DataSource = this.e_supportDataSet;
            // 
            // e_supportDataSet
            // 
            this.e_supportDataSet.DataSetName = "e_supportDataSet";
            this.e_supportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chb_garanci
            // 
            this.chb_garanci.AutoSize = true;
            this.chb_garanci.Enabled = false;
            this.chb_garanci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_garanci.Location = new System.Drawing.Point(361, 97);
            this.chb_garanci.Name = "chb_garanci";
            this.chb_garanci.Size = new System.Drawing.Size(106, 29);
            this.chb_garanci.TabIndex = 13;
            this.chb_garanci.Text = "Garanci";
            this.chb_garanci.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.nr_sasia);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.cb_sherbime);
            this.groupBox1.Controls.Add(this.chb_garanci);
            this.groupBox1.Controls.Add(this.rb_sherbim);
            this.groupBox1.Controls.Add(this.rb_pajisje);
            this.groupBox1.Controls.Add(this.cb_pajisja);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(73, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 355);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zgjidhni llojin e produktit";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(149, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 59);
            this.button3.TabIndex = 21;
            this.button3.Text = "Shto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // nr_sasia
            // 
            this.nr_sasia.Enabled = false;
            this.nr_sasia.Location = new System.Drawing.Point(222, 97);
            this.nr_sasia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nr_sasia.Name = "nr_sasia";
            this.nr_sasia.Size = new System.Drawing.Size(103, 30);
            this.nr_sasia.TabIndex = 22;
            this.nr_sasia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cb_sherbime
            // 
            this.cb_sherbime.DataSource = this.sherbimiBindingSource;
            this.cb_sherbime.DisplayMember = "lloji";
            this.cb_sherbime.Enabled = false;
            this.cb_sherbime.FormattingEnabled = true;
            this.cb_sherbime.Location = new System.Drawing.Point(149, 193);
            this.cb_sherbime.Name = "cb_sherbime";
            this.cb_sherbime.Size = new System.Drawing.Size(318, 33);
            this.cb_sherbime.TabIndex = 15;
            this.cb_sherbime.ValueMember = "id_sherbimi";
            // 
            // sherbimiBindingSource
            // 
            this.sherbimiBindingSource.DataMember = "sherbimi";
            this.sherbimiBindingSource.DataSource = this.e_supportDataSet;
            // 
            // rb_sherbim
            // 
            this.rb_sherbim.AutoSize = true;
            this.rb_sherbim.Location = new System.Drawing.Point(22, 158);
            this.rb_sherbim.Name = "rb_sherbim";
            this.rb_sherbim.Size = new System.Drawing.Size(110, 29);
            this.rb_sherbim.TabIndex = 14;
            this.rb_sherbim.TabStop = true;
            this.rb_sherbim.Text = "Sherbim";
            this.rb_sherbim.UseVisualStyleBackColor = true;
            this.rb_sherbim.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb_pajisje
            // 
            this.rb_pajisje.AutoSize = true;
            this.rb_pajisje.Location = new System.Drawing.Point(22, 46);
            this.rb_pajisje.Name = "rb_pajisje";
            this.rb_pajisje.Size = new System.Drawing.Size(94, 29);
            this.rb_pajisje.TabIndex = 13;
            this.rb_pajisje.TabStop = true;
            this.rb_pajisje.Text = "Pajisje";
            this.rb_pajisje.UseVisualStyleBackColor = true;
            this.rb_pajisje.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(65, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 45);
            this.label1.TabIndex = 15;
            this.label1.Text = "Faturim klienti";
            // 
            // btn_faturo
            // 
            this.btn_faturo.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_faturo.Location = new System.Drawing.Point(73, 593);
            this.btn_faturo.Name = "btn_faturo";
            this.btn_faturo.Size = new System.Drawing.Size(255, 64);
            this.btn_faturo.TabIndex = 17;
            this.btn_faturo.Text = "Faturo";
            this.btn_faturo.UseVisualStyleBackColor = true;
            this.btn_faturo.Click += new System.EventHandler(this.btn_faturo_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(632, 88);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(531, 507);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "*********************************************************************************" +
    "*****\n***************************************Fature*****************************" +
    "**********\n";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(632, 614);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 43);
            this.button1.TabIndex = 19;
            this.button1.Text = "Printo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(925, 614);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 43);
            this.button2.TabIndex = 20;
            this.button2.Text = "Kthehu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_klienti
            // 
            this.cb_klienti.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_klienti.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_klienti.DisplayMember = "id_klienti";
            this.cb_klienti.FormattingEnabled = true;
            this.cb_klienti.Location = new System.Drawing.Point(183, 89);
            this.cb_klienti.Name = "cb_klienti";
            this.cb_klienti.Size = new System.Drawing.Size(370, 28);
            this.cb_klienti.TabIndex = 10;
            this.cb_klienti.ValueMember = "id_klienti";
            this.cb_klienti.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_anullo
            // 
            this.btn_anullo.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anullo.Location = new System.Drawing.Point(327, 593);
            this.btn_anullo.Name = "btn_anullo";
            this.btn_anullo.Size = new System.Drawing.Size(236, 64);
            this.btn_anullo.TabIndex = 21;
            this.btn_anullo.Text = "Anullo";
            this.btn_anullo.UseVisualStyleBackColor = true;
            this.btn_anullo.Click += new System.EventHandler(this.btn_anullo_Click);
            // 
            // pajisjaTableAdapter
            // 
            this.pajisjaTableAdapter.ClearBeforeFill = true;
            // 
            // sherbimiTableAdapter
            // 
            this.sherbimiTableAdapter.ClearBeforeFill = true;
            // 
            // Faturim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 678);
            this.Controls.Add(this.btn_anullo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_faturo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cb_klienti);
            this.Controls.Add(id_bleresiLabel);
            this.Name = "Faturim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Faturim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Faturim_FormClosing);
            this.Load += new System.EventHandler(this.Faturim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pajisjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_supportDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nr_sasia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sherbimiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_pajisja;
        private System.Windows.Forms.CheckBox chb_garanci;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_sherbime;
        private System.Windows.Forms.RadioButton rb_sherbim;
        private System.Windows.Forms.RadioButton rb_pajisje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown nr_sasia;
        private System.Windows.Forms.Button btn_faturo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_klienti;
        private System.Windows.Forms.Button btn_anullo;
        private e_supportDataSet e_supportDataSet;
        private System.Windows.Forms.BindingSource pajisjaBindingSource;
        private e_supportDataSetTableAdapters.pajisjaTableAdapter pajisjaTableAdapter;
        private System.Windows.Forms.BindingSource sherbimiBindingSource;
        private e_supportDataSetTableAdapters.sherbimiTableAdapter sherbimiTableAdapter;
    }
}