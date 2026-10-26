namespace Industrial_counter
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.데이터ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.계정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.계정관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOX_QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ERROR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNUSED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCANNER01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.industrialDataSet1 = new Industrial_counter.industrialDataSet1();
            this.countBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.industrialDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.industrialDataSet = new Industrial_counter.industrialDataSet();
            this.countTableAdapter = new Industrial_counter.industrialDataSetTableAdapters.CountTableAdapter();
            this.countBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sCANNER02BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.industrialDataSet2 = new Industrial_counter.industrialDataSet2();
            this.sCANNER04BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.industrialDataSet4 = new Industrial_counter.industrialDataSet4();
            this.sCANNER03BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.industrialDataSet3 = new Industrial_counter.industrialDataSet3();
            this.sCANNER06BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.industrialDataSet6 = new Industrial_counter.industrialDataSet6();
            this.sCANNER05BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.industrialDataSet5 = new Industrial_counter.industrialDataSet5();
            this.sCANNER08BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.industrialDataSet8 = new Industrial_counter.industrialDataSet8();
            this.sCANNER07BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.industrialDataSet7 = new Industrial_counter.industrialDataSet7();
            this.sCANNER10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.industrialDataSet10 = new Industrial_counter.industrialDataSet10();
            this.sCANNER09BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.industrialDataSet9 = new Industrial_counter.industrialDataSet9();
            this.sCANNER01TableAdapter = new Industrial_counter.industrialDataSet1TableAdapters.SCANNER01TableAdapter();
            this.sCANNER02TableAdapter = new Industrial_counter.industrialDataSet2TableAdapters.SCANNER02TableAdapter();
            this.sCANNER03TableAdapter = new Industrial_counter.industrialDataSet3TableAdapters.SCANNER03TableAdapter();
            this.sCANNER04TableAdapter = new Industrial_counter.industrialDataSet4TableAdapters.SCANNER04TableAdapter();
            this.sCANNER05TableAdapter = new Industrial_counter.industrialDataSet5TableAdapters.SCANNER05TableAdapter();
            this.sCANNER06TableAdapter = new Industrial_counter.industrialDataSet6TableAdapters.SCANNER06TableAdapter();
            this.sCANNER07TableAdapter = new Industrial_counter.industrialDataSet7TableAdapters.SCANNER07TableAdapter();
            this.sCANNER08TableAdapter = new Industrial_counter.industrialDataSet8TableAdapters.SCANNER08TableAdapter();
            this.sCANNER09TableAdapter = new Industrial_counter.industrialDataSet9TableAdapters.SCANNER09TableAdapter();
            this.sCANNER10TableAdapter = new Industrial_counter.industrialDataSet10TableAdapters.SCANNER10TableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.searching_btn = new System.Windows.Forms.Button();
            this.unused_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.error_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.box_quantity_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quantity_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.model_text = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.scanner01 = new System.Windows.Forms.CheckBox();
            this.scanner02 = new System.Windows.Forms.CheckBox();
            this.scanner04 = new System.Windows.Forms.CheckBox();
            this.scanner03 = new System.Windows.Forms.CheckBox();
            this.scanner08 = new System.Windows.Forms.CheckBox();
            this.scanner07 = new System.Windows.Forms.CheckBox();
            this.scanner06 = new System.Windows.Forms.CheckBox();
            this.scanner05 = new System.Windows.Forms.CheckBox();
            this.scanner10 = new System.Windows.Forms.CheckBox();
            this.scanner09 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCANNER01BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.industrialDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.industrialDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.industrialDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCANNER02BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.industrialDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCANNER04BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.industrialDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCANNER03BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.industrialDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCANNER06BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.industrialDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCANNER05BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.industrialDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCANNER08BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.industrialDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCANNER07BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.industrialDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCANNER10BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.industrialDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCANNER09BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.industrialDataSet9)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.데이터ToolStripMenuItem,
            this.계정ToolStripMenuItem,
            this.정보ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1291, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 데이터ToolStripMenuItem
            // 
            this.데이터ToolStripMenuItem.Name = "데이터ToolStripMenuItem";
            this.데이터ToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.데이터ToolStripMenuItem.Text = "데이터";
            // 
            // 계정ToolStripMenuItem
            // 
            this.계정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.로그인ToolStripMenuItem,
            this.계정관리ToolStripMenuItem});
            this.계정ToolStripMenuItem.Name = "계정ToolStripMenuItem";
            this.계정ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.계정ToolStripMenuItem.Text = "계정";
            // 
            // 로그인ToolStripMenuItem
            // 
            this.로그인ToolStripMenuItem.Name = "로그인ToolStripMenuItem";
            this.로그인ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.로그인ToolStripMenuItem.Text = "로그아웃";
            this.로그인ToolStripMenuItem.Click += new System.EventHandler(this.로그인ToolStripMenuItem_Click);
            // 
            // 계정관리ToolStripMenuItem
            // 
            this.계정관리ToolStripMenuItem.Name = "계정관리ToolStripMenuItem";
            this.계정관리ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.계정관리ToolStripMenuItem.Text = "계정 관리";
            // 
            // 정보ToolStripMenuItem
            // 
            this.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem";
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.정보ToolStripMenuItem.Text = "정보";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.MODEL,
            this.QUANTITY,
            this.BOX_QUANTITY,
            this.ERROR,
            this.UNUSED});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(7, 40);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(513, 159);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // MODEL
            // 
            this.MODEL.HeaderText = "MODEL";
            this.MODEL.Name = "MODEL";
            // 
            // QUANTITY
            // 
            this.QUANTITY.HeaderText = "QUANTITY";
            this.QUANTITY.Name = "QUANTITY";
            // 
            // BOX_QUANTITY
            // 
            this.BOX_QUANTITY.HeaderText = "BOX_QUANTITY";
            this.BOX_QUANTITY.Name = "BOX_QUANTITY";
            // 
            // ERROR
            // 
            this.ERROR.HeaderText = "ERROR";
            this.ERROR.Name = "ERROR";
            // 
            // UNUSED
            // 
            this.UNUSED.HeaderText = "UNUSED";
            this.UNUSED.Name = "UNUSED";
            // 
            // sCANNER01BindingSource
            // 
            this.sCANNER01BindingSource.DataMember = "SCANNER01";
            this.sCANNER01BindingSource.DataSource = this.industrialDataSet1;
            // 
            // industrialDataSet1
            // 
            this.industrialDataSet1.DataSetName = "industrialDataSet1";
            this.industrialDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countBindingSource
            // 
            this.countBindingSource.DataMember = "Count";
            this.countBindingSource.DataSource = this.industrialDataSetBindingSource;
            // 
            // industrialDataSetBindingSource
            // 
            this.industrialDataSetBindingSource.DataSource = this.industrialDataSet;
            this.industrialDataSetBindingSource.Position = 0;
            // 
            // industrialDataSet
            // 
            this.industrialDataSet.DataSetName = "industrialDataSet";
            this.industrialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countTableAdapter
            // 
            this.countTableAdapter.ClearBeforeFill = true;
            // 
            // countBindingSource1
            // 
            this.countBindingSource1.DataMember = "Count";
            this.countBindingSource1.DataSource = this.industrialDataSetBindingSource;
            // 
            // sCANNER02BindingSource
            // 
            this.sCANNER02BindingSource.DataMember = "SCANNER02";
            this.sCANNER02BindingSource.DataSource = this.industrialDataSet2;
            // 
            // industrialDataSet2
            // 
            this.industrialDataSet2.DataSetName = "industrialDataSet2";
            this.industrialDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sCANNER04BindingSource
            // 
            this.sCANNER04BindingSource.DataMember = "SCANNER04";
            this.sCANNER04BindingSource.DataSource = this.industrialDataSet4;
            // 
            // industrialDataSet4
            // 
            this.industrialDataSet4.DataSetName = "industrialDataSet4";
            this.industrialDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sCANNER03BindingSource
            // 
            this.sCANNER03BindingSource.DataMember = "SCANNER03";
            this.sCANNER03BindingSource.DataSource = this.industrialDataSet3;
            // 
            // industrialDataSet3
            // 
            this.industrialDataSet3.DataSetName = "industrialDataSet3";
            this.industrialDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sCANNER06BindingSource
            // 
            this.sCANNER06BindingSource.DataMember = "SCANNER06";
            this.sCANNER06BindingSource.DataSource = this.industrialDataSet6;
            // 
            // industrialDataSet6
            // 
            this.industrialDataSet6.DataSetName = "industrialDataSet6";
            this.industrialDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sCANNER05BindingSource
            // 
            this.sCANNER05BindingSource.DataMember = "SCANNER05";
            this.sCANNER05BindingSource.DataSource = this.industrialDataSet5;
            // 
            // industrialDataSet5
            // 
            this.industrialDataSet5.DataSetName = "industrialDataSet5";
            this.industrialDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sCANNER08BindingSource
            // 
            this.sCANNER08BindingSource.DataMember = "SCANNER08";
            this.sCANNER08BindingSource.DataSource = this.industrialDataSet8;
            // 
            // industrialDataSet8
            // 
            this.industrialDataSet8.DataSetName = "industrialDataSet8";
            this.industrialDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sCANNER07BindingSource
            // 
            this.sCANNER07BindingSource.DataMember = "SCANNER07";
            this.sCANNER07BindingSource.DataSource = this.industrialDataSet7;
            // 
            // industrialDataSet7
            // 
            this.industrialDataSet7.DataSetName = "industrialDataSet7";
            this.industrialDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sCANNER10BindingSource
            // 
            this.sCANNER10BindingSource.DataMember = "SCANNER10";
            this.sCANNER10BindingSource.DataSource = this.industrialDataSet10;
            // 
            // industrialDataSet10
            // 
            this.industrialDataSet10.DataSetName = "industrialDataSet10";
            this.industrialDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sCANNER09BindingSource
            // 
            this.sCANNER09BindingSource.DataMember = "SCANNER09";
            this.sCANNER09BindingSource.DataSource = this.industrialDataSet9;
            // 
            // industrialDataSet9
            // 
            this.industrialDataSet9.DataSetName = "industrialDataSet9";
            this.industrialDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sCANNER01TableAdapter
            // 
            this.sCANNER01TableAdapter.ClearBeforeFill = true;
            // 
            // sCANNER02TableAdapter
            // 
            this.sCANNER02TableAdapter.ClearBeforeFill = true;
            // 
            // sCANNER03TableAdapter
            // 
            this.sCANNER03TableAdapter.ClearBeforeFill = true;
            // 
            // sCANNER04TableAdapter
            // 
            this.sCANNER04TableAdapter.ClearBeforeFill = true;
            // 
            // sCANNER05TableAdapter
            // 
            this.sCANNER05TableAdapter.ClearBeforeFill = true;
            // 
            // sCANNER06TableAdapter
            // 
            this.sCANNER06TableAdapter.ClearBeforeFill = true;
            // 
            // sCANNER07TableAdapter
            // 
            this.sCANNER07TableAdapter.ClearBeforeFill = true;
            // 
            // sCANNER08TableAdapter
            // 
            this.sCANNER08TableAdapter.ClearBeforeFill = true;
            // 
            // sCANNER09TableAdapter
            // 
            this.sCANNER09TableAdapter.ClearBeforeFill = true;
            // 
            // sCANNER10TableAdapter
            // 
            this.sCANNER10TableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.searching_btn);
            this.panel2.Controls.Add(this.unused_text);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.error_text);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.box_quantity_text);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.quantity_text);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.model_text);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(1078, 170);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 499);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(3, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "검색";
            // 
            // searching_btn
            // 
            this.searching_btn.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searching_btn.Location = new System.Drawing.Point(126, 450);
            this.searching_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searching_btn.Name = "searching_btn";
            this.searching_btn.Size = new System.Drawing.Size(59, 30);
            this.searching_btn.TabIndex = 5;
            this.searching_btn.Text = "검색";
            this.searching_btn.UseVisualStyleBackColor = true;
            this.searching_btn.Click += new System.EventHandler(this.searching_btn_Click);
            // 
            // unused_text
            // 
            this.unused_text.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.unused_text.Location = new System.Drawing.Point(7, 411);
            this.unused_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.unused_text.Name = "unused_text";
            this.unused_text.Size = new System.Drawing.Size(178, 21);
            this.unused_text.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(3, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "폐기품 수량";
            // 
            // error_text
            // 
            this.error_text.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.error_text.Location = new System.Drawing.Point(7, 335);
            this.error_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.error_text.Name = "error_text";
            this.error_text.Size = new System.Drawing.Size(178, 21);
            this.error_text.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(3, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "불량품 수량";
            // 
            // box_quantity_text
            // 
            this.box_quantity_text.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.box_quantity_text.Location = new System.Drawing.Point(7, 259);
            this.box_quantity_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_quantity_text.Name = "box_quantity_text";
            this.box_quantity_text.Size = new System.Drawing.Size(178, 21);
            this.box_quantity_text.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(3, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "박스 수량";
            // 
            // quantity_text
            // 
            this.quantity_text.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.quantity_text.Location = new System.Drawing.Point(8, 185);
            this.quantity_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quantity_text.Name = "quantity_text";
            this.quantity_text.Size = new System.Drawing.Size(178, 21);
            this.quantity_text.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "제품 수량";
            // 
            // model_text
            // 
            this.model_text.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.model_text.Location = new System.Drawing.Point(7, 112);
            this.model_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.model_text.Name = "model_text";
            this.model_text.Size = new System.Drawing.Size(178, 21);
            this.model_text.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(3, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "제품명";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(5, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "______________________________\r\n";
            // 
            // scanner01
            // 
            this.scanner01.AutoCheck = false;
            this.scanner01.AutoSize = true;
            this.scanner01.Checked = true;
            this.scanner01.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scanner01.Enabled = false;
            this.scanner01.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scanner01.Location = new System.Drawing.Point(7, 18);
            this.scanner01.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scanner01.Name = "scanner01";
            this.scanner01.Size = new System.Drawing.Size(85, 18);
            this.scanner01.TabIndex = 2;
            this.scanner01.Text = "Scanner01";
            this.scanner01.UseVisualStyleBackColor = true;
            // 
            // scanner02
            // 
            this.scanner02.AutoCheck = false;
            this.scanner02.AutoSize = true;
            this.scanner02.Enabled = false;
            this.scanner02.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scanner02.Location = new System.Drawing.Point(526, 18);
            this.scanner02.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scanner02.Name = "scanner02";
            this.scanner02.Size = new System.Drawing.Size(85, 18);
            this.scanner02.TabIndex = 35;
            this.scanner02.Text = "Scanner02";
            this.scanner02.UseVisualStyleBackColor = true;
            // 
            // scanner04
            // 
            this.scanner04.AutoCheck = false;
            this.scanner04.AutoSize = true;
            this.scanner04.Enabled = false;
            this.scanner04.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scanner04.Location = new System.Drawing.Point(526, 205);
            this.scanner04.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scanner04.Name = "scanner04";
            this.scanner04.Size = new System.Drawing.Size(85, 18);
            this.scanner04.TabIndex = 37;
            this.scanner04.Text = "Scanner04";
            this.scanner04.UseVisualStyleBackColor = true;
            // 
            // scanner03
            // 
            this.scanner03.AutoCheck = false;
            this.scanner03.AutoSize = true;
            this.scanner03.Enabled = false;
            this.scanner03.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scanner03.Location = new System.Drawing.Point(7, 205);
            this.scanner03.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scanner03.Name = "scanner03";
            this.scanner03.Size = new System.Drawing.Size(85, 18);
            this.scanner03.TabIndex = 36;
            this.scanner03.Text = "Scanner03";
            this.scanner03.UseVisualStyleBackColor = true;
            // 
            // scanner08
            // 
            this.scanner08.AutoCheck = false;
            this.scanner08.AutoSize = true;
            this.scanner08.Enabled = false;
            this.scanner08.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scanner08.Location = new System.Drawing.Point(526, 582);
            this.scanner08.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scanner08.Name = "scanner08";
            this.scanner08.Size = new System.Drawing.Size(85, 18);
            this.scanner08.TabIndex = 41;
            this.scanner08.Text = "Scanner08";
            this.scanner08.UseVisualStyleBackColor = true;
            // 
            // scanner07
            // 
            this.scanner07.AutoCheck = false;
            this.scanner07.AutoSize = true;
            this.scanner07.Enabled = false;
            this.scanner07.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scanner07.Location = new System.Drawing.Point(7, 582);
            this.scanner07.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scanner07.Name = "scanner07";
            this.scanner07.Size = new System.Drawing.Size(85, 18);
            this.scanner07.TabIndex = 40;
            this.scanner07.Text = "Scanner07";
            this.scanner07.UseVisualStyleBackColor = true;
            // 
            // scanner06
            // 
            this.scanner06.AutoCheck = false;
            this.scanner06.AutoSize = true;
            this.scanner06.Enabled = false;
            this.scanner06.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scanner06.Location = new System.Drawing.Point(526, 394);
            this.scanner06.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scanner06.Name = "scanner06";
            this.scanner06.Size = new System.Drawing.Size(85, 18);
            this.scanner06.TabIndex = 39;
            this.scanner06.Text = "Scanner06";
            this.scanner06.UseVisualStyleBackColor = true;
            // 
            // scanner05
            // 
            this.scanner05.AutoCheck = false;
            this.scanner05.AutoSize = true;
            this.scanner05.Enabled = false;
            this.scanner05.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scanner05.Location = new System.Drawing.Point(7, 394);
            this.scanner05.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scanner05.Name = "scanner05";
            this.scanner05.Size = new System.Drawing.Size(85, 18);
            this.scanner05.TabIndex = 38;
            this.scanner05.Text = "Scanner05";
            this.scanner05.UseVisualStyleBackColor = true;
            // 
            // scanner10
            // 
            this.scanner10.AutoCheck = false;
            this.scanner10.AutoSize = true;
            this.scanner10.Enabled = false;
            this.scanner10.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scanner10.Location = new System.Drawing.Point(526, 754);
            this.scanner10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scanner10.Name = "scanner10";
            this.scanner10.Size = new System.Drawing.Size(85, 18);
            this.scanner10.TabIndex = 43;
            this.scanner10.Text = "Scanner10";
            this.scanner10.UseVisualStyleBackColor = true;
            // 
            // scanner09
            // 
            this.scanner09.AutoCheck = false;
            this.scanner09.AutoSize = true;
            this.scanner09.Enabled = false;
            this.scanner09.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scanner09.Location = new System.Drawing.Point(7, 754);
            this.scanner09.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scanner09.Name = "scanner09";
            this.scanner09.Size = new System.Drawing.Size(85, 18);
            this.scanner09.TabIndex = 42;
            this.scanner09.Text = "Scanner09";
            this.scanner09.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(7, 56);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(3, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "값 삽입";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(1078, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 135);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(114, 88);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "새로고침";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.scanner01);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.scanner10);
            this.panel3.Controls.Add(this.scanner02);
            this.panel3.Controls.Add(this.scanner09);
            this.panel3.Controls.Add(this.scanner03);
            this.panel3.Controls.Add(this.scanner08);
            this.panel3.Controls.Add(this.scanner04);
            this.panel3.Controls.Add(this.scanner07);
            this.panel3.Controls.Add(this.scanner05);
            this.panel3.Controls.Add(this.scanner06);
            this.panel3.Location = new System.Drawing.Point(6, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1066, 885);
            this.panel3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1308, 854);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "수량 보고 도우미 (생산자용)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCANNER01BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.industrialDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.industrialDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.industrialDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCANNER02BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.industrialDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCANNER04BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.industrialDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCANNER03BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.industrialDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCANNER06BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.industrialDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCANNER05BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.industrialDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCANNER08BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.industrialDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCANNER07BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.industrialDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCANNER10BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.industrialDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCANNER09BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.industrialDataSet9)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 데이터ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 계정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 계정관리ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource industrialDataSetBindingSource;
        private industrialDataSet industrialDataSet;
        private System.Windows.Forms.BindingSource countBindingSource;
        private industrialDataSetTableAdapters.CountTableAdapter countTableAdapter;
        private System.Windows.Forms.BindingSource countBindingSource1;
        private industrialDataSet1 industrialDataSet1;
        private System.Windows.Forms.BindingSource sCANNER01BindingSource;
        private industrialDataSet1TableAdapters.SCANNER01TableAdapter sCANNER01TableAdapter;
        private industrialDataSet2 industrialDataSet2;
        private System.Windows.Forms.BindingSource sCANNER02BindingSource;
        private industrialDataSet2TableAdapters.SCANNER02TableAdapter sCANNER02TableAdapter;
        private industrialDataSet3 industrialDataSet3;
        private System.Windows.Forms.BindingSource sCANNER03BindingSource;
        private industrialDataSet3TableAdapters.SCANNER03TableAdapter sCANNER03TableAdapter;
        private industrialDataSet4 industrialDataSet4;
        private System.Windows.Forms.BindingSource sCANNER04BindingSource;
        private industrialDataSet4TableAdapters.SCANNER04TableAdapter sCANNER04TableAdapter;
        private industrialDataSet5 industrialDataSet5;
        private System.Windows.Forms.BindingSource sCANNER05BindingSource;
        private industrialDataSet5TableAdapters.SCANNER05TableAdapter sCANNER05TableAdapter;
        private industrialDataSet6 industrialDataSet6;
        private System.Windows.Forms.BindingSource sCANNER06BindingSource;
        private industrialDataSet6TableAdapters.SCANNER06TableAdapter sCANNER06TableAdapter;
        private industrialDataSet7 industrialDataSet7;
        private System.Windows.Forms.BindingSource sCANNER07BindingSource;
        private industrialDataSet7TableAdapters.SCANNER07TableAdapter sCANNER07TableAdapter;
        private industrialDataSet8 industrialDataSet8;
        private System.Windows.Forms.BindingSource sCANNER08BindingSource;
        private industrialDataSet8TableAdapters.SCANNER08TableAdapter sCANNER08TableAdapter;
        private industrialDataSet9 industrialDataSet9;
        private System.Windows.Forms.BindingSource sCANNER09BindingSource;
        private industrialDataSet9TableAdapters.SCANNER09TableAdapter sCANNER09TableAdapter;
        private industrialDataSet10 industrialDataSet10;
        private System.Windows.Forms.BindingSource sCANNER10BindingSource;
        private industrialDataSet10TableAdapters.SCANNER10TableAdapter sCANNER10TableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox model_text;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOX_QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ERROR;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNUSED;
        private System.Windows.Forms.CheckBox scanner01;
        private System.Windows.Forms.CheckBox scanner02;
        private System.Windows.Forms.CheckBox scanner04;
        private System.Windows.Forms.CheckBox scanner03;
        private System.Windows.Forms.CheckBox scanner08;
        private System.Windows.Forms.CheckBox scanner07;
        private System.Windows.Forms.CheckBox scanner06;
        private System.Windows.Forms.CheckBox scanner05;
        private System.Windows.Forms.CheckBox scanner10;
        private System.Windows.Forms.CheckBox scanner09;
        private System.Windows.Forms.Button searching_btn;
        private System.Windows.Forms.TextBox unused_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox error_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box_quantity_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantity_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
    }
}

