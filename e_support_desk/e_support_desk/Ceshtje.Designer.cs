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
            this.gb_afatshtyrje = new System.Windows.Forms.GroupBox();
            this.btn_shtyj = new System.Windows.Forms.Button();
            this.dt_kerkese = new System.Windows.Forms.DateTimePicker();
            this.gb_delegim = new System.Windows.Forms.GroupBox();
            this.btn_delego = new System.Windows.Forms.Button();
            this.cb_pergjegjesit = new System.Windows.Forms.ComboBox();
            this.punonjesinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.esupportDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e_supportDataSet = new e_support_desk.e_supportDataSet();
            this.punonjesiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_kthehu = new System.Windows.Forms.Button();
            this.cb_statusi = new System.Windows.Forms.ComboBox();
            this.statusiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txt_problemi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_faturo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_gjitha = new System.Windows.Forms.RadioButton();
            this.rb_zgjidhur = new System.Windows.Forms.RadioButton();
            this.rb_mbyllur = new System.Windows.Forms.RadioButton();
            this.rb_vonese = new System.Windows.Forms.RadioButton();
            this.rb_aktive = new System.Windows.Forms.RadioButton();
            this.btn_raport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_prioriteti = new System.Windows.Forms.ComboBox();
            this.prioritetiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grid_analize_ceshtjesh = new System.Windows.Forms.DataGridView();
            this.statusiTableAdapter = new e_support_desk.e_supportDataSetTableAdapters.statusiTableAdapter();
            this.prioritetiTableAdapter = new e_support_desk.e_supportDataSetTableAdapters.prioritetiTableAdapter();
            this.btn_update = new System.Windows.Forms.Button();
            this.punonjesiTableAdapter = new e_support_desk.e_supportDataSetTableAdapters.punonjesiTableAdapter();
            this.punonjes_infoTableAdapter = new e_support_desk.e_supportDataSetTableAdapters.punonjes_infoTableAdapter();
            this.gb_afatshtyrje.SuspendLayout();
            this.gb_delegim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.punonjesinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esupportDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_supportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punonjesiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusiBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prioritetiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_analize_ceshtjesh)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_afatshtyrje
            // 
            this.gb_afatshtyrje.Controls.Add(this.btn_shtyj);
            this.gb_afatshtyrje.Controls.Add(this.dt_kerkese);
            this.gb_afatshtyrje.Location = new System.Drawing.Point(34, 580);
            this.gb_afatshtyrje.Name = "gb_afatshtyrje";
            this.gb_afatshtyrje.Size = new System.Drawing.Size(416, 135);
            this.gb_afatshtyrje.TabIndex = 1;
            this.gb_afatshtyrje.TabStop = false;
            this.gb_afatshtyrje.Text = "Kerkese afatshtyrje";
            // 
            // btn_shtyj
            // 
            this.btn_shtyj.Location = new System.Drawing.Point(24, 45);
            this.btn_shtyj.Name = "btn_shtyj";
            this.btn_shtyj.Size = new System.Drawing.Size(96, 50);
            this.btn_shtyj.TabIndex = 2;
            this.btn_shtyj.Text = "Shtyj";
            this.btn_shtyj.UseVisualStyleBackColor = true;
            this.btn_shtyj.Click += new System.EventHandler(this.btn_shtyj_Click);
            // 
            // dt_kerkese
            // 
            this.dt_kerkese.Location = new System.Drawing.Point(148, 55);
            this.dt_kerkese.Name = "dt_kerkese";
            this.dt_kerkese.Size = new System.Drawing.Size(233, 26);
            this.dt_kerkese.TabIndex = 0;
            // 
            // gb_delegim
            // 
            this.gb_delegim.Controls.Add(this.btn_delego);
            this.gb_delegim.Controls.Add(this.cb_pergjegjesit);
            this.gb_delegim.Location = new System.Drawing.Point(487, 580);
            this.gb_delegim.Name = "gb_delegim";
            this.gb_delegim.Size = new System.Drawing.Size(438, 135);
            this.gb_delegim.TabIndex = 2;
            this.gb_delegim.TabStop = false;
            this.gb_delegim.Text = "Kerkese delegimi";
            // 
            // btn_delego
            // 
            this.btn_delego.Location = new System.Drawing.Point(33, 45);
            this.btn_delego.Name = "btn_delego";
            this.btn_delego.Size = new System.Drawing.Size(95, 50);
            this.btn_delego.TabIndex = 29;
            this.btn_delego.Text = "Delego";
            this.btn_delego.UseVisualStyleBackColor = true;
            this.btn_delego.Click += new System.EventHandler(this.btn_delego_Click);
            // 
            // cb_pergjegjesit
            // 
            this.cb_pergjegjesit.DataSource = this.punonjesinfoBindingSource;
            this.cb_pergjegjesit.DisplayMember = "punonjesi";
            this.cb_pergjegjesit.FormattingEnabled = true;
            this.cb_pergjegjesit.Location = new System.Drawing.Point(159, 55);
            this.cb_pergjegjesit.Name = "cb_pergjegjesit";
            this.cb_pergjegjesit.Size = new System.Drawing.Size(244, 28);
            this.cb_pergjegjesit.TabIndex = 0;
            this.cb_pergjegjesit.ValueMember = "id_punonjesi";
            // 
            // punonjesinfoBindingSource
            // 
            this.punonjesinfoBindingSource.DataMember = "punonjes_info";
            this.punonjesinfoBindingSource.DataSource = this.esupportDataSetBindingSource;
            // 
            // esupportDataSetBindingSource
            // 
            this.esupportDataSetBindingSource.DataSource = this.e_supportDataSet;
            this.esupportDataSetBindingSource.Position = 0;
            // 
            // e_supportDataSet
            // 
            this.e_supportDataSet.DataSetName = "e_supportDataSet";
            this.e_supportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // punonjesiBindingSource
            // 
            this.punonjesiBindingSource.DataMember = "punonjesi";
            this.punonjesiBindingSource.DataSource = this.esupportDataSetBindingSource;
            // 
            // btn_kthehu
            // 
            this.btn_kthehu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kthehu.Location = new System.Drawing.Point(1128, 657);
            this.btn_kthehu.Name = "btn_kthehu";
            this.btn_kthehu.Size = new System.Drawing.Size(170, 50);
            this.btn_kthehu.TabIndex = 24;
            this.btn_kthehu.Text = "Kthehu";
            this.btn_kthehu.UseVisualStyleBackColor = true;
            this.btn_kthehu.Click += new System.EventHandler(this.btn_kthehu_Click);
            // 
            // cb_statusi
            // 
            this.cb_statusi.DataSource = this.statusiBindingSource;
            this.cb_statusi.DisplayMember = "pershkrimi";
            this.cb_statusi.FormattingEnabled = true;
            this.cb_statusi.Location = new System.Drawing.Point(1031, 217);
            this.cb_statusi.Name = "cb_statusi";
            this.cb_statusi.Size = new System.Drawing.Size(198, 28);
            this.cb_statusi.TabIndex = 26;
            this.cb_statusi.ValueMember = "vlera";
            // 
            // statusiBindingSource
            // 
            this.statusiBindingSource.DataMember = "statusi";
            this.statusiBindingSource.DataSource = this.e_supportDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(955, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Statusi";
            // 
            // txt_problemi
            // 
            this.txt_problemi.Location = new System.Drawing.Point(965, 327);
            this.txt_problemi.Multiline = true;
            this.txt_problemi.Name = "txt_problemi";
            this.txt_problemi.Size = new System.Drawing.Size(333, 230);
            this.txt_problemi.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(955, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Shenime mbi problemin";
            // 
            // btn_faturo
            // 
            this.btn_faturo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_faturo.Location = new System.Drawing.Point(959, 657);
            this.btn_faturo.Name = "btn_faturo";
            this.btn_faturo.Size = new System.Drawing.Size(163, 50);
            this.btn_faturo.TabIndex = 33;
            this.btn_faturo.Text = "Faturo";
            this.btn_faturo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_gjitha);
            this.groupBox1.Controls.Add(this.rb_zgjidhur);
            this.groupBox1.Controls.Add(this.rb_mbyllur);
            this.groupBox1.Controls.Add(this.rb_vonese);
            this.groupBox1.Controls.Add(this.rb_aktive);
            this.groupBox1.Location = new System.Drawing.Point(939, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 146);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro ceshtjet";
            // 
            // rb_gjitha
            // 
            this.rb_gjitha.AutoSize = true;
            this.rb_gjitha.Checked = true;
            this.rb_gjitha.Location = new System.Drawing.Point(200, 88);
            this.rb_gjitha.Name = "rb_gjitha";
            this.rb_gjitha.Size = new System.Drawing.Size(90, 24);
            this.rb_gjitha.TabIndex = 4;
            this.rb_gjitha.TabStop = true;
            this.rb_gjitha.Text = "te gjitha";
            this.rb_gjitha.UseVisualStyleBackColor = true;
            this.rb_gjitha.CheckedChanged += new System.EventHandler(this.rb_gjitha_CheckedChanged);
            // 
            // rb_zgjidhur
            // 
            this.rb_zgjidhur.AutoSize = true;
            this.rb_zgjidhur.Location = new System.Drawing.Point(70, 112);
            this.rb_zgjidhur.Name = "rb_zgjidhur";
            this.rb_zgjidhur.Size = new System.Drawing.Size(90, 24);
            this.rb_zgjidhur.TabIndex = 3;
            this.rb_zgjidhur.Text = "faturuar";
            this.rb_zgjidhur.UseVisualStyleBackColor = true;
            this.rb_zgjidhur.CheckedChanged += new System.EventHandler(this.rb_zgjidhur_CheckedChanged);
            // 
            // rb_mbyllur
            // 
            this.rb_mbyllur.AutoSize = true;
            this.rb_mbyllur.Location = new System.Drawing.Point(70, 67);
            this.rb_mbyllur.Name = "rb_mbyllur";
            this.rb_mbyllur.Size = new System.Drawing.Size(83, 24);
            this.rb_mbyllur.TabIndex = 2;
            this.rb_mbyllur.Text = "mbyllur";
            this.rb_mbyllur.UseVisualStyleBackColor = true;
            this.rb_mbyllur.CheckedChanged += new System.EventHandler(this.rb_mbyllur_CheckedChanged);
            // 
            // rb_vonese
            // 
            this.rb_vonese.AutoSize = true;
            this.rb_vonese.Location = new System.Drawing.Point(200, 46);
            this.rb_vonese.Name = "rb_vonese";
            this.rb_vonese.Size = new System.Drawing.Size(111, 24);
            this.rb_vonese.TabIndex = 1;
            this.rb_vonese.Text = "me vonese";
            this.rb_vonese.UseVisualStyleBackColor = true;
            this.rb_vonese.CheckedChanged += new System.EventHandler(this.rb_vonese_CheckedChanged);
            // 
            // rb_aktive
            // 
            this.rb_aktive.AutoSize = true;
            this.rb_aktive.Location = new System.Drawing.Point(70, 28);
            this.rb_aktive.Name = "rb_aktive";
            this.rb_aktive.Size = new System.Drawing.Size(75, 24);
            this.rb_aktive.TabIndex = 0;
            this.rb_aktive.Text = "aktive";
            this.rb_aktive.UseVisualStyleBackColor = true;
            this.rb_aktive.CheckedChanged += new System.EventHandler(this.rb_aktive_CheckedChanged);
            // 
            // btn_raport
            // 
            this.btn_raport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_raport.Location = new System.Drawing.Point(959, 588);
            this.btn_raport.Name = "btn_raport";
            this.btn_raport.Size = new System.Drawing.Size(163, 50);
            this.btn_raport.TabIndex = 35;
            this.btn_raport.Text = "Raporti PDF ";
            this.btn_raport.UseVisualStyleBackColor = true;
            this.btn_raport.Click += new System.EventHandler(this.btn_raport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(955, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Prioriteti";
            // 
            // cb_prioriteti
            // 
            this.cb_prioriteti.DataSource = this.prioritetiBindingSource;
            this.cb_prioriteti.DisplayMember = "vlera";
            this.cb_prioriteti.FormattingEnabled = true;
            this.cb_prioriteti.Location = new System.Drawing.Point(1031, 253);
            this.cb_prioriteti.Name = "cb_prioriteti";
            this.cb_prioriteti.Size = new System.Drawing.Size(198, 28);
            this.cb_prioriteti.TabIndex = 36;
            this.cb_prioriteti.ValueMember = "vlera";
            // 
            // prioritetiBindingSource
            // 
            this.prioritetiBindingSource.DataMember = "prioriteti";
            this.prioritetiBindingSource.DataSource = this.esupportDataSetBindingSource;
            // 
            // grid_analize_ceshtjesh
            // 
            this.grid_analize_ceshtjesh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_analize_ceshtjesh.Location = new System.Drawing.Point(34, 55);
            this.grid_analize_ceshtjesh.Name = "grid_analize_ceshtjesh";
            this.grid_analize_ceshtjesh.ReadOnly = true;
            this.grid_analize_ceshtjesh.RowHeadersWidth = 62;
            this.grid_analize_ceshtjesh.RowTemplate.Height = 28;
            this.grid_analize_ceshtjesh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_analize_ceshtjesh.Size = new System.Drawing.Size(867, 502);
            this.grid_analize_ceshtjesh.TabIndex = 38;
            this.grid_analize_ceshtjesh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_analize_ceshtjesh_CellClick);
            // 
            // statusiTableAdapter
            // 
            this.statusiTableAdapter.ClearBeforeFill = true;
            // 
            // prioritetiTableAdapter
            // 
            this.prioritetiTableAdapter.ClearBeforeFill = true;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(1128, 588);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(170, 50);
            this.btn_update.TabIndex = 39;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // punonjesiTableAdapter
            // 
            this.punonjesiTableAdapter.ClearBeforeFill = true;
            // 
            // punonjes_infoTableAdapter
            // 
            this.punonjes_infoTableAdapter.ClearBeforeFill = true;
            // 
            // Ceshtje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 780);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.grid_analize_ceshtjesh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_prioriteti);
            this.Controls.Add(this.btn_raport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_faturo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_problemi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_statusi);
            this.Controls.Add(this.btn_kthehu);
            this.Controls.Add(this.gb_delegim);
            this.Controls.Add(this.gb_afatshtyrje);
            this.Name = "Ceshtje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Ceshtje_Load);
            this.gb_afatshtyrje.ResumeLayout(false);
            this.gb_delegim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.punonjesinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esupportDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_supportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punonjesiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusiBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prioritetiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_analize_ceshtjesh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_afatshtyrje;
        private System.Windows.Forms.GroupBox gb_delegim;
        private System.Windows.Forms.Button btn_kthehu;
        private System.Windows.Forms.DateTimePicker dt_kerkese;
        private System.Windows.Forms.ComboBox cb_pergjegjesit;
        private System.Windows.Forms.ComboBox cb_statusi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_problemi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_faturo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_zgjidhur;
        private System.Windows.Forms.RadioButton rb_mbyllur;
        private System.Windows.Forms.RadioButton rb_vonese;
        private System.Windows.Forms.RadioButton rb_aktive;
        private System.Windows.Forms.Button btn_raport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_prioriteti;
        private System.Windows.Forms.DataGridView grid_analize_ceshtjesh;
        private System.Windows.Forms.RadioButton rb_gjitha;
        private e_supportDataSet e_supportDataSet;
        private System.Windows.Forms.BindingSource statusiBindingSource;
        private e_supportDataSetTableAdapters.statusiTableAdapter statusiTableAdapter;
        private System.Windows.Forms.BindingSource esupportDataSetBindingSource;
        private System.Windows.Forms.BindingSource prioritetiBindingSource;
        private e_supportDataSetTableAdapters.prioritetiTableAdapter prioritetiTableAdapter;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.BindingSource punonjesiBindingSource;
        private e_supportDataSetTableAdapters.punonjesiTableAdapter punonjesiTableAdapter;
        private System.Windows.Forms.Button btn_shtyj;
        private System.Windows.Forms.Button btn_delego;
        private System.Windows.Forms.BindingSource punonjesinfoBindingSource;
        private e_supportDataSetTableAdapters.punonjes_infoTableAdapter punonjes_infoTableAdapter;
    }
}