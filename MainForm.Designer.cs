namespace EditExcel
{
    partial class MainForm
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
            TxB_ExcelFilePath = new TextBox();
            Lbl_ExcelFilePath = new Label();
            Btn_ExcelFileChoose = new Button();
            Btn_Action = new Button();
            SuspendLayout();
            // 
            // TxB_ExcelFilePath
            // 
            TxB_ExcelFilePath.Font = new Font("Yu Gothic UI", 12F);
            TxB_ExcelFilePath.Location = new Point(10, 45);
            TxB_ExcelFilePath.Margin = new Padding(4, 4, 4, 4);
            TxB_ExcelFilePath.Name = "TxB_ExcelFilePath";
            TxB_ExcelFilePath.Size = new Size(775, 29);
            TxB_ExcelFilePath.TabIndex = 0;
            // 
            // Lbl_ExcelFilePath
            // 
            Lbl_ExcelFilePath.AutoSize = true;
            Lbl_ExcelFilePath.Font = new Font("Yu Gothic UI", 12F);
            Lbl_ExcelFilePath.Location = new Point(10, 10);
            Lbl_ExcelFilePath.Margin = new Padding(4, 0, 4, 0);
            Lbl_ExcelFilePath.Name = "Lbl_ExcelFilePath";
            Lbl_ExcelFilePath.Size = new Size(107, 21);
            Lbl_ExcelFilePath.TabIndex = 1;
            Lbl_ExcelFilePath.Text = "Excel File Path";
            // 
            // Btn_ExcelFileChoose
            // 
            Btn_ExcelFileChoose.Font = new Font("Yu Gothic UI", 12F);
            Btn_ExcelFileChoose.Location = new Point(790, 45);
            Btn_ExcelFileChoose.Margin = new Padding(4, 4, 4, 4);
            Btn_ExcelFileChoose.Name = "Btn_ExcelFileChoose";
            Btn_ExcelFileChoose.Size = new Size(80, 29);
            Btn_ExcelFileChoose.TabIndex = 2;
            Btn_ExcelFileChoose.Text = "・・・";
            Btn_ExcelFileChoose.UseVisualStyleBackColor = true;
            // 
            // Btn_Action
            // 
            Btn_Action.Location = new Point(795, 120);
            Btn_Action.Name = "Btn_Action";
            Btn_Action.Size = new Size(80, 29);
            Btn_Action.TabIndex = 3;
            Btn_Action.Text = "Action";
            Btn_Action.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 161);
            Controls.Add(Btn_Action);
            Controls.Add(Btn_ExcelFileChoose);
            Controls.Add(Lbl_ExcelFilePath);
            Controls.Add(TxB_ExcelFilePath);
            Font = new Font("Yu Gothic UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MainForm";
            Text = "ExcelTest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxB_ExcelFilePath;
        private Label Lbl_ExcelFilePath;
        private Button Btn_ExcelFileChoose;
        private Button Btn_Action;
    }
}
