namespace QueuevsStack
{
    partial class Form1
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
            this.Queue = new System.Windows.Forms.GroupBox();
            this.txtQueueInput = new System.Windows.Forms.TextBox();
            this.btnPeek = new System.Windows.Forms.Button();
            this.btnDequeue = new System.Windows.Forms.Button();
            this.btnEnqueue = new System.Windows.Forms.Button();
            this.rtbQueue = new System.Windows.Forms.RichTextBox();
            this.rtbStack = new System.Windows.Forms.RichTextBox();
            this.grou = new System.Windows.Forms.GroupBox();
            this.txtStackInput = new System.Windows.Forms.TextBox();
            this.BtnPeekStack = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnPush = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.Queue.SuspendLayout();
            this.grou.SuspendLayout();
            this.SuspendLayout();
            // 
            // Queue
            // 
            this.Queue.Controls.Add(this.txtQueueInput);
            this.Queue.Controls.Add(this.btnPeek);
            this.Queue.Controls.Add(this.btnDequeue);
            this.Queue.Controls.Add(this.btnEnqueue);
            this.Queue.Controls.Add(this.rtbQueue);
            this.Queue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Queue.Location = new System.Drawing.Point(12, 21);
            this.Queue.Name = "Queue";
            this.Queue.Size = new System.Drawing.Size(535, 330);
            this.Queue.TabIndex = 0;
            this.Queue.TabStop = false;
            this.Queue.Text = "Queue";
            // 
            // txtQueueInput
            // 
            this.txtQueueInput.Location = new System.Drawing.Point(6, 246);
            this.txtQueueInput.Name = "txtQueueInput";
            this.txtQueueInput.Size = new System.Drawing.Size(515, 26);
            this.txtQueueInput.TabIndex = 4;
            // 
            // btnPeek
            // 
            this.btnPeek.Location = new System.Drawing.Point(413, 286);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(80, 38);
            this.btnPeek.TabIndex = 3;
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // btnDequeue
            // 
            this.btnDequeue.Location = new System.Drawing.Point(183, 286);
            this.btnDequeue.Name = "btnDequeue";
            this.btnDequeue.Size = new System.Drawing.Size(94, 38);
            this.btnDequeue.TabIndex = 2;
            this.btnDequeue.Text = "Dequeue";
            this.btnDequeue.UseVisualStyleBackColor = true;
            this.btnDequeue.Click += new System.EventHandler(this.btnDequeue_Click);
            // 
            // btnEnqueue
            // 
            this.btnEnqueue.Location = new System.Drawing.Point(12, 286);
            this.btnEnqueue.Name = "btnEnqueue";
            this.btnEnqueue.Size = new System.Drawing.Size(101, 38);
            this.btnEnqueue.TabIndex = 1;
            this.btnEnqueue.Text = "Enqueue";
            this.btnEnqueue.UseVisualStyleBackColor = true;
            this.btnEnqueue.Click += new System.EventHandler(this.btnEnqueue_Click);
            // 
            // rtbQueue
            // 
            this.rtbQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbQueue.Location = new System.Drawing.Point(6, 19);
            this.rtbQueue.Name = "rtbQueue";
            this.rtbQueue.Size = new System.Drawing.Size(515, 221);
            this.rtbQueue.TabIndex = 0;
            this.rtbQueue.Text = "";
            // 
            // rtbStack
            // 
            this.rtbStack.Location = new System.Drawing.Point(6, 19);
            this.rtbStack.Name = "rtbStack";
            this.rtbStack.Size = new System.Drawing.Size(509, 189);
            this.rtbStack.TabIndex = 1;
            this.rtbStack.Text = "";
            // 
            // grou
            // 
            this.grou.Controls.Add(this.txtStackInput);
            this.grou.Controls.Add(this.BtnPeekStack);
            this.grou.Controls.Add(this.btnPop);
            this.grou.Controls.Add(this.btnPush);
            this.grou.Controls.Add(this.rtbStack);
            this.grou.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grou.Location = new System.Drawing.Point(18, 416);
            this.grou.Name = "grou";
            this.grou.Size = new System.Drawing.Size(542, 316);
            this.grou.TabIndex = 2;
            this.grou.TabStop = false;
            this.grou.Text = "Stack";
            // 
            // txtStackInput
            // 
            this.txtStackInput.Location = new System.Drawing.Point(6, 214);
            this.txtStackInput.Name = "txtStackInput";
            this.txtStackInput.Size = new System.Drawing.Size(509, 26);
            this.txtStackInput.TabIndex = 5;
            // 
            // BtnPeekStack
            // 
            this.BtnPeekStack.Location = new System.Drawing.Point(432, 268);
            this.BtnPeekStack.Name = "BtnPeekStack";
            this.BtnPeekStack.Size = new System.Drawing.Size(83, 42);
            this.BtnPeekStack.TabIndex = 4;
            this.BtnPeekStack.Text = "Peek";
            this.BtnPeekStack.UseVisualStyleBackColor = true;
            this.BtnPeekStack.Click += new System.EventHandler(this.BtnPeekStack_Click);
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(194, 268);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(86, 42);
            this.btnPop.TabIndex = 3;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(15, 268);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(82, 42);
            this.btnPush.TabIndex = 2;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Message:";
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(113, 378);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(474, 35);
            this.lblMessage.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 744);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grou);
            this.Controls.Add(this.Queue);
            this.Name = "Form1";
            this.Text = "Queue vs Stack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Queue.ResumeLayout(false);
            this.Queue.PerformLayout();
            this.grou.ResumeLayout(false);
            this.grou.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Queue;
        private System.Windows.Forms.TextBox txtQueueInput;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.Button btnDequeue;
        private System.Windows.Forms.Button btnEnqueue;
        private System.Windows.Forms.RichTextBox rtbQueue;
        private System.Windows.Forms.RichTextBox rtbStack;
        private System.Windows.Forms.GroupBox grou;
        private System.Windows.Forms.TextBox txtStackInput;
        private System.Windows.Forms.Button BtnPeekStack;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMessage;
    }
}

