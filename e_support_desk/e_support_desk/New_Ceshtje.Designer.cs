
namespace e_support_desk
{
    partial class New_Ceshtje
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_problemi = new System.Windows.Forms.TextBox();
            this.dt_afati = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chb_garancia = new System.Windows.Forms.CheckBox();
            this.e_supportDataSet = new e_support_desk.e_supportDataSet();
            this.prioritetiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prioritetiTableAdapter = new e_support_desk.e_supportDataSetTableAdapters.prioritetiTableAdapter();
            this.sherbimiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sherbimiTableAdapter = new e_support_desk.e_supportDataSetTableAdapters.sherbimiTableAdapter();
            this.cb_sherbimi = new System.Windows.Forms.ComboBox();
            this.sherbimiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cb_pergjegjesi = new System.Windows.Forms.ComboBox();
            this.punonjesiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.punonjesiTableAdapter = new e_support_desk.e_supportDataSetTableAdapters.punonjesiTableAdapter();
            this.cb_prioriteti = new System.Windows.Forms.ComboBox();
            this.prioritetiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.esupportDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_klienti = new System.Windows.Forms.ComboBox();
            this.btn_hap_cesh = new System.Windows.Forms.Button();
            this.btn_cesh_re = new System.Windows.Forms.Button();
            this.punonjesinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.punonjes_infoTableAdapter = new e_support_desk.e_supportDataSetTableAdapters.punonjes_infoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.e_supportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prioritetiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sherbimiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sherbimiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punonjesiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prioritetiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esupportDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.punonjesinfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(936, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 50);
            this.button1.TabIndex = 13;
            this.button1.Text = "Kthehu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_problemi
            // 
            this.txt_problemi.Location = new System.Drawing.Point(213, 247);
            this.txt_problemi.Multiline = true;
            this.txt_problemi.Name = "txt_problemi";
            this.txt_problemi.Size = new System.Drawing.Size(455, 114);
            this.txt_problemi.TabIndex = 22;
            // 
            // dt_afati
            // 
            this.dt_afati.Location = new System.Drawing.Point(213, 395);
            this.dt_afati.MinDate = new System.DateTime(2021, 2, 13, 0, 0, 0, 0);
            this.dt_afati.Name = "dt_afati";
            this.dt_afati.Size = new System.Drawing.Size(455, 26);
            this.dt_afati.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 25;
            this.label2.Text = "Klienti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Pergjegjesi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 26);
            this.label3.TabIndex = 27;
            this.label3.Text = "Sherbimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 26);
            this.label4.TabIndex = 28;
            this.label4.Text = "Problemi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 26);
            this.label5.TabIndex = 29;
            this.label5.Text = "Prioriteti";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 26);
            this.label6.TabIndex = 30;
            this.label6.Text = "Afati kohor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 501);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 26);
            this.label7.TabIndex = 31;
            this.label7.Text = "Garancia";
            // 
            // chb_garancia
            // 
            this.chb_garancia.AutoSize = true;
            this.chb_garancia.Location = new System.Drawing.Point(213, 505);
            this.chb_garancia.Name = "chb_garancia";
            this.chb_garancia.Size = new System.Drawing.Size(113, 24);
            this.chb_garancia.TabIndex = 32;
            this.chb_garancia.Text = "me garanci";
            this.chb_garancia.UseVisualStyleBackColor = true;
            // 
            // e_supportDataSet
            // 
            this.e_supportDataSet.DataSetName = "e_supportDataSet";
            this.e_supportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prioritetiBindingSource
            // 
            this.prioritetiBindingSource.DataMember = "prioriteti";
            this.prioritetiBindingSource.DataSource = this.e_supportDataSet;
            // 
            // prioritetiTableAdapter
            // 
            this.prioritetiTableAdapter.ClearBeforeFill = true;
            // 
            // sherbimiBindingSource
            // 
            this.sherbimiBindingSource.DataMember = "sherbimi";
            this.sherbimiBindingSource.DataSource = this.e_supportDataSet;
            // 
            // sherbimiTableAdapter
            // 
            this.sherbimiTableAdapter.ClearBeforeFill = true;
            // 
            // cb_sherbimi
            // 
            this.cb_sherbimi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_sherbimi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_sherbimi.DataSource = this.sherbimiBindingSource1;
            this.cb_sherbimi.DisplayMember = "lloji";
            this.cb_sherbimi.FormattingEnabled = true;
            this.cb_sherbimi.Location = new System.Drawing.Point(213, 181);
            this.cb_sherbimi.Name = "cb_sherbimi";
            this.cb_sherbimi.Size = new System.Drawing.Size(455, 28);
            this.cb_sherbimi.TabIndex = 33;
            this.cb_sherbimi.ValueMember = "id_sherbimi";
            // 
            // sherbimiBindingSource1
            // 
            this.sherbimiBindingSource1.DataMember = "sherbimi";
            this.sherbimiBindingSource1.DataSource = this.e_supportDataSet;
            // 
            // cb_pergjegjesi
            // 
            this.cb_pergjegjesi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_pergjegjesi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_pergjegjesi.DataSource = this.punonjesinfoBindingSource;
            this.cb_pergjegjesi.DisplayMember = "punonjesi";
            this.cb_pergjegjesi.FormattingEnabled = true;
            this.cb_pergjegjesi.Location = new System.Drawing.Point(213, 123);
            this.cb_pergjegjesi.Name = "cb_pergjegjesi";
            this.cb_pergjegjesi.Size = new System.Drawing.Size(455, 28);
            this.cb_pergjegjesi.TabIndex = 35;
            this.cb_pergjegjesi.ValueMember = "id_punonjesi";
            // 
            // punonjesiBindingSource
            // 
            this.punonjesiBindingSource.DataMember = "punonjesi";
            this.punonjesiBindingSource.DataSource = this.e_supportDataSet;
            // 
            // punonjesiTableAdapter
            // 
            this.punonjesiTableAdapter.ClearBeforeFill = true;
            // 
            // cb_prioriteti
            // 
            this.cb_prioriteti.DataSource = this.prioritetiBindingSource1;
            this.cb_prioriteti.DisplayMember = "vlera";
            this.cb_prioriteti.FormattingEnabled = true;
            this.cb_prioriteti.Location = new System.Drawing.Point(213, 449);
            this.cb_prioriteti.Name = "cb_prioriteti";
            this.cb_prioriteti.Size = new System.Drawing.Size(121, 28);
            this.cb_prioriteti.TabIndex = 36;
            this.cb_prioriteti.ValueMember = "vlera";
            // 
            // prioritetiBindingSource1
            // 
            this.prioritetiBindingSource1.DataMember = "prioriteti";
            this.prioritetiBindingSource1.DataSource = this.esupportDataSetBindingSource;
            // 
            // esupportDataSetBindingSource
            // 
            this.esupportDataSetBindingSource.DataSource = this.e_supportDataSet;
            this.esupportDataSetBindingSource.Position = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_klienti);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_prioriteti);
            this.groupBox1.Controls.Add(this.chb_garancia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cb_pergjegjesi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_sherbimi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_problemi);
            this.groupBox1.Controls.Add(this.dt_afati);
            this.groupBox1.Location = new System.Drawing.Point(56, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 579);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hap ticket per nje ceshtje te re";
            // 
            // cb_klienti
            // 
            this.cb_klienti.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_klienti.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_klienti.DisplayMember = "id_klienti";
            this.cb_klienti.FormattingEnabled = true;
            this.cb_klienti.Location = new System.Drawing.Point(213, 71);
            this.cb_klienti.Name = "cb_klienti";
            this.cb_klienti.Size = new System.Drawing.Size(455, 28);
            this.cb_klienti.TabIndex = 36;
            this.cb_klienti.ValueMember = "id_klienti";
            this.cb_klienti.SelectedIndexChanged += new System.EventHandler(this.cb_klienti_SelectedIndexChanged_1);
            // 
            // btn_hap_cesh
            // 
            this.btn_hap_cesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hap_cesh.Location = new System.Drawing.Point(936, 363);
            this.btn_hap_cesh.Name = "btn_hap_cesh";
            this.btn_hap_cesh.Size = new System.Drawing.Size(233, 50);
            this.btn_hap_cesh.TabIndex = 38;
            this.btn_hap_cesh.Text = "Hap ceshtje";
            this.btn_hap_cesh.UseVisualStyleBackColor = true;
            this.btn_hap_cesh.Click += new System.EventHandler(this.btn_hap_cesh_Click);
            // 
            // btn_cesh_re
            // 
            this.btn_cesh_re.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cesh_re.Location = new System.Drawing.Point(936, 468);
            this.btn_cesh_re.Name = "btn_cesh_re";
            this.btn_cesh_re.Size = new System.Drawing.Size(233, 50);
            this.btn_cesh_re.TabIndex = 39;
            this.btn_cesh_re.Text = "Ceshtje e re";
            this.btn_cesh_re.UseVisualStyleBackColor = true;
            this.btn_cesh_re.Click += new System.EventHandler(this.btn_cesh_re_Click);
            // 
            // punonjesinfoBindingSource
            // 
            this.punonjesinfoBindingSource.DataMember = "punonjes_info";
            this.punonjesinfoBindingSource.DataSource = this.esupportDataSetBindingSource;
            // 
            // punonjes_infoTableAdapter
            // 
            this.punonjes_infoTableAdapter.ClearBeforeFill = true;
            // 
            // New_Ceshtje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 678);
            this.Controls.Add(this.btn_cesh_re);
            this.Controls.Add(this.btn_hap_cesh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "New_Ceshtje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New_Ceshtje";
            this.Load += new System.EventHandler(this.New_Ceshtje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.e_supportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prioritetiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sherbimiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sherbimiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punonjesiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prioritetiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esupportDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.punonjesinfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_problemi;
        private System.Windows.Forms.DateTimePicker dt_afati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chb_garancia;
        private e_supportDataSet e_supportDataSet;
        private System.Windows.Forms.BindingSource prioritetiBindingSource;
        private e_supportDataSetTableAdapters.prioritetiTableAdapter prioritetiTableAdapter;
        private System.Windows.Forms.BindingSource sherbimiBindingSource;
        private e_supportDataSetTableAdapters.sherbimiTableAdapter sherbimiTableAdapter;
        private System.Windows.Forms.ComboBox cb_sherbimi;
        private System.Windows.Forms.BindingSource sherbimiBindingSource1;
        private System.Windows.Forms.ComboBox cb_pergjegjesi;
        private System.Windows.Forms.BindingSource punonjesiBindingSource;
        private e_supportDataSetTableAdapters.punonjesiTableAdapter punonjesiTableAdapter;
        private System.Windows.Forms.ComboBox cb_prioriteti;
        private System.Windows.Forms.BindingSource prioritetiBindingSource1;
        private System.Windows.Forms.BindingSource esupportDataSetBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_hap_cesh;
        private System.Windows.Forms.ComboBox cb_klienti;
        private System.Windows.Forms.Button btn_cesh_re;
        private System.Windows.Forms.BindingSource punonjesinfoBindingSource;
        private e_supportDataSetTableAdapters.punonjes_infoTableAdapter punonjes_infoTableAdapter;
    }
}