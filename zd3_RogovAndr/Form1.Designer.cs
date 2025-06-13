namespace zd3_RogovAndr
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
            rbBasic = new RadioButton();
            rbService = new RadioButton();
            textProcessorName = new TextBox();
            textClockSpeed = new TextBox();
            textRamSize = new TextBox();
            textManufacturer = new TextBox();
            chkDiscrete = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textHddSize = new TextBox();
            chkSSD = new CheckBox();
            btnAdd = new Button();
            btnAddAtIndex = new Button();
            listBoxComputers = new ListBox();
            btnDeleteName = new Button();
            btnDeleteLast = new Button();
            numericUpDownIndex = new NumericUpDown();
            textSearchProcessor = new TextBox();
            btnSearchByProcessor = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIndex).BeginInit();
            SuspendLayout();
            // 
            // rbBasic
            // 
            rbBasic.AutoSize = true;
            rbBasic.Font = new Font("Segoe UI", 12F);
            rbBasic.Location = new Point(12, 42);
            rbBasic.Name = "rbBasic";
            rbBasic.Size = new Size(123, 32);
            rbBasic.TabIndex = 0;
            rbBasic.TabStop = true;
            rbBasic.Text = "Обычный";
            rbBasic.UseVisualStyleBackColor = true;
            rbBasic.CheckedChanged += rbBasic_CheckedChanged;
            // 
            // rbService
            // 
            rbService.AutoSize = true;
            rbService.Font = new Font("Segoe UI", 12F);
            rbService.Location = new Point(141, 42);
            rbService.Name = "rbService";
            rbService.Size = new Size(138, 32);
            rbService.TabIndex = 1;
            rbService.TabStop = true;
            rbService.Text = "Серверный";
            rbService.UseVisualStyleBackColor = true;
            // 
            // textProcessorName
            // 
            textProcessorName.Font = new Font("Segoe UI", 12F);
            textProcessorName.Location = new Point(12, 108);
            textProcessorName.Name = "textProcessorName";
            textProcessorName.Size = new Size(125, 34);
            textProcessorName.TabIndex = 2;
            // 
            // textClockSpeed
            // 
            textClockSpeed.Font = new Font("Segoe UI", 12F);
            textClockSpeed.Location = new Point(12, 176);
            textClockSpeed.Name = "textClockSpeed";
            textClockSpeed.Size = new Size(125, 34);
            textClockSpeed.TabIndex = 3;
            // 
            // textRamSize
            // 
            textRamSize.Font = new Font("Segoe UI", 12F);
            textRamSize.Location = new Point(12, 244);
            textRamSize.Name = "textRamSize";
            textRamSize.Size = new Size(125, 34);
            textRamSize.TabIndex = 4;
            // 
            // textManufacturer
            // 
            textManufacturer.Font = new Font("Segoe UI", 12F);
            textManufacturer.Location = new Point(12, 312);
            textManufacturer.Name = "textManufacturer";
            textManufacturer.Size = new Size(125, 34);
            textManufacturer.TabIndex = 5;
            // 
            // chkDiscrete
            // 
            chkDiscrete.AutoSize = true;
            chkDiscrete.Font = new Font("Segoe UI", 12F);
            chkDiscrete.Location = new Point(12, 380);
            chkDiscrete.Name = "chkDiscrete";
            chkDiscrete.Size = new Size(155, 32);
            chkDiscrete.TabIndex = 7;
            chkDiscrete.Text = "Присутствует";
            chkDiscrete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(165, 28);
            label1.TabIndex = 8;
            label1.Text = "Тип компьютера";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(215, 28);
            label2.TabIndex = 9;
            label2.Text = "Название процессора";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 145);
            label3.Name = "label3";
            label3.Size = new Size(166, 28);
            label3.TabIndex = 10;
            label3.Text = "Тактовая частота";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 213);
            label4.Name = "label4";
            label4.Size = new Size(274, 28);
            label4.TabIndex = 11;
            label4.Text = "Объём оперативной памяти";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 281);
            label5.Name = "label5";
            label5.Size = new Size(156, 28);
            label5.TabIndex = 12;
            label5.Text = "Производитель";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 349);
            label6.Name = "label6";
            label6.Size = new Size(288, 28);
            label6.TabIndex = 13;
            label6.Text = "Наличие дискретной графики";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(302, 46);
            label7.Name = "label7";
            label7.Size = new Size(185, 28);
            label7.TabIndex = 14;
            label7.Text = "Объём винчестера";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(302, 114);
            label8.Name = "label8";
            label8.Size = new Size(125, 28);
            label8.TabIndex = 15;
            label8.Text = "Наличие ssd";
            // 
            // textHddSize
            // 
            textHddSize.Font = new Font("Segoe UI", 12F);
            textHddSize.Location = new Point(302, 77);
            textHddSize.Name = "textHddSize";
            textHddSize.Size = new Size(125, 34);
            textHddSize.TabIndex = 16;
            // 
            // chkSSD
            // 
            chkSSD.AutoSize = true;
            chkSSD.Font = new Font("Segoe UI", 12F);
            chkSSD.Location = new Point(302, 147);
            chkSSD.Name = "chkSSD";
            chkSSD.Size = new Size(155, 32);
            chkSSD.TabIndex = 17;
            chkSSD.Text = "Присутствует";
            chkSSD.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(302, 185);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(195, 34);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnAddAtIndex
            // 
            btnAddAtIndex.Font = new Font("Segoe UI", 12F);
            btnAddAtIndex.Location = new Point(302, 225);
            btnAddAtIndex.Name = "btnAddAtIndex";
            btnAddAtIndex.Size = new Size(195, 34);
            btnAddAtIndex.TabIndex = 19;
            btnAddAtIndex.Text = "Добавить по инд.";
            btnAddAtIndex.UseVisualStyleBackColor = true;
            btnAddAtIndex.Click += btnAddAtIndex_Click;
            // 
            // listBoxComputers
            // 
            listBoxComputers.FormattingEnabled = true;
            listBoxComputers.HorizontalScrollbar = true;
            listBoxComputers.Location = new Point(511, 11);
            listBoxComputers.Name = "listBoxComputers";
            listBoxComputers.Size = new Size(738, 424);
            listBoxComputers.TabIndex = 20;
            // 
            // btnDeleteName
            // 
            btnDeleteName.Font = new Font("Segoe UI", 12F);
            btnDeleteName.Location = new Point(302, 338);
            btnDeleteName.Name = "btnDeleteName";
            btnDeleteName.Size = new Size(195, 34);
            btnDeleteName.TabIndex = 21;
            btnDeleteName.Text = "Удалить по проц";
            btnDeleteName.UseVisualStyleBackColor = true;
            btnDeleteName.Click += btnDeleteName_Click;
            // 
            // btnDeleteLast
            // 
            btnDeleteLast.Font = new Font("Segoe UI", 12F);
            btnDeleteLast.Location = new Point(302, 298);
            btnDeleteLast.Name = "btnDeleteLast";
            btnDeleteLast.Size = new Size(195, 34);
            btnDeleteLast.TabIndex = 22;
            btnDeleteLast.Text = "Удалить посл.";
            btnDeleteLast.UseVisualStyleBackColor = true;
            btnDeleteLast.Click += btnDeleteLast_Click;
            // 
            // numericUpDownIndex
            // 
            numericUpDownIndex.Location = new Point(302, 265);
            numericUpDownIndex.Name = "numericUpDownIndex";
            numericUpDownIndex.Size = new Size(195, 27);
            numericUpDownIndex.TabIndex = 23;
            // 
            // textSearchProcessor
            // 
            textSearchProcessor.Font = new Font("Segoe UI", 12F);
            textSearchProcessor.Location = new Point(302, 378);
            textSearchProcessor.Name = "textSearchProcessor";
            textSearchProcessor.Size = new Size(195, 34);
            textSearchProcessor.TabIndex = 24;
            // 
            // btnSearchByProcessor
            // 
            btnSearchByProcessor.Font = new Font("Segoe UI", 12F);
            btnSearchByProcessor.Location = new Point(302, 418);
            btnSearchByProcessor.Name = "btnSearchByProcessor";
            btnSearchByProcessor.Size = new Size(195, 34);
            btnSearchByProcessor.TabIndex = 25;
            btnSearchByProcessor.Text = "Поиск по проц.";
            btnSearchByProcessor.UseVisualStyleBackColor = true;
            btnSearchByProcessor.Click += btnSearchByProcessor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 467);
            Controls.Add(btnSearchByProcessor);
            Controls.Add(textSearchProcessor);
            Controls.Add(numericUpDownIndex);
            Controls.Add(btnDeleteLast);
            Controls.Add(btnDeleteName);
            Controls.Add(listBoxComputers);
            Controls.Add(btnAddAtIndex);
            Controls.Add(btnAdd);
            Controls.Add(chkSSD);
            Controls.Add(textHddSize);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkDiscrete);
            Controls.Add(textManufacturer);
            Controls.Add(textRamSize);
            Controls.Add(textClockSpeed);
            Controls.Add(textProcessorName);
            Controls.Add(rbService);
            Controls.Add(rbBasic);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownIndex).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbBasic;
        private RadioButton rbService;
        private TextBox textProcessorName;
        private TextBox textClockSpeed;
        private TextBox textRamSize;
        private TextBox textManufacturer;
        private CheckBox chkDiscrete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textHddSize;
        private CheckBox chkSSD;
        private Button btnAdd;
        private Button btnAddAtIndex;
        private ListBox listBoxComputers;
        private Button btnDeleteName;
        private Button btnDeleteLast;
        private NumericUpDown numericUpDownIndex;
        private TextBox textSearchProcessor;
        private Button btnSearchByProcessor;

    }
}
