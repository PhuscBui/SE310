namespace Week1.Presentation
{
    partial class AnimalManager
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
            AnimalDataGridView = new DataGridView();
            OpenAnimalDetailBtn = new Button();
            SpeakBtn = new Button();
            BornBtn = new Button();
            ProduceMilkBtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)AnimalDataGridView).BeginInit();
            SuspendLayout();
            // 
            // AnimalDataGridView
            // 
            AnimalDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AnimalDataGridView.Location = new Point(21, 89);
            AnimalDataGridView.Name = "AnimalDataGridView";
            AnimalDataGridView.RowHeadersWidth = 51;
            AnimalDataGridView.Size = new Size(458, 209);
            AnimalDataGridView.TabIndex = 0;
            AnimalDataGridView.CellContentClick += AnimalDataGridView_CellContentClick;
            // 
            // OpenAnimalDetailBtn
            // 
            OpenAnimalDetailBtn.Location = new Point(485, 89);
            OpenAnimalDetailBtn.Name = "OpenAnimalDetailBtn";
            OpenAnimalDetailBtn.Size = new Size(112, 44);
            OpenAnimalDetailBtn.TabIndex = 1;
            OpenAnimalDetailBtn.Text = "Add Animals";
            OpenAnimalDetailBtn.UseVisualStyleBackColor = true;
            OpenAnimalDetailBtn.Click += OpenAnimalDetailBtn_Click;
            // 
            // SpeakBtn
            // 
            SpeakBtn.Location = new Point(485, 139);
            SpeakBtn.Name = "SpeakBtn";
            SpeakBtn.Size = new Size(112, 44);
            SpeakBtn.TabIndex = 2;
            SpeakBtn.Text = "Speak";
            SpeakBtn.UseVisualStyleBackColor = true;
            SpeakBtn.Click += SpeakBtn_Click;
            // 
            // BornBtn
            // 
            BornBtn.Location = new Point(485, 189);
            BornBtn.Name = "BornBtn";
            BornBtn.Size = new Size(112, 44);
            BornBtn.TabIndex = 4;
            BornBtn.Text = "Born";
            BornBtn.UseVisualStyleBackColor = true;
            BornBtn.Click += BornBtn_Click;
            // 
            // ProduceMilkBtn
            // 
            ProduceMilkBtn.Location = new Point(485, 239);
            ProduceMilkBtn.Name = "ProduceMilkBtn";
            ProduceMilkBtn.Size = new Size(112, 44);
            ProduceMilkBtn.TabIndex = 5;
            ProduceMilkBtn.Text = "Produce Milk";
            ProduceMilkBtn.UseVisualStyleBackColor = true;
            ProduceMilkBtn.Click += ProduceMilkBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 26);
            label1.Name = "label1";
            label1.Size = new Size(266, 46);
            label1.TabIndex = 6;
            label1.Text = "Animal Manager";
            // 
            // AnimalManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 328);
            Controls.Add(label1);
            Controls.Add(ProduceMilkBtn);
            Controls.Add(BornBtn);
            Controls.Add(SpeakBtn);
            Controls.Add(OpenAnimalDetailBtn);
            Controls.Add(AnimalDataGridView);
            Name = "AnimalManager";
            Text = "AnimalManager";
            Load += AnimalManager_Load;
            ((System.ComponentModel.ISupportInitialize)AnimalDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView AnimalDataGridView;
        private Button OpenAnimalDetailBtn;
        private Button SpeakBtn;
        private Button BornBtn;
        private Button ProduceMilkBtn;
        private Label label1;
    }
}