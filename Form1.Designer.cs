
namespace RetroCHTBuilder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.input_Desc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Index = new System.Windows.Forms.Label();
            this.InputCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBEnable = new System.Windows.Forms.CheckBox();
            this.BEAdd = new System.Windows.Forms.Button();
            this.Input_Index = new System.Windows.Forms.TextBox();
            this.BSearch = new System.Windows.Forms.Button();
            this.groupEdit = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBPlatform = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InputGN = new System.Windows.Forms.TextBox();
            this.BCancel = new System.Windows.Forms.Button();
            this.InputFile = new System.Windows.Forms.RichTextBox();
            this.GBView = new System.Windows.Forms.GroupBox();
            this.LStatus = new System.Windows.Forms.Label();
            this.BLoad = new System.Windows.Forms.Button();
            this.BOSave = new System.Windows.Forms.Button();
            this.GBUpload = new System.Windows.Forms.GroupBox();
            this.BBrowse = new System.Windows.Forms.Button();
            this.InputBrowse = new System.Windows.Forms.TextBox();
            this.groupEdit.SuspendLayout();
            this.GBView.SuspendLayout();
            this.GBUpload.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_Desc
            // 
            this.input_Desc.Location = new System.Drawing.Point(28, 237);
            this.input_Desc.Name = "input_Desc";
            this.input_Desc.Size = new System.Drawing.Size(286, 23);
            this.input_Desc.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description:";
            // 
            // LB_Index
            // 
            this.LB_Index.AutoSize = true;
            this.LB_Index.Location = new System.Drawing.Point(29, 90);
            this.LB_Index.Name = "LB_Index";
            this.LB_Index.Size = new System.Drawing.Size(39, 15);
            this.LB_Index.TabIndex = 2;
            this.LB_Index.Text = "Index:";
            this.LB_Index.Visible = false;
            // 
            // InputCode
            // 
            this.InputCode.Location = new System.Drawing.Point(28, 296);
            this.InputCode.Multiline = true;
            this.InputCode.Name = "InputCode";
            this.InputCode.Size = new System.Drawing.Size(286, 138);
            this.InputCode.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codes";
            // 
            // CBEnable
            // 
            this.CBEnable.AutoSize = true;
            this.CBEnable.Location = new System.Drawing.Point(28, 440);
            this.CBEnable.Name = "CBEnable";
            this.CBEnable.Size = new System.Drawing.Size(61, 19);
            this.CBEnable.TabIndex = 6;
            this.CBEnable.Text = "Enable";
            this.CBEnable.UseVisualStyleBackColor = true;
            // 
            // BEAdd
            // 
            this.BEAdd.Location = new System.Drawing.Point(28, 474);
            this.BEAdd.Name = "BEAdd";
            this.BEAdd.Size = new System.Drawing.Size(286, 40);
            this.BEAdd.TabIndex = 7;
            this.BEAdd.Text = "Add";
            this.BEAdd.UseVisualStyleBackColor = true;
            this.BEAdd.Click += new System.EventHandler(this.BEAdd_Click);
            // 
            // Input_Index
            // 
            this.Input_Index.Location = new System.Drawing.Point(74, 87);
            this.Input_Index.Name = "Input_Index";
            this.Input_Index.Size = new System.Drawing.Size(54, 23);
            this.Input_Index.TabIndex = 12;
            this.Input_Index.Visible = false;
            // 
            // BSearch
            // 
            this.BSearch.Location = new System.Drawing.Point(152, 87);
            this.BSearch.Name = "BSearch";
            this.BSearch.Size = new System.Drawing.Size(78, 23);
            this.BSearch.TabIndex = 13;
            this.BSearch.Text = "S e a r c h";
            this.BSearch.UseVisualStyleBackColor = true;
            this.BSearch.Visible = false;
            this.BSearch.Click += new System.EventHandler(this.BSearch_Click);
            // 
            // groupEdit
            // 
            this.groupEdit.Controls.Add(this.label4);
            this.groupEdit.Controls.Add(this.CBPlatform);
            this.groupEdit.Controls.Add(this.label3);
            this.groupEdit.Controls.Add(this.InputGN);
            this.groupEdit.Controls.Add(this.BCancel);
            this.groupEdit.Controls.Add(this.LB_Index);
            this.groupEdit.Controls.Add(this.BSearch);
            this.groupEdit.Controls.Add(this.input_Desc);
            this.groupEdit.Controls.Add(this.Input_Index);
            this.groupEdit.Controls.Add(this.label1);
            this.groupEdit.Controls.Add(this.BEAdd);
            this.groupEdit.Controls.Add(this.InputCode);
            this.groupEdit.Controls.Add(this.CBEnable);
            this.groupEdit.Controls.Add(this.label2);
            this.groupEdit.Location = new System.Drawing.Point(18, 112);
            this.groupEdit.Name = "groupEdit";
            this.groupEdit.Size = new System.Drawing.Size(341, 574);
            this.groupEdit.TabIndex = 9;
            this.groupEdit.TabStop = false;
            this.groupEdit.Text = "Edit Box";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Platform:";
            // 
            // CBPlatform
            // 
            this.CBPlatform.FormattingEnabled = true;
            this.CBPlatform.Items.AddRange(new object[] {
            "SNES",
            "NES",
            "GBA",
            "PSX"});
            this.CBPlatform.Location = new System.Drawing.Point(29, 44);
            this.CBPlatform.Name = "CBPlatform";
            this.CBPlatform.Size = new System.Drawing.Size(285, 23);
            this.CBPlatform.TabIndex = 2;
            this.CBPlatform.Text = "SNES";
            this.CBPlatform.SelectedIndexChanged += new System.EventHandler(this.CBPlatform_SelectionChangeCommitted);
            this.CBPlatform.SelectionChangeCommitted += new System.EventHandler(this.CBPlatform_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Game Name:";
            // 
            // InputGN
            // 
            this.InputGN.Location = new System.Drawing.Point(28, 165);
            this.InputGN.Name = "InputGN";
            this.InputGN.Size = new System.Drawing.Size(286, 23);
            this.InputGN.TabIndex = 3;
            // 
            // BCancel
            // 
            this.BCancel.Location = new System.Drawing.Point(236, 86);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(78, 23);
            this.BCancel.TabIndex = 14;
            this.BCancel.Text = "Cancel";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Visible = false;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // InputFile
            // 
            this.InputFile.Location = new System.Drawing.Point(6, 22);
            this.InputFile.Name = "InputFile";
            this.InputFile.Size = new System.Drawing.Size(560, 412);
            this.InputFile.TabIndex = 8;
            this.InputFile.Text = "";
            // 
            // GBView
            // 
            this.GBView.Controls.Add(this.LStatus);
            this.GBView.Controls.Add(this.BLoad);
            this.GBView.Controls.Add(this.BOSave);
            this.GBView.Controls.Add(this.InputFile);
            this.GBView.Location = new System.Drawing.Point(373, 112);
            this.GBView.Name = "GBView";
            this.GBView.Size = new System.Drawing.Size(572, 574);
            this.GBView.TabIndex = 11;
            this.GBView.TabStop = false;
            this.GBView.Text = "OutPut";
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = true;
            this.LStatus.Location = new System.Drawing.Point(6, 441);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(45, 15);
            this.LStatus.TabIndex = 15;
            this.LStatus.Text = "NOTES:";
            // 
            // BLoad
            // 
            this.BLoad.Location = new System.Drawing.Point(6, 474);
            this.BLoad.Name = "BLoad";
            this.BLoad.Size = new System.Drawing.Size(560, 40);
            this.BLoad.TabIndex = 10;
            this.BLoad.Text = "Import Cht File";
            this.BLoad.UseVisualStyleBackColor = true;
            this.BLoad.Click += new System.EventHandler(this.BLoad_Click);
            // 
            // BOSave
            // 
            this.BOSave.Location = new System.Drawing.Point(6, 520);
            this.BOSave.Name = "BOSave";
            this.BOSave.Size = new System.Drawing.Size(560, 40);
            this.BOSave.TabIndex = 11;
            this.BOSave.Text = "Save";
            this.BOSave.UseVisualStyleBackColor = true;
            this.BOSave.Click += new System.EventHandler(this.BOSave_Click);
            // 
            // GBUpload
            // 
            this.GBUpload.Controls.Add(this.BBrowse);
            this.GBUpload.Controls.Add(this.InputBrowse);
            this.GBUpload.Location = new System.Drawing.Point(12, 12);
            this.GBUpload.Name = "GBUpload";
            this.GBUpload.Size = new System.Drawing.Size(927, 83);
            this.GBUpload.TabIndex = 12;
            this.GBUpload.TabStop = false;
            this.GBUpload.Text = "Import Ini";
            // 
            // BBrowse
            // 
            this.BBrowse.Location = new System.Drawing.Point(776, 32);
            this.BBrowse.Name = "BBrowse";
            this.BBrowse.Size = new System.Drawing.Size(145, 23);
            this.BBrowse.TabIndex = 1;
            this.BBrowse.Text = "B r o w s e";
            this.BBrowse.UseVisualStyleBackColor = true;
            this.BBrowse.Click += new System.EventHandler(this.BBrowse_Click);
            // 
            // InputBrowse
            // 
            this.InputBrowse.Location = new System.Drawing.Point(6, 32);
            this.InputBrowse.Name = "InputBrowse";
            this.InputBrowse.Size = new System.Drawing.Size(764, 23);
            this.InputBrowse.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 701);
            this.Controls.Add(this.GBUpload);
            this.Controls.Add(this.GBView);
            this.Controls.Add(this.groupEdit);
            this.Name = "Form1";
            this.Text = "Retoarch CHT Builder";
            this.groupEdit.ResumeLayout(false);
            this.groupEdit.PerformLayout();
            this.GBView.ResumeLayout(false);
            this.GBView.PerformLayout();
            this.GBUpload.ResumeLayout(false);
            this.GBUpload.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox input_Desc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_Index;
        private System.Windows.Forms.TextBox InputCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CBEnable;
        private System.Windows.Forms.Button BEAdd;
        private System.Windows.Forms.TextBox Input_Index;
        private System.Windows.Forms.Button BSearch;
        private System.Windows.Forms.GroupBox groupEdit;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.RichTextBox InputFile;
        private System.Windows.Forms.GroupBox GBView;
        private System.Windows.Forms.Button BOUpdate;
        private System.Windows.Forms.Button BOSave;
        private System.Windows.Forms.GroupBox GBUpload;
        private System.Windows.Forms.Button BBrowse;
        private System.Windows.Forms.TextBox InputBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputGN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBPlatform;
        private System.Windows.Forms.Button BLoad;
        private System.Windows.Forms.Label LStatus;
    }
}

