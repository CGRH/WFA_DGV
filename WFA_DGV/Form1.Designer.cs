namespace WFA_DGV
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.dGV_CGHs = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.c_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Accelerate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.c_FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Xelem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Yelem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Xsize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Ysize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_diffXelem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_diffYelem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_diffXsize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_diffYsize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_CGHs)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_CGHs
            // 
            this.dGV_CGHs.AllowUserToAddRows = false;
            this.dGV_CGHs.AllowUserToDeleteRows = false;
            this.dGV_CGHs.AllowUserToResizeRows = false;
            this.dGV_CGHs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGV_CGHs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_Order,
            this.c_Accelerate,
            this.c_FileName,
            this.c_Xelem,
            this.c_Yelem,
            this.c_Xsize,
            this.c_Ysize,
            this.c_diffXelem,
            this.c_diffYelem,
            this.c_diffXsize,
            this.c_diffYsize,
            this.c_Remove});
            this.dGV_CGHs.Location = new System.Drawing.Point(12, 50);
            this.dGV_CGHs.Name = "dGV_CGHs";
            this.dGV_CGHs.RowHeadersVisible = false;
            this.dGV_CGHs.RowTemplate.Height = 21;
            this.dGV_CGHs.ShowCellErrors = false;
            this.dGV_CGHs.ShowCellToolTips = false;
            this.dGV_CGHs.ShowEditingIcon = false;
            this.dGV_CGHs.ShowRowErrors = false;
            this.dGV_CGHs.Size = new System.Drawing.Size(980, 509);
            this.dGV_CGHs.TabIndex = 0;
            this.dGV_CGHs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_CGHs_CellClick);
            this.dGV_CGHs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_CGHs_CellContentClick);
            this.dGV_CGHs.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_CGHs_CellValueChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(123, 32);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add Row";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // c_Order
            // 
            this.c_Order.HeaderText = "撮影順";
            this.c_Order.Name = "c_Order";
            this.c_Order.Width = 70;
            // 
            // c_Accelerate
            // 
            this.c_Accelerate.HeaderText = "高速化";
            this.c_Accelerate.Name = "c_Accelerate";
            this.c_Accelerate.Width = 50;
            // 
            // c_FileName
            // 
            this.c_FileName.HeaderText = "ファイル名";
            this.c_FileName.Name = "c_FileName";
            this.c_FileName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c_FileName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.c_FileName.Width = 90;
            // 
            // c_Xelem
            // 
            this.c_Xelem.HeaderText = "X要素数";
            this.c_Xelem.Name = "c_Xelem";
            this.c_Xelem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.c_Xelem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.c_Xelem.Width = 60;
            // 
            // c_Yelem
            // 
            this.c_Yelem.HeaderText = "Y要素数";
            this.c_Yelem.Name = "c_Yelem";
            this.c_Yelem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c_Yelem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.c_Yelem.Width = 60;
            // 
            // c_Xsize
            // 
            this.c_Xsize.HeaderText = "Xサイズ";
            this.c_Xsize.Name = "c_Xsize";
            this.c_Xsize.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c_Xsize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.c_Xsize.Width = 89;
            // 
            // c_Ysize
            // 
            this.c_Ysize.HeaderText = "Yサイス";
            this.c_Ysize.Name = "c_Ysize";
            this.c_Ysize.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c_Ysize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.c_Ysize.Width = 90;
            // 
            // c_diffXelem
            // 
            this.c_diffXelem.HeaderText = "前とのX要素差数";
            this.c_diffXelem.Name = "c_diffXelem";
            this.c_diffXelem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c_diffXelem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // c_diffYelem
            // 
            this.c_diffYelem.HeaderText = "前とのY要素差数";
            this.c_diffYelem.Name = "c_diffYelem";
            this.c_diffYelem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c_diffYelem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // c_diffXsize
            // 
            this.c_diffXsize.HeaderText = "X移動量";
            this.c_diffXsize.Name = "c_diffXsize";
            this.c_diffXsize.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c_diffXsize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.c_diffXsize.Width = 90;
            // 
            // c_diffYsize
            // 
            this.c_diffYsize.HeaderText = "Y移動量";
            this.c_diffYsize.Name = "c_diffYsize";
            this.c_diffYsize.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c_diffYsize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.c_diffYsize.Width = 90;
            // 
            // c_Remove
            // 
            this.c_Remove.HeaderText = "✕";
            this.c_Remove.Name = "c_Remove";
            this.c_Remove.Width = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 581);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dGV_CGHs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_CGHs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_CGHs;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Order;
        private System.Windows.Forms.DataGridViewCheckBoxColumn c_Accelerate;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Xelem;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Yelem;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Xsize;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Ysize;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_diffXelem;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_diffYelem;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_diffXsize;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_diffYsize;
        private System.Windows.Forms.DataGridViewButtonColumn c_Remove;
    }
}

