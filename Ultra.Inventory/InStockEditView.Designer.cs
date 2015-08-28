﻿namespace Ultra.Inventory {
    partial class InStockEditView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gcOrder = new Ultra.Surface.Controls.GridControlEx();
            this.gvOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rspItem = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rspCostPrice = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rspNum = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnDelOrder = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddOrder = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtRemark = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtInStockNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtOuterNo = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFill)).BeginInit();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rspItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rspCostPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rspNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInStockNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOuterNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Size = new System.Drawing.Size(952, 476);
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.xtraTabControl1);
            this.pnlFill.Controls.Add(this.panelControl1);
            this.pnlFill.Size = new System.Drawing.Size(952, 424);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnOK);
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Size = new System.Drawing.Size(952, 52);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 34);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(948, 388);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gcOrder);
            this.xtraTabPage1.Controls.Add(this.panelControl3);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(942, 359);
            this.xtraTabPage1.Text = "添加货物";
            // 
            // gcOrder
            // 
            this.gcOrder.ColorFieldName = null;
            this.gcOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcOrder.Location = new System.Drawing.Point(0, 0);
            this.gcOrder.MainView = this.gvOrder;
            this.gcOrder.Name = "gcOrder";
            this.gcOrder.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rspItem,
            this.rspNum,
            this.rspCostPrice});
            this.gcOrder.ShowIndicator = true;
            this.gcOrder.ShowRowNumber = true;
            this.gcOrder.Size = new System.Drawing.Size(942, 330);
            this.gcOrder.TabIndex = 5;
            this.gcOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrder});
            // 
            // gvOrder
            // 
            this.gvOrder.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gvOrder.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvOrder.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gvOrder.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn6,
            this.gridColumn4,
            this.gridColumn7});
            this.gvOrder.GridControl = this.gcOrder;
            this.gvOrder.Name = "gvOrder";
            this.gvOrder.OptionsView.ColumnAutoWidth = false;
            this.gvOrder.OptionsView.EnableAppearanceEvenRow = true;
            this.gvOrder.OptionsView.EnableAppearanceOddRow = true;
            this.gvOrder.OptionsView.ShowAutoFilterRow = true;
            this.gvOrder.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "货物名称";
            this.gridColumn1.ColumnEdit = this.rspItem;
            this.gridColumn1.FieldName = "ItemName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // rspItem
            // 
            this.rspItem.AutoHeight = false;
            this.rspItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rspItem.DisplayMember = "ItemName";
            this.rspItem.Name = "rspItem";
            this.rspItem.ValueMember = "ItemName";
            this.rspItem.View = this.repositoryItemGridLookUpEdit1View;
            this.rspItem.EditValueChanged += new System.EventHandler(this.rspItem_EditValueChanged);
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn9});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "货物名称";
            this.gridColumn8.FieldName = "ItemName";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "货物编号";
            this.gridColumn9.FieldName = "ItemNo";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "货物编码";
            this.gridColumn2.FieldName = "ItemNo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "单价";
            this.gridColumn6.ColumnEdit = this.rspCostPrice;
            this.gridColumn6.FieldName = "CostPrice";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            // 
            // rspCostPrice
            // 
            this.rspCostPrice.AutoHeight = false;
            this.rspCostPrice.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.rspCostPrice.Name = "rspCostPrice";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "数量";
            this.gridColumn4.ColumnEdit = this.rspNum;
            this.gridColumn4.FieldName = "Num";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // rspNum
            // 
            this.rspNum.AutoHeight = false;
            this.rspNum.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.rspNum.MaxValue = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.rspNum.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rspNum.Name = "rspNum";
            this.rspNum.EditValueChanged += new System.EventHandler(this.rspNum_EditValueChanged);
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "备注";
            this.gridColumn7.FieldName = "Remark";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnDelOrder);
            this.panelControl3.Controls.Add(this.btnAddOrder);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 330);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(942, 29);
            this.panelControl3.TabIndex = 0;
            // 
            // btnDelOrder
            // 
            this.btnDelOrder.Location = new System.Drawing.Point(91, 3);
            this.btnDelOrder.Name = "btnDelOrder";
            this.btnDelOrder.Size = new System.Drawing.Size(75, 23);
            this.btnDelOrder.TabIndex = 1;
            this.btnDelOrder.Text = "删除行";
            this.btnDelOrder.Click += new System.EventHandler(this.btnDelOrder_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(10, 3);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrder.TabIndex = 0;
            this.btnAddOrder.Text = "添加行";
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtOuterNo);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtRemark);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtInStockNo);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(948, 32);
            this.panelControl1.TabIndex = 2;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(479, 5);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(459, 20);
            this.txtRemark.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(449, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "备注";
            // 
            // txtInStockNo
            // 
            this.txtInStockNo.Location = new System.Drawing.Point(65, 5);
            this.txtInStockNo.Name = "txtInStockNo";
            this.txtInStockNo.Size = new System.Drawing.Size(159, 20);
            this.txtInStockNo.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "入库单号";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(760, 10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 35);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "确定(&E)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(853, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(230, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "来货单号";
            // 
            // txtOuterNo
            // 
            this.txtOuterNo.Location = new System.Drawing.Point(284, 5);
            this.txtOuterNo.Name = "txtOuterNo";
            this.txtOuterNo.Size = new System.Drawing.Size(159, 20);
            this.txtOuterNo.TabIndex = 7;
            // 
            // InStockEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 476);
            this.Name = "InStockEditView";
            this.Text = "编辑入库单";
            this.Load += new System.EventHandler(this.InStockEditView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFill)).EndInit();
            this.pnlFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rspItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rspCostPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rspNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInStockNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOuterNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private Surface.Controls.GridControlEx gcOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOrder;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rspItem;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit rspCostPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit rspNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnDelOrder;
        private DevExpress.XtraEditors.SimpleButton btnAddOrder;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtInStockNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.TextEdit txtRemark;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtOuterNo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}