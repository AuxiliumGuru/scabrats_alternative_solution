namespace practice_scabrats
{
    partial class frmScabrats
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
            this.chkJava = new System.Windows.Forms.CheckBox();
            this.chkBurnt = new System.Windows.Forms.CheckBox();
            this.chkIced = new System.Windows.Forms.CheckBox();
            this.chkSalted = new System.Windows.Forms.CheckBox();
            this.chkGreen = new System.Windows.Forms.CheckBox();
            this.chkVanilla = new System.Windows.Forms.CheckBox();
            this.chkHot = new System.Windows.Forms.CheckBox();
            this.chkCream = new System.Windows.Forms.CheckBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCompleteOrder = new System.Windows.Forms.Button();
            this.numJava = new System.Windows.Forms.NumericUpDown();
            this.numBurnt = new System.Windows.Forms.NumericUpDown();
            this.numIced = new System.Windows.Forms.NumericUpDown();
            this.numVanilla = new System.Windows.Forms.NumericUpDown();
            this.numHot = new System.Windows.Forms.NumericUpDown();
            this.numSalted = new System.Windows.Forms.NumericUpDown();
            this.numCream = new System.Windows.Forms.NumericUpDown();
            this.rdoGO = new System.Windows.Forms.RadioButton();
            this.rdoHere = new System.Windows.Forms.RadioButton();
            this.chkMember = new System.Windows.Forms.CheckBox();
            this.numGreen = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numJava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBurnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIced)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVanilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkJava
            // 
            this.chkJava.AutoSize = true;
            this.chkJava.Location = new System.Drawing.Point(486, 175);
            this.chkJava.Name = "chkJava";
            this.chkJava.Size = new System.Drawing.Size(135, 17);
            this.chkJava.TabIndex = 31;
            this.chkJava.Text = "Java Chip Frappuccino";
            this.chkJava.UseVisualStyleBackColor = true;
            this.chkJava.CheckedChanged += new System.EventHandler(this.chkJava_CheckedChanged);
            // 
            // chkBurnt
            // 
            this.chkBurnt.AutoSize = true;
            this.chkBurnt.Location = new System.Drawing.Point(185, 175);
            this.chkBurnt.Name = "chkBurnt";
            this.chkBurnt.Size = new System.Drawing.Size(157, 17);
            this.chkBurnt.TabIndex = 30;
            this.chkBurnt.Text = "Burnt Caramel Oatmilk Latte";
            this.chkBurnt.UseVisualStyleBackColor = true;
            this.chkBurnt.CheckedChanged += new System.EventHandler(this.chkBurnt_CheckedChanged);
            // 
            // chkIced
            // 
            this.chkIced.AutoSize = true;
            this.chkIced.Location = new System.Drawing.Point(486, 96);
            this.chkIced.Name = "chkIced";
            this.chkIced.Size = new System.Drawing.Size(141, 17);
            this.chkIced.TabIndex = 29;
            this.chkIced.Text = "Iced Caramel Macchiato";
            this.chkIced.UseVisualStyleBackColor = true;
            this.chkIced.CheckedChanged += new System.EventHandler(this.chkIced_CheckedChanged);
            // 
            // chkSalted
            // 
            this.chkSalted.AutoSize = true;
            this.chkSalted.Location = new System.Drawing.Point(185, 98);
            this.chkSalted.Name = "chkSalted";
            this.chkSalted.Size = new System.Drawing.Size(148, 17);
            this.chkSalted.TabIndex = 28;
            this.chkSalted.Text = "Salted Caramel Cold Brew";
            this.chkSalted.UseVisualStyleBackColor = true;
            this.chkSalted.CheckedChanged += new System.EventHandler(this.chkSalted_CheckedChanged);
            // 
            // chkGreen
            // 
            this.chkGreen.AutoSize = true;
            this.chkGreen.Location = new System.Drawing.Point(486, 133);
            this.chkGreen.Name = "chkGreen";
            this.chkGreen.Size = new System.Drawing.Size(172, 17);
            this.chkGreen.TabIndex = 27;
            this.chkGreen.Text = "Green Tea Cream Frappuccino";
            this.chkGreen.UseVisualStyleBackColor = true;
            this.chkGreen.CheckedChanged += new System.EventHandler(this.chkGreen_CheckedChanged);
            // 
            // chkVanilla
            // 
            this.chkVanilla.AutoSize = true;
            this.chkVanilla.Location = new System.Drawing.Point(185, 135);
            this.chkVanilla.Name = "chkVanilla";
            this.chkVanilla.Size = new System.Drawing.Size(174, 17);
            this.chkVanilla.TabIndex = 26;
            this.chkVanilla.Text = "Vanilla Sweet Cream Cold Brew";
            this.chkVanilla.UseVisualStyleBackColor = true;
            this.chkVanilla.CheckedChanged += new System.EventHandler(this.chkVanilla_CheckedChanged);
            // 
            // chkHot
            // 
            this.chkHot.AutoSize = true;
            this.chkHot.Location = new System.Drawing.Point(486, 54);
            this.chkHot.Name = "chkHot";
            this.chkHot.Size = new System.Drawing.Size(116, 17);
            this.chkHot.TabIndex = 25;
            this.chkHot.Text = "Hot Brewed Coffee";
            this.chkHot.UseVisualStyleBackColor = true;
            this.chkHot.CheckedChanged += new System.EventHandler(this.chkHot_CheckedChanged);
            // 
            // chkCream
            // 
            this.chkCream.AutoSize = true;
            this.chkCream.Location = new System.Drawing.Point(185, 56);
            this.chkCream.Name = "chkCream";
            this.chkCream.Size = new System.Drawing.Size(129, 17);
            this.chkCream.TabIndex = 24;
            this.chkCream.Text = "Creamy Caramel Latte";
            this.chkCream.UseVisualStyleBackColor = true;
            this.chkCream.CheckedChanged += new System.EventHandler(this.chkCream_CheckedChanged);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(471, 346);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(39, 13);
            this.lblPoints.TabIndex = 23;
            this.lblPoints.Text = "Points:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(470, 308);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "Total:";
            // 
            // btnCompleteOrder
            // 
            this.btnCompleteOrder.Location = new System.Drawing.Point(470, 248);
            this.btnCompleteOrder.Name = "btnCompleteOrder";
            this.btnCompleteOrder.Size = new System.Drawing.Size(180, 36);
            this.btnCompleteOrder.TabIndex = 21;
            this.btnCompleteOrder.Text = "Complete Order";
            this.btnCompleteOrder.UseVisualStyleBackColor = true;
            this.btnCompleteOrder.Click += new System.EventHandler(this.btnCompleteOrder_Click);
            // 
            // numJava
            // 
            this.numJava.Location = new System.Drawing.Point(447, 172);
            this.numJava.Name = "numJava";
            this.numJava.Size = new System.Drawing.Size(33, 20);
            this.numJava.TabIndex = 20;
            this.numJava.ValueChanged += new System.EventHandler(this.numJava_ValueChanged);
            // 
            // numBurnt
            // 
            this.numBurnt.Location = new System.Drawing.Point(143, 172);
            this.numBurnt.Name = "numBurnt";
            this.numBurnt.Size = new System.Drawing.Size(33, 20);
            this.numBurnt.TabIndex = 19;
            this.numBurnt.ValueChanged += new System.EventHandler(this.numBurnt_ValueChanged);
            // 
            // numIced
            // 
            this.numIced.Location = new System.Drawing.Point(447, 93);
            this.numIced.Name = "numIced";
            this.numIced.Size = new System.Drawing.Size(33, 20);
            this.numIced.TabIndex = 18;
            this.numIced.ValueChanged += new System.EventHandler(this.numIced_ValueChanged);
            // 
            // numVanilla
            // 
            this.numVanilla.Location = new System.Drawing.Point(143, 133);
            this.numVanilla.Name = "numVanilla";
            this.numVanilla.Size = new System.Drawing.Size(33, 20);
            this.numVanilla.TabIndex = 15;
            this.numVanilla.ValueChanged += new System.EventHandler(this.numVanilla_ValueChanged);
            // 
            // numHot
            // 
            this.numHot.Location = new System.Drawing.Point(447, 54);
            this.numHot.Name = "numHot";
            this.numHot.Size = new System.Drawing.Size(33, 20);
            this.numHot.TabIndex = 14;
            this.numHot.ValueChanged += new System.EventHandler(this.numHot_ValueChanged);
            // 
            // numSalted
            // 
            this.numSalted.Location = new System.Drawing.Point(143, 93);
            this.numSalted.Name = "numSalted";
            this.numSalted.Size = new System.Drawing.Size(33, 20);
            this.numSalted.TabIndex = 17;
            this.numSalted.ValueChanged += new System.EventHandler(this.numSalted_ValueChanged);
            // 
            // numCream
            // 
            this.numCream.Location = new System.Drawing.Point(143, 54);
            this.numCream.Name = "numCream";
            this.numCream.Size = new System.Drawing.Size(33, 20);
            this.numCream.TabIndex = 13;
            this.numCream.ValueChanged += new System.EventHandler(this.numCream_ValueChanged);
            // 
            // rdoGO
            // 
            this.rdoGO.AutoSize = true;
            this.rdoGO.Location = new System.Drawing.Point(25, 98);
            this.rdoGO.Name = "rdoGO";
            this.rdoGO.Size = new System.Drawing.Size(53, 17);
            this.rdoGO.TabIndex = 2;
            this.rdoGO.TabStop = true;
            this.rdoGO.Text = "To go";
            this.rdoGO.UseVisualStyleBackColor = true;
            // 
            // rdoHere
            // 
            this.rdoHere.AutoSize = true;
            this.rdoHere.Location = new System.Drawing.Point(25, 75);
            this.rdoHere.Name = "rdoHere";
            this.rdoHere.Size = new System.Drawing.Size(64, 17);
            this.rdoHere.TabIndex = 1;
            this.rdoHere.TabStop = true;
            this.rdoHere.Text = "For here";
            this.rdoHere.UseVisualStyleBackColor = true;
            // 
            // chkMember
            // 
            this.chkMember.AutoSize = true;
            this.chkMember.Location = new System.Drawing.Point(25, 30);
            this.chkMember.Name = "chkMember";
            this.chkMember.Size = new System.Drawing.Size(64, 17);
            this.chkMember.TabIndex = 0;
            this.chkMember.Text = "Member";
            this.chkMember.UseVisualStyleBackColor = true;
            // 
            // numGreen
            // 
            this.numGreen.Location = new System.Drawing.Point(447, 133);
            this.numGreen.Name = "numGreen";
            this.numGreen.Size = new System.Drawing.Size(33, 20);
            this.numGreen.TabIndex = 16;
            this.numGreen.ValueChanged += new System.EventHandler(this.numGreen_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoGO);
            this.groupBox1.Controls.Add(this.rdoHere);
            this.groupBox1.Controls.Add(this.chkMember);
            this.groupBox1.Location = new System.Drawing.Point(160, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 148);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Membership Dining";
            // 
            // frmScabrats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkJava);
            this.Controls.Add(this.chkBurnt);
            this.Controls.Add(this.chkIced);
            this.Controls.Add(this.chkSalted);
            this.Controls.Add(this.chkGreen);
            this.Controls.Add(this.chkVanilla);
            this.Controls.Add(this.chkHot);
            this.Controls.Add(this.chkCream);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCompleteOrder);
            this.Controls.Add(this.numJava);
            this.Controls.Add(this.numBurnt);
            this.Controls.Add(this.numIced);
            this.Controls.Add(this.numVanilla);
            this.Controls.Add(this.numHot);
            this.Controls.Add(this.numSalted);
            this.Controls.Add(this.numCream);
            this.Controls.Add(this.numGreen);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmScabrats";
            this.Text = "Scabrats Coffee";
            this.Load += new System.EventHandler(this.frmScabrats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numJava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBurnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIced)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVanilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCream)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkJava;
        private System.Windows.Forms.CheckBox chkBurnt;
        private System.Windows.Forms.CheckBox chkIced;
        private System.Windows.Forms.CheckBox chkSalted;
        private System.Windows.Forms.CheckBox chkGreen;
        private System.Windows.Forms.CheckBox chkVanilla;
        private System.Windows.Forms.CheckBox chkHot;
        private System.Windows.Forms.CheckBox chkCream;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCompleteOrder;
        private System.Windows.Forms.NumericUpDown numJava;
        private System.Windows.Forms.NumericUpDown numBurnt;
        private System.Windows.Forms.NumericUpDown numIced;
        private System.Windows.Forms.NumericUpDown numVanilla;
        private System.Windows.Forms.NumericUpDown numHot;
        private System.Windows.Forms.NumericUpDown numSalted;
        private System.Windows.Forms.NumericUpDown numCream;
        private System.Windows.Forms.RadioButton rdoGO;
        private System.Windows.Forms.RadioButton rdoHere;
        private System.Windows.Forms.CheckBox chkMember;
        private System.Windows.Forms.NumericUpDown numGreen;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

