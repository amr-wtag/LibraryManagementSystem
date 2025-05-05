namespace LibraryManagementSystem.Winforms.Forms.BookReservation
{
    partial class AddReservationForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            userDropdownControl = new LibraryManagementSystem.Winforms.component.CustomDropdown();
            userLabel = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            bookLabel = new Label();
            dueDateLabel = new Label();
            addReservation = new Button();
            bookReservationPanel = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = SystemColors.ControlDark;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(bookReservationPanel, 0, 3);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2, 1, 2, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 352F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(765, 467);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(2, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(761, 23);
            label1.TabIndex = 0;
            label1.Text = "Add Reservation Form";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.7417641F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.2582359F));
            tableLayoutPanel2.Controls.Add(userDropdownControl, 1, 0);
            tableLayoutPanel2.Controls.Add(userLabel, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 26);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(759, 25);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // userDropdownControl
            // 
            userDropdownControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            userDropdownControl.Location = new Point(334, 1);
            userDropdownControl.Margin = new Padding(2, 1, 2, 1);
            userDropdownControl.Name = "userDropdownControl";
            userDropdownControl.Size = new Size(140, 23);
            userDropdownControl.TabIndex = 1;
            // 
            // userLabel
            // 
            userLabel.Anchor = AnchorStyles.Right;
            userLabel.AutoSize = true;
            userLabel.BackColor = SystemColors.Control;
            userLabel.Location = new Point(299, 5);
            userLabel.Margin = new Padding(0);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(33, 15);
            userLabel.TabIndex = 2;
            userLabel.Text = "User:";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.768856F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.231144F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 347F));
            tableLayoutPanel3.Controls.Add(bookLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(dueDateLabel, 1, 0);
            tableLayoutPanel3.Controls.Add(addReservation, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 57);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(759, 35);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // bookLabel
            // 
            bookLabel.AutoSize = true;
            bookLabel.Dock = DockStyle.Fill;
            bookLabel.Location = new Point(3, 0);
            bookLabel.Name = "bookLabel";
            bookLabel.Size = new Size(178, 35);
            bookLabel.TabIndex = 0;
            bookLabel.Text = "Book";
            bookLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Dock = DockStyle.Fill;
            dueDateLabel.Location = new Point(187, 0);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new Size(221, 35);
            dueDateLabel.TabIndex = 1;
            dueDateLabel.Text = "Due Date";
            dueDateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addReservation
            // 
            addReservation.Location = new Point(414, 3);
            addReservation.Name = "addReservation";
            addReservation.Size = new Size(113, 29);
            addReservation.TabIndex = 2;
            addReservation.Text = "AddReservation";
            addReservation.UseVisualStyleBackColor = true;
            addReservation.Click += addReservation_Click;
            // 
            // bookReservationPanel
            // 
            bookReservationPanel = new FlowLayoutPanel();
            bookReservationPanel.FlowDirection = FlowDirection.TopDown;
            bookReservationPanel.AutoScroll = true;
            bookReservationPanel.WrapContents = false;
            bookReservationPanel.Dock = DockStyle.Fill;
            // 
            // AddReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 467);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "AddReservationForm";
            Text = "AddReservationForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private component.CustomDropdown userDropdownControl;
        private TableLayoutPanel tableLayoutPanel2;
        private Label userLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private Label bookLabel;
        private Label dueDateLabel;
        private Button addReservation;
        private FlowLayoutPanel bookReservationPanel;
    }
}
