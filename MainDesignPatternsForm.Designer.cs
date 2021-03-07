
namespace DesignPatternsTest
{
    partial class MainDesignPatternsForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSingletonV2 = new System.Windows.Forms.Button();
            this.btnSingletonV1 = new System.Windows.Forms.Button();
            this.btnBuilder = new System.Windows.Forms.Button();
            this.btnAbstractFactory = new System.Windows.Forms.Button();
            this.btnFactoryMethod = new System.Windows.Forms.Button();
            this.btnFactory = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDecorator = new System.Windows.Forms.Button();
            this.btnFacade = new System.Windows.Forms.Button();
            this.btnProxy = new System.Windows.Forms.Button();
            this.btnAdapter = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCommand = new System.Windows.Forms.Button();
            this.btnObserver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSingletonV2);
            this.groupBox1.Controls.Add(this.btnSingletonV1);
            this.groupBox1.Controls.Add(this.btnBuilder);
            this.groupBox1.Controls.Add(this.btnAbstractFactory);
            this.groupBox1.Controls.Add(this.btnFactoryMethod);
            this.groupBox1.Controls.Add(this.btnFactory);
            this.groupBox1.Location = new System.Drawing.Point(96, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criacionais";
            // 
            // btnSingletonV2
            // 
            this.btnSingletonV2.Location = new System.Drawing.Point(262, 67);
            this.btnSingletonV2.Name = "btnSingletonV2";
            this.btnSingletonV2.Size = new System.Drawing.Size(111, 33);
            this.btnSingletonV2.TabIndex = 5;
            this.btnSingletonV2.Text = "Singleton v2";
            this.btnSingletonV2.UseVisualStyleBackColor = true;
            this.btnSingletonV2.Click += new System.EventHandler(this.btnSingletonV2_Click);
            // 
            // btnSingletonV1
            // 
            this.btnSingletonV1.Location = new System.Drawing.Point(262, 19);
            this.btnSingletonV1.Name = "btnSingletonV1";
            this.btnSingletonV1.Size = new System.Drawing.Size(111, 33);
            this.btnSingletonV1.TabIndex = 4;
            this.btnSingletonV1.Text = "Singleton V1";
            this.btnSingletonV1.UseVisualStyleBackColor = true;
            this.btnSingletonV1.Click += new System.EventHandler(this.btnSingletonV1_Click);
            // 
            // btnBuilder
            // 
            this.btnBuilder.Location = new System.Drawing.Point(145, 67);
            this.btnBuilder.Name = "btnBuilder";
            this.btnBuilder.Size = new System.Drawing.Size(111, 33);
            this.btnBuilder.TabIndex = 3;
            this.btnBuilder.Text = "Builder";
            this.btnBuilder.UseVisualStyleBackColor = true;
            this.btnBuilder.Click += new System.EventHandler(this.btnBuilder_Click);
            // 
            // btnAbstractFactory
            // 
            this.btnAbstractFactory.Location = new System.Drawing.Point(18, 67);
            this.btnAbstractFactory.Name = "btnAbstractFactory";
            this.btnAbstractFactory.Size = new System.Drawing.Size(111, 33);
            this.btnAbstractFactory.TabIndex = 2;
            this.btnAbstractFactory.Text = "Abstract Factory";
            this.btnAbstractFactory.UseVisualStyleBackColor = true;
            this.btnAbstractFactory.Click += new System.EventHandler(this.btnAbstractFactory_Click);
            // 
            // btnFactoryMethod
            // 
            this.btnFactoryMethod.Location = new System.Drawing.Point(145, 19);
            this.btnFactoryMethod.Name = "btnFactoryMethod";
            this.btnFactoryMethod.Size = new System.Drawing.Size(111, 33);
            this.btnFactoryMethod.TabIndex = 1;
            this.btnFactoryMethod.Text = "Factory Method";
            this.btnFactoryMethod.UseVisualStyleBackColor = true;
            this.btnFactoryMethod.Click += new System.EventHandler(this.btnFactoryMethod_Click);
            // 
            // btnFactory
            // 
            this.btnFactory.Location = new System.Drawing.Point(18, 19);
            this.btnFactory.Name = "btnFactory";
            this.btnFactory.Size = new System.Drawing.Size(111, 33);
            this.btnFactory.TabIndex = 0;
            this.btnFactory.Text = "Factory";
            this.btnFactory.UseVisualStyleBackColor = true;
            this.btnFactory.Click += new System.EventHandler(this.btnFactory_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSaida);
            this.groupBox2.Location = new System.Drawing.Point(12, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 180);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saída de Exemplo";
            // 
            // txtSaida
            // 
            this.txtSaida.Location = new System.Drawing.Point(6, 19);
            this.txtSaida.Multiline = true;
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(519, 155);
            this.txtSaida.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDecorator);
            this.groupBox3.Controls.Add(this.btnFacade);
            this.groupBox3.Controls.Add(this.btnProxy);
            this.groupBox3.Controls.Add(this.btnAdapter);
            this.groupBox3.Location = new System.Drawing.Point(74, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 114);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estruturais";
            // 
            // btnDecorator
            // 
            this.btnDecorator.Location = new System.Drawing.Point(145, 67);
            this.btnDecorator.Name = "btnDecorator";
            this.btnDecorator.Size = new System.Drawing.Size(111, 33);
            this.btnDecorator.TabIndex = 3;
            this.btnDecorator.Text = "Decorator";
            this.btnDecorator.UseVisualStyleBackColor = true;
            this.btnDecorator.Click += new System.EventHandler(this.btnDecorator_Click);
            // 
            // btnFacade
            // 
            this.btnFacade.Location = new System.Drawing.Point(18, 67);
            this.btnFacade.Name = "btnFacade";
            this.btnFacade.Size = new System.Drawing.Size(111, 33);
            this.btnFacade.TabIndex = 2;
            this.btnFacade.Text = "Facade";
            this.btnFacade.UseVisualStyleBackColor = true;
            this.btnFacade.Click += new System.EventHandler(this.btnFacade_Click);
            // 
            // btnProxy
            // 
            this.btnProxy.Location = new System.Drawing.Point(145, 19);
            this.btnProxy.Name = "btnProxy";
            this.btnProxy.Size = new System.Drawing.Size(111, 33);
            this.btnProxy.TabIndex = 1;
            this.btnProxy.Text = "Proxy";
            this.btnProxy.UseVisualStyleBackColor = true;
            this.btnProxy.Click += new System.EventHandler(this.btnProxy_Click);
            // 
            // btnAdapter
            // 
            this.btnAdapter.Location = new System.Drawing.Point(18, 19);
            this.btnAdapter.Name = "btnAdapter";
            this.btnAdapter.Size = new System.Drawing.Size(111, 33);
            this.btnAdapter.TabIndex = 0;
            this.btnAdapter.Text = "Adapter";
            this.btnAdapter.UseVisualStyleBackColor = true;
            this.btnAdapter.Click += new System.EventHandler(this.btnAdapter_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCommand);
            this.groupBox4.Controls.Add(this.btnObserver);
            this.groupBox4.Location = new System.Drawing.Point(343, 132);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(149, 114);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Comportamentais";
            // 
            // btnCommand
            // 
            this.btnCommand.Location = new System.Drawing.Point(18, 67);
            this.btnCommand.Name = "btnCommand";
            this.btnCommand.Size = new System.Drawing.Size(111, 33);
            this.btnCommand.TabIndex = 2;
            this.btnCommand.Text = "Command";
            this.btnCommand.UseVisualStyleBackColor = true;
            this.btnCommand.Click += new System.EventHandler(this.btnCommand_Click);
            // 
            // btnObserver
            // 
            this.btnObserver.Location = new System.Drawing.Point(18, 19);
            this.btnObserver.Name = "btnObserver";
            this.btnObserver.Size = new System.Drawing.Size(111, 33);
            this.btnObserver.TabIndex = 0;
            this.btnObserver.Text = "Observer";
            this.btnObserver.UseVisualStyleBackColor = true;
            this.btnObserver.Click += new System.EventHandler(this.btnObserver_Click);
            // 
            // MainDesignPatternsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 442);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainDesignPatternsForm";
            this.Text = "Design Patterns Test";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFactory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSaida;
        private System.Windows.Forms.Button btnFactoryMethod;
        private System.Windows.Forms.Button btnAbstractFactory;
        private System.Windows.Forms.Button btnBuilder;
        private System.Windows.Forms.Button btnSingletonV2;
        private System.Windows.Forms.Button btnSingletonV1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDecorator;
        private System.Windows.Forms.Button btnFacade;
        private System.Windows.Forms.Button btnProxy;
        private System.Windows.Forms.Button btnAdapter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCommand;
        private System.Windows.Forms.Button btnObserver;
    }
}

