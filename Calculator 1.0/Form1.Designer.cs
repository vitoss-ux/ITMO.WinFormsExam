
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.butDel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butC = new System.Windows.Forms.Button();
            this.butSymbol = new System.Windows.Forms.Button();
            this.but8 = new System.Windows.Forms.Button();
            this.butPlus = new System.Windows.Forms.Button();
            this.but9 = new System.Windows.Forms.Button();
            this.but7 = new System.Windows.Forms.Button();
            this.but4 = new System.Windows.Forms.Button();
            this.butMinus = new System.Windows.Forms.Button();
            this.but6 = new System.Windows.Forms.Button();
            this.but5 = new System.Windows.Forms.Button();
            this.but1 = new System.Windows.Forms.Button();
            this.butMultiply = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.butDot = new System.Windows.Forms.Button();
            this.butDevide = new System.Windows.Forms.Button();
            this.butEqual = new System.Windows.Forms.Button();
            this.but0 = new System.Windows.Forms.Button();
            this.butExp = new System.Windows.Forms.Button();
            this.butSqrt = new System.Windows.Forms.Button();
            this.butRevNum = new System.Windows.Forms.Button();
            this.butSquareNum = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisplay.Font = new System.Drawing.Font("Calibri", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 55);
            this.txtDisplay.MaxLength = 15;
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(900, 97);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDisplay_KeyPress);
            // 
            // butDel
            // 
            this.butDel.BackColor = System.Drawing.Color.Gray;
            this.butDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butDel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.butDel.Location = new System.Drawing.Point(12, 158);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(135, 134);
            this.butDel.TabIndex = 1;
            this.butDel.Text = "⌫";
            this.toolTip1.SetToolTip(this.butDel, "Backspace");
            this.butDel.UseVisualStyleBackColor = false;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 42);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standartToolStripMenuItem,
            this.scientificToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // standartToolStripMenuItem
            // 
            this.standartToolStripMenuItem.Name = "standartToolStripMenuItem";
            this.standartToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.standartToolStripMenuItem.Text = "Standart";
            this.standartToolStripMenuItem.Click += new System.EventHandler(this.standartToolStripMenuItem_Click);
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.scientificToolStripMenuItem.Text = "Scientific";
            this.scientificToolStripMenuItem.Click += new System.EventHandler(this.scientificToolStripMenuItem_Click);
            // 
            // butC
            // 
            this.butC.BackColor = System.Drawing.Color.Gray;
            this.butC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butC.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butC.ForeColor = System.Drawing.SystemColors.Window;
            this.butC.Location = new System.Drawing.Point(153, 158);
            this.butC.Name = "butC";
            this.butC.Size = new System.Drawing.Size(135, 134);
            this.butC.TabIndex = 4;
            this.butC.Text = "C";
            this.toolTip1.SetToolTip(this.butC, "Clear");
            this.butC.UseVisualStyleBackColor = false;
            this.butC.Click += new System.EventHandler(this.butC_Click);
            // 
            // butSymbol
            // 
            this.butSymbol.BackColor = System.Drawing.Color.Gray;
            this.butSymbol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSymbol.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.butSymbol.Location = new System.Drawing.Point(294, 158);
            this.butSymbol.Name = "butSymbol";
            this.butSymbol.Size = new System.Drawing.Size(135, 134);
            this.butSymbol.TabIndex = 5;
            this.butSymbol.Text = "±";
            this.toolTip1.SetToolTip(this.butSymbol, "Change symbol");
            this.butSymbol.UseVisualStyleBackColor = false;
            this.butSymbol.Click += new System.EventHandler(this.butSymbol_Click);
            // 
            // but8
            // 
            this.but8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.but8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.but8.Location = new System.Drawing.Point(153, 298);
            this.but8.Name = "but8";
            this.but8.Size = new System.Drawing.Size(135, 134);
            this.but8.TabIndex = 7;
            this.but8.Text = "8";
            this.but8.UseVisualStyleBackColor = false;
            this.but8.Click += new System.EventHandler(this.NumericValue);
            // 
            // butPlus
            // 
            this.butPlus.BackColor = System.Drawing.Color.DarkOrange;
            this.butPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butPlus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.butPlus.Location = new System.Drawing.Point(435, 578);
            this.butPlus.Name = "butPlus";
            this.butPlus.Size = new System.Drawing.Size(135, 134);
            this.butPlus.TabIndex = 9;
            this.butPlus.Text = "+";
            this.toolTip1.SetToolTip(this.butPlus, "Plus");
            this.butPlus.UseVisualStyleBackColor = false;
            this.butPlus.Click += new System.EventHandler(this.Operation_Func);
            // 
            // but9
            // 
            this.but9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.but9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.but9.Location = new System.Drawing.Point(294, 298);
            this.but9.Name = "but9";
            this.but9.Size = new System.Drawing.Size(135, 134);
            this.but9.TabIndex = 8;
            this.but9.Text = "9";
            this.but9.UseVisualStyleBackColor = false;
            this.but9.Click += new System.EventHandler(this.NumericValue);
            // 
            // but7
            // 
            this.but7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.but7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.but7.Location = new System.Drawing.Point(12, 298);
            this.but7.Name = "but7";
            this.but7.Size = new System.Drawing.Size(135, 134);
            this.but7.TabIndex = 10;
            this.but7.Text = "7";
            this.but7.UseVisualStyleBackColor = false;
            this.but7.Click += new System.EventHandler(this.NumericValue);
            // 
            // but4
            // 
            this.but4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.but4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.but4.Location = new System.Drawing.Point(12, 438);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(135, 134);
            this.but4.TabIndex = 14;
            this.but4.Text = "4";
            this.but4.UseVisualStyleBackColor = false;
            this.but4.Click += new System.EventHandler(this.NumericValue);
            // 
            // butMinus
            // 
            this.butMinus.BackColor = System.Drawing.Color.DarkOrange;
            this.butMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butMinus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.butMinus.Location = new System.Drawing.Point(435, 438);
            this.butMinus.Name = "butMinus";
            this.butMinus.Size = new System.Drawing.Size(135, 134);
            this.butMinus.TabIndex = 13;
            this.butMinus.Text = "-";
            this.toolTip1.SetToolTip(this.butMinus, "Minus");
            this.butMinus.UseVisualStyleBackColor = false;
            this.butMinus.Click += new System.EventHandler(this.Operation_Func);
            // 
            // but6
            // 
            this.but6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.but6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.but6.Location = new System.Drawing.Point(294, 438);
            this.but6.Name = "but6";
            this.but6.Size = new System.Drawing.Size(135, 134);
            this.but6.TabIndex = 12;
            this.but6.Text = "6";
            this.but6.UseVisualStyleBackColor = false;
            this.but6.Click += new System.EventHandler(this.NumericValue);
            // 
            // but5
            // 
            this.but5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.but5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.but5.Location = new System.Drawing.Point(153, 438);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(135, 134);
            this.but5.TabIndex = 11;
            this.but5.Text = "5";
            this.but5.UseVisualStyleBackColor = false;
            this.but5.Click += new System.EventHandler(this.NumericValue);
            // 
            // but1
            // 
            this.but1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.but1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.but1.Location = new System.Drawing.Point(12, 578);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(135, 134);
            this.but1.TabIndex = 18;
            this.but1.Text = "1";
            this.but1.UseVisualStyleBackColor = false;
            this.but1.Click += new System.EventHandler(this.NumericValue);
            // 
            // butMultiply
            // 
            this.butMultiply.BackColor = System.Drawing.Color.DarkOrange;
            this.butMultiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butMultiply.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.butMultiply.Location = new System.Drawing.Point(435, 298);
            this.butMultiply.Name = "butMultiply";
            this.butMultiply.Size = new System.Drawing.Size(135, 134);
            this.butMultiply.TabIndex = 17;
            this.butMultiply.Text = "*";
            this.toolTip1.SetToolTip(this.butMultiply, "Multiply");
            this.butMultiply.UseVisualStyleBackColor = false;
            this.butMultiply.Click += new System.EventHandler(this.Operation_Func);
            // 
            // but3
            // 
            this.but3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.but3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.but3.Location = new System.Drawing.Point(294, 578);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(135, 134);
            this.but3.TabIndex = 16;
            this.but3.Text = "3";
            this.but3.UseVisualStyleBackColor = false;
            this.but3.Click += new System.EventHandler(this.NumericValue);
            // 
            // but2
            // 
            this.but2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.but2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.but2.Location = new System.Drawing.Point(153, 578);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(135, 134);
            this.but2.TabIndex = 15;
            this.but2.Text = "2";
            this.but2.UseVisualStyleBackColor = false;
            this.but2.Click += new System.EventHandler(this.NumericValue);
            // 
            // butDot
            // 
            this.butDot.BackColor = System.Drawing.Color.DarkSlateGray;
            this.butDot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butDot.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.butDot.Location = new System.Drawing.Point(294, 715);
            this.butDot.Name = "butDot";
            this.butDot.Size = new System.Drawing.Size(135, 134);
            this.butDot.TabIndex = 22;
            this.butDot.Text = ".";
            this.toolTip1.SetToolTip(this.butDot, "Dot");
            this.butDot.UseVisualStyleBackColor = false;
            this.butDot.Click += new System.EventHandler(this.NumericValue);
            // 
            // butDevide
            // 
            this.butDevide.BackColor = System.Drawing.Color.DarkOrange;
            this.butDevide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butDevide.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butDevide.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.butDevide.Location = new System.Drawing.Point(435, 158);
            this.butDevide.Name = "butDevide";
            this.butDevide.Size = new System.Drawing.Size(135, 134);
            this.butDevide.TabIndex = 21;
            this.butDevide.Text = "/";
            this.toolTip1.SetToolTip(this.butDevide, "Devide");
            this.butDevide.UseVisualStyleBackColor = false;
            this.butDevide.Click += new System.EventHandler(this.Operation_Func);
            // 
            // butEqual
            // 
            this.butEqual.BackColor = System.Drawing.Color.DarkOrange;
            this.butEqual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butEqual.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.butEqual.Location = new System.Drawing.Point(435, 718);
            this.butEqual.Name = "butEqual";
            this.butEqual.Size = new System.Drawing.Size(135, 134);
            this.butEqual.TabIndex = 20;
            this.butEqual.Text = "=";
            this.toolTip1.SetToolTip(this.butEqual, "Equals");
            this.butEqual.UseVisualStyleBackColor = false;
            this.butEqual.Click += new System.EventHandler(this.butEqual_Click);
            // 
            // but0
            // 
            this.but0.BackColor = System.Drawing.Color.DarkSlateGray;
            this.but0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but0.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but0.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.but0.Location = new System.Drawing.Point(12, 718);
            this.but0.Name = "but0";
            this.but0.Size = new System.Drawing.Size(276, 134);
            this.but0.TabIndex = 19;
            this.but0.Text = "0";
            this.but0.UseVisualStyleBackColor = false;
            this.but0.Click += new System.EventHandler(this.NumericValue);
            // 
            // butExp
            // 
            this.butExp.BackColor = System.Drawing.Color.DimGray;
            this.butExp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butExp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.butExp.Location = new System.Drawing.Point(636, 158);
            this.butExp.Name = "butExp";
            this.butExp.Size = new System.Drawing.Size(135, 134);
            this.butExp.TabIndex = 23;
            this.butExp.Text = "Exp";
            this.toolTip1.SetToolTip(this.butExp, "Exponent");
            this.butExp.UseVisualStyleBackColor = false;
            this.butExp.Click += new System.EventHandler(this.butExp_Click);
            // 
            // butSqrt
            // 
            this.butSqrt.BackColor = System.Drawing.Color.DimGray;
            this.butSqrt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSqrt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.butSqrt.Location = new System.Drawing.Point(636, 298);
            this.butSqrt.Name = "butSqrt";
            this.butSqrt.Size = new System.Drawing.Size(135, 134);
            this.butSqrt.TabIndex = 24;
            this.butSqrt.Text = "√";
            this.toolTip1.SetToolTip(this.butSqrt, "Square root");
            this.butSqrt.UseVisualStyleBackColor = false;
            this.butSqrt.Click += new System.EventHandler(this.butSqrt_Click);
            // 
            // butRevNum
            // 
            this.butRevNum.BackColor = System.Drawing.Color.DimGray;
            this.butRevNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butRevNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butRevNum.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.butRevNum.Location = new System.Drawing.Point(777, 158);
            this.butRevNum.Name = "butRevNum";
            this.butRevNum.Size = new System.Drawing.Size(135, 134);
            this.butRevNum.TabIndex = 26;
            this.butRevNum.Text = "1/x";
            this.toolTip1.SetToolTip(this.butRevNum, "Inverse");
            this.butRevNum.UseVisualStyleBackColor = false;
            this.butRevNum.Click += new System.EventHandler(this.butRevNum_Click);
            // 
            // butSquareNum
            // 
            this.butSquareNum.BackColor = System.Drawing.Color.DimGray;
            this.butSquareNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSquareNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSquareNum.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.butSquareNum.Location = new System.Drawing.Point(636, 438);
            this.butSquareNum.Name = "butSquareNum";
            this.butSquareNum.Size = new System.Drawing.Size(135, 134);
            this.butSquareNum.TabIndex = 27;
            this.butSquareNum.Text = "x^2";
            this.toolTip1.SetToolTip(this.butSquareNum, "Square number");
            this.butSquareNum.UseVisualStyleBackColor = false;
            this.butSquareNum.Click += new System.EventHandler(this.butSquareNum_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(777, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 134);
            this.button1.TabIndex = 28;
            this.button1.Text = "n!";
            this.toolTip1.SetToolTip(this.button1, "Factorial");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(777, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 134);
            this.button2.TabIndex = 29;
            this.button2.Text = "∛";
            this.toolTip1.SetToolTip(this.button2, "Cubic root");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(636, 578);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(276, 270);
            this.button3.TabIndex = 30;
            this.button3.Text = "Quadratic Equation";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(917, 860);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butSquareNum);
            this.Controls.Add(this.butRevNum);
            this.Controls.Add(this.butSqrt);
            this.Controls.Add(this.butExp);
            this.Controls.Add(this.butDot);
            this.Controls.Add(this.butDevide);
            this.Controls.Add(this.butEqual);
            this.Controls.Add(this.but0);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.butMultiply);
            this.Controls.Add(this.but3);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.but4);
            this.Controls.Add(this.butMinus);
            this.Controls.Add(this.but6);
            this.Controls.Add(this.but5);
            this.Controls.Add(this.but7);
            this.Controls.Add(this.butPlus);
            this.Controls.Add(this.but9);
            this.Controls.Add(this.but8);
            this.Controls.Add(this.butSymbol);
            this.Controls.Add(this.butC);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button butC;
        private System.Windows.Forms.Button butSymbol;
        private System.Windows.Forms.Button but8;
        private System.Windows.Forms.Button butPlus;
        private System.Windows.Forms.Button but9;
        private System.Windows.Forms.Button but7;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button butMinus;
        private System.Windows.Forms.Button but6;
        private System.Windows.Forms.Button but5;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button butMultiply;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button butDot;
        private System.Windows.Forms.Button butDevide;
        private System.Windows.Forms.Button butEqual;
        private System.Windows.Forms.Button but0;
        private System.Windows.Forms.ToolStripMenuItem standartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.Button butExp;
        private System.Windows.Forms.Button butSqrt;
        private System.Windows.Forms.Button butRevNum;
        private System.Windows.Forms.Button butSquareNum;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

