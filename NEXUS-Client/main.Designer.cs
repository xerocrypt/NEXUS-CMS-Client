namespace NEXUS_Client
{
    partial class frmClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.cmdCases = new System.Windows.Forms.Button();
            this.cmdConnect = new System.Windows.Forms.Button();
            this.cmdMalware = new System.Windows.Forms.Button();
            this.cmdAddMalware = new System.Windows.Forms.Button();
            this.cmdQuit = new System.Windows.Forms.Button();
            this.cmdAddCase = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.crtMalwareTypes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.crtMalwareTypes2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMalwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtMalwareTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtMalwareTypes2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCases
            // 
            this.cmdCases.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdCases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCases.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cmdCases.Location = new System.Drawing.Point(17, 227);
            this.cmdCases.Name = "cmdCases";
            this.cmdCases.Size = new System.Drawing.Size(129, 23);
            this.cmdCases.TabIndex = 8;
            this.cmdCases.Text = "Cases";
            this.cmdCases.UseVisualStyleBackColor = false;
            this.cmdCases.Click += new System.EventHandler(this.cmdCases_Click);
            // 
            // cmdConnect
            // 
            this.cmdConnect.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConnect.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cmdConnect.Location = new System.Drawing.Point(17, 198);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(129, 23);
            this.cmdConnect.TabIndex = 4;
            this.cmdConnect.Text = "Connect";
            this.cmdConnect.UseVisualStyleBackColor = false;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // cmdMalware
            // 
            this.cmdMalware.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdMalware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMalware.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMalware.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cmdMalware.Location = new System.Drawing.Point(18, 256);
            this.cmdMalware.Name = "cmdMalware";
            this.cmdMalware.Size = new System.Drawing.Size(128, 23);
            this.cmdMalware.TabIndex = 5;
            this.cmdMalware.Text = "Malware";
            this.cmdMalware.UseVisualStyleBackColor = false;
            this.cmdMalware.Click += new System.EventHandler(this.cmdMalware_Click);
            // 
            // cmdAddMalware
            // 
            this.cmdAddMalware.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdAddMalware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAddMalware.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddMalware.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cmdAddMalware.Location = new System.Drawing.Point(16, 348);
            this.cmdAddMalware.Name = "cmdAddMalware";
            this.cmdAddMalware.Size = new System.Drawing.Size(130, 23);
            this.cmdAddMalware.TabIndex = 9;
            this.cmdAddMalware.Text = "Update Malware";
            this.cmdAddMalware.UseVisualStyleBackColor = false;
            this.cmdAddMalware.Click += new System.EventHandler(this.cmdAddMalware_Click);
            // 
            // cmdQuit
            // 
            this.cmdQuit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdQuit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cmdQuit.Location = new System.Drawing.Point(16, 377);
            this.cmdQuit.Name = "cmdQuit";
            this.cmdQuit.Size = new System.Drawing.Size(130, 23);
            this.cmdQuit.TabIndex = 7;
            this.cmdQuit.Text = "Quit";
            this.cmdQuit.UseVisualStyleBackColor = false;
            this.cmdQuit.Click += new System.EventHandler(this.cmdQuit_Click);
            // 
            // cmdAddCase
            // 
            this.cmdAddCase.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdAddCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAddCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddCase.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cmdAddCase.Location = new System.Drawing.Point(17, 319);
            this.cmdAddCase.Name = "cmdAddCase";
            this.cmdAddCase.Size = new System.Drawing.Size(129, 23);
            this.cmdAddCase.TabIndex = 6;
            this.cmdAddCase.Text = "Update Case";
            this.cmdAddCase.UseVisualStyleBackColor = false;
            this.cmdAddCase.Click += new System.EventHandler(this.cmdAddCase_Click);
            // 
            // dataGrid
            // 
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGrid.GridColor = System.Drawing.Color.White;
            this.dataGrid.Location = new System.Drawing.Point(158, 67);
            this.dataGrid.Name = "dataGrid";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGrid.Size = new System.Drawing.Size(678, 459);
            this.dataGrid.TabIndex = 2;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "NEXUS CMS";
            // 
            // crtMalwareTypes
            // 
            this.crtMalwareTypes.BackColor = System.Drawing.Color.Transparent;
            chartArea9.BackColor = System.Drawing.Color.Transparent;
            chartArea9.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea9.Name = "ChartArea1";
            chartArea9.Position.Auto = false;
            chartArea9.Position.Height = 94F;
            chartArea9.Position.Width = 70F;
            chartArea9.Position.X = 3F;
            chartArea9.Position.Y = 3F;
            this.crtMalwareTypes.ChartAreas.Add(chartArea9);
            legend9.BackColor = System.Drawing.Color.Cyan;
            legend9.Name = "Legend1";
            this.crtMalwareTypes.Legends.Add(legend9);
            this.crtMalwareTypes.Location = new System.Drawing.Point(22, 65);
            this.crtMalwareTypes.Name = "crtMalwareTypes";
            this.crtMalwareTypes.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.crtMalwareTypes.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.AliceBlue,
        System.Drawing.Color.Aqua,
        System.Drawing.Color.PowderBlue,
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.RoyalBlue,
        System.Drawing.Color.Blue};
            series17.BackSecondaryColor = System.Drawing.Color.Transparent;
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series17.Color = System.Drawing.Color.Transparent;
            series17.LabelBackColor = System.Drawing.Color.Transparent;
            series17.Legend = "Legend1";
            series17.Name = "CaseNumber";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series18.Legend = "Legend1";
            series18.Name = "MalwareUsed";
            this.crtMalwareTypes.Series.Add(series17);
            this.crtMalwareTypes.Series.Add(series18);
            this.crtMalwareTypes.Size = new System.Drawing.Size(300, 225);
            this.crtMalwareTypes.TabIndex = 4;
            this.crtMalwareTypes.Text = "chart1";
            this.crtMalwareTypes.Click += new System.EventHandler(this.crtMalwareTypes_Click);
            // 
            // crtMalwareTypes2
            // 
            this.crtMalwareTypes2.BackColor = System.Drawing.Color.Transparent;
            this.crtMalwareTypes2.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea10.BackColor = System.Drawing.Color.Transparent;
            chartArea10.BorderColor = System.Drawing.Color.Cyan;
            chartArea10.Name = "ChartArea1";
            this.crtMalwareTypes2.ChartAreas.Add(chartArea10);
            legend10.BackColor = System.Drawing.Color.Cyan;
            legend10.Enabled = false;
            legend10.ForeColor = System.Drawing.Color.Cyan;
            legend10.Name = "Legend1";
            legend10.TitleForeColor = System.Drawing.Color.Cyan;
            this.crtMalwareTypes2.Legends.Add(legend10);
            this.crtMalwareTypes2.Location = new System.Drawing.Point(22, 353);
            this.crtMalwareTypes2.Name = "crtMalwareTypes2";
            this.crtMalwareTypes2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.crtMalwareTypes2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.SkyBlue,
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.DodgerBlue,
        System.Drawing.Color.RoyalBlue};
            series19.ChartArea = "ChartArea1";
            series19.LabelForeColor = System.Drawing.Color.Aqua;
            series19.Legend = "Legend1";
            series19.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            series19.Name = "CaseNumber";
            series19.YValuesPerPoint = 2;
            series20.ChartArea = "ChartArea1";
            series20.Legend = "Legend1";
            series20.Name = "MalwareType";
            series20.YValuesPerPoint = 2;
            this.crtMalwareTypes2.Series.Add(series19);
            this.crtMalwareTypes2.Series.Add(series20);
            this.crtMalwareTypes2.Size = new System.Drawing.Size(300, 196);
            this.crtMalwareTypes2.TabIndex = 5;
            this.crtMalwareTypes2.Text = "chart2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(97, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Active Malware Groups";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(99, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Malware Group Activity";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.White;
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtStatus.Location = new System.Drawing.Point(158, 27);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(432, 17);
            this.txtStatus.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.crtMalwareTypes2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.crtMalwareTypes);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(842, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 665);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmdCases);
            this.groupBox4.Controls.Add(this.cmdAddMalware);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.cmdConnect);
            this.groupBox4.Controls.Add(this.cmdMalware);
            this.groupBox4.Controls.Add(this.cmdAddCase);
            this.groupBox4.Controls.Add(this.cmdQuit);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(0, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(152, 665);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1176, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.recordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateCasesToolStripMenuItem,
            this.updateMalwareToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.recordsToolStripMenuItem.Text = "Records";
            // 
            // updateCasesToolStripMenuItem
            // 
            this.updateCasesToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.updateCasesToolStripMenuItem.Name = "updateCasesToolStripMenuItem";
            this.updateCasesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.updateCasesToolStripMenuItem.Text = "Update Cases";
            this.updateCasesToolStripMenuItem.Click += new System.EventHandler(this.updateCasesToolStripMenuItem_Click);
            // 
            // updateMalwareToolStripMenuItem
            // 
            this.updateMalwareToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.updateMalwareToolStripMenuItem.Name = "updateMalwareToolStripMenuItem";
            this.updateMalwareToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.updateMalwareToolStripMenuItem.Text = "Update Malware";
            this.updateMalwareToolStripMenuItem.Click += new System.EventHandler(this.updateMalwareToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 689);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NEXUS CMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtMalwareTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtMalwareTypes2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdCases;
        private System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.Button cmdMalware;
        private System.Windows.Forms.Button cmdAddMalware;
        private System.Windows.Forms.Button cmdQuit;
        private System.Windows.Forms.Button cmdAddCase;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtMalwareTypes;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtMalwareTypes2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMalwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

