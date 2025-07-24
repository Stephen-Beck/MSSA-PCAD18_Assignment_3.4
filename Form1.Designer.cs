namespace Assignment_3._4
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            coffeeBindingSource = new BindingSource(components);
            coffeeRoastDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isDecafDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            typeOfCoffeeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            beverageIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            beverageContainerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            manufacturerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sizeInOzDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            flavorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            temperatureInFDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coffeeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { coffeeRoastDataGridViewTextBoxColumn, isDecafDataGridViewCheckBoxColumn, typeOfCoffeeDataGridViewTextBoxColumn, beverageIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, expDateDataGridViewTextBoxColumn, beverageContainerDataGridViewTextBoxColumn, manufacturerDataGridViewTextBoxColumn, sizeInOzDataGridViewTextBoxColumn, flavorDataGridViewTextBoxColumn, temperatureInFDataGridViewTextBoxColumn });
            dataGridView1.DataSource = coffeeBindingSource;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 426);
            dataGridView1.TabIndex = 0;
            // 
            // coffeeBindingSource
            // 
            coffeeBindingSource.DataSource = typeof(Coffee);
            // 
            // coffeeRoastDataGridViewTextBoxColumn
            // 
            coffeeRoastDataGridViewTextBoxColumn.DataPropertyName = "CoffeeRoast";
            coffeeRoastDataGridViewTextBoxColumn.HeaderText = "CoffeeRoast";
            coffeeRoastDataGridViewTextBoxColumn.Name = "coffeeRoastDataGridViewTextBoxColumn";
            // 
            // isDecafDataGridViewCheckBoxColumn
            // 
            isDecafDataGridViewCheckBoxColumn.DataPropertyName = "IsDecaf";
            isDecafDataGridViewCheckBoxColumn.HeaderText = "IsDecaf";
            isDecafDataGridViewCheckBoxColumn.Name = "isDecafDataGridViewCheckBoxColumn";
            // 
            // typeOfCoffeeDataGridViewTextBoxColumn
            // 
            typeOfCoffeeDataGridViewTextBoxColumn.DataPropertyName = "TypeOfCoffee";
            typeOfCoffeeDataGridViewTextBoxColumn.HeaderText = "TypeOfCoffee";
            typeOfCoffeeDataGridViewTextBoxColumn.Name = "typeOfCoffeeDataGridViewTextBoxColumn";
            // 
            // beverageIDDataGridViewTextBoxColumn
            // 
            beverageIDDataGridViewTextBoxColumn.DataPropertyName = "BeverageID";
            beverageIDDataGridViewTextBoxColumn.HeaderText = "BeverageID";
            beverageIDDataGridViewTextBoxColumn.Name = "beverageIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // expDateDataGridViewTextBoxColumn
            // 
            expDateDataGridViewTextBoxColumn.DataPropertyName = "ExpDate";
            expDateDataGridViewTextBoxColumn.HeaderText = "ExpDate";
            expDateDataGridViewTextBoxColumn.Name = "expDateDataGridViewTextBoxColumn";
            // 
            // beverageContainerDataGridViewTextBoxColumn
            // 
            beverageContainerDataGridViewTextBoxColumn.DataPropertyName = "BeverageContainer";
            beverageContainerDataGridViewTextBoxColumn.HeaderText = "BeverageContainer";
            beverageContainerDataGridViewTextBoxColumn.Name = "beverageContainerDataGridViewTextBoxColumn";
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            // 
            // sizeInOzDataGridViewTextBoxColumn
            // 
            sizeInOzDataGridViewTextBoxColumn.DataPropertyName = "SizeInOz";
            sizeInOzDataGridViewTextBoxColumn.HeaderText = "SizeInOz";
            sizeInOzDataGridViewTextBoxColumn.Name = "sizeInOzDataGridViewTextBoxColumn";
            // 
            // flavorDataGridViewTextBoxColumn
            // 
            flavorDataGridViewTextBoxColumn.DataPropertyName = "Flavor";
            flavorDataGridViewTextBoxColumn.HeaderText = "Flavor";
            flavorDataGridViewTextBoxColumn.Name = "flavorDataGridViewTextBoxColumn";
            // 
            // temperatureInFDataGridViewTextBoxColumn
            // 
            temperatureInFDataGridViewTextBoxColumn.DataPropertyName = "TemperatureInF";
            temperatureInFDataGridViewTextBoxColumn.HeaderText = "TemperatureInF";
            temperatureInFDataGridViewTextBoxColumn.Name = "temperatureInFDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Coffee";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)coffeeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private BindingSource coffeeBindingSource;
        private DataGridViewTextBoxColumn coffeeRoastDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isDecafDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn typeOfCoffeeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn beverageIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn beverageContainerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeInOzDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn flavorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn temperatureInFDataGridViewTextBoxColumn;
    }
}
