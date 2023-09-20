namespace Crud_Produto
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
            inputName = new TextBox();
            InputQuantity = new TextBox();
            InputPrice = new TextBox();
            label2 = new Label();
            textLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            InputDescription = new RichTextBox();
            Add = new Button();
            Update = new Button();
            Delete = new Button();
            ProductsDetails = new DataGridView();
            button2 = new Button();
            InputId = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductsDetails).BeginInit();
            SuspendLayout();
            // 
            // inputName
            // 
            inputName.Location = new Point(192, 144);
            inputName.Name = "inputName";
            inputName.Size = new Size(170, 23);
            inputName.TabIndex = 0;
            // 
            // InputQuantity
            // 
            InputQuantity.Location = new Point(192, 184);
            InputQuantity.Name = "InputQuantity";
            InputQuantity.Size = new Size(100, 23);
            InputQuantity.TabIndex = 1;
            InputQuantity.TextChanged += textBox2_TextChanged;
            // 
            // InputPrice
            // 
            InputPrice.Location = new Point(192, 225);
            InputPrice.Name = "InputPrice";
            InputPrice.Size = new Size(100, 23);
            InputPrice.TabIndex = 2;
            InputPrice.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(72, 144);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 4;
            label2.Text = "Name";
            label2.Click += label1_Click;
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textLabel.Location = new Point(72, 186);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(70, 21);
            textLabel.TabIndex = 5;
            textLabel.Text = "Quantity";
            textLabel.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(72, 225);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 6;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(72, 263);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 7;
            label4.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(272, 18);
            label5.Name = "label5";
            label5.Size = new Size(192, 30);
            label5.TabIndex = 8;
            label5.Text = "Listagem Produtos";
            label5.Click += label5_Click;
            // 
            // InputDescription
            // 
            InputDescription.Location = new Point(192, 263);
            InputDescription.Name = "InputDescription";
            InputDescription.Size = new Size(170, 96);
            InputDescription.TabIndex = 9;
            InputDescription.Text = "";
            // 
            // Add
            // 
            Add.Location = new Point(72, 388);
            Add.Name = "Add";
            Add.Size = new Size(75, 23);
            Add.TabIndex = 10;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Update
            // 
            Update.Location = new Point(177, 388);
            Update.Name = "Update";
            Update.Size = new Size(75, 23);
            Update.TabIndex = 11;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(287, 388);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 23);
            Delete.TabIndex = 12;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += button1_Click;
            // 
            // ProductsDetails
            // 
            ProductsDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDetails.Location = new Point(452, 92);
            ProductsDetails.Name = "ProductsDetails";
            ProductsDetails.RowTemplate.Height = 25;
            ProductsDetails.Size = new Size(336, 267);
            ProductsDetails.TabIndex = 13;
            ProductsDetails.RowHeaderMouseClick += ProductsDetails_RowHeaderMouseClick_1;
            // 
            // button2
            // 
            button2.Location = new Point(135, 417);
            button2.Name = "button2";
            button2.Size = new Size(167, 23);
            button2.TabIndex = 14;
            button2.Text = "Clear Inputs";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // InputId
            // 
            InputId.Location = new Point(192, 108);
            InputId.Name = "InputId";
            InputId.Size = new Size(100, 23);
            InputId.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(72, 106);
            label6.Name = "label6";
            label6.Size = new Size(81, 21);
            label6.TabIndex = 17;
            label6.Text = "Id Product";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(InputId);
            Controls.Add(button2);
            Controls.Add(ProductsDetails);
            Controls.Add(Delete);
            Controls.Add(Update);
            Controls.Add(Add);
            Controls.Add(InputDescription);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textLabel);
            Controls.Add(label2);
            Controls.Add(InputPrice);
            Controls.Add(InputQuantity);
            Controls.Add(inputName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ProductsDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputName;
        private TextBox InputQuantity;
        private TextBox InputPrice;
        private Label label2;
        private Label textLabel;
        private Label label3;
        private Label label4;
        private Label label5;
        private RichTextBox InputDescription;
        private Button Add;
        private Button Update;
        private Button Delete;
        private DataGridView dataGridView1;
        private Button button2;
        private DataGridView ProductsDetails;
        private TextBox InputId;
        private Label label6;
    }
}