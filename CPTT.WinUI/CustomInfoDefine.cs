//==================================================================================
// �������ܳ����������ϵͳ4.0
//==================================================================================
// Copyright @2005 Shanghai Chuangzhi Toy&Technology Corporation All rights reserved.
//������������ܰ�Ȩ���͹�����Լ����.
// ��δ����Ȩ�����Ը��ƻ򴫲�������(�������κβ���),���ܵ����������¼������Ʋ�,
//�����ڷ�����ɵķ�Χ���ܵ����̶ȵ�����!
//==================================================================================

using System;
using System.Drawing;
using System.Data;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using CPTT.SystemFramework;
using CPTT.BusinessFacade;
using Microsoft.Practices.EnterpriseLibrary.Configuration;

namespace CPTT.WinUI
{
	/// <summary>
	/// Summary description for CustomInfoDefine.
	/// </summary>
	public class CustomInfoDefine : DevExpress.XtraEditors.XtraForm
	{
		private DevExpress.XtraEditors.GroupControl groupControl_CustomInfo;
		private DevExpress.XtraEditors.SplitContainerControl splitContainerControl_CustomInfo;
		private DevExpress.Utils.Frames.NotePanel notePanel_TeaCustomInfo;
		private DevExpress.Utils.Frames.NotePanel notePanel_StuCustomInfo;
		private DevExpress.XtraGrid.GridControl gridControl_TeaCustomInfo;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn_TeaPressKey;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn_TeaPressKeyInfo;
		private DevExpress.XtraGrid.GridControl gridControl_StuCustomInfo;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn_StuPressKey;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn_StuPressKeyInfo;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		internal const string USERSTYLEPROFILE_CONFIG_NAME = "UserStyleProfile";
		private DevExpress.XtraEditors.SimpleButton simpleButton_SaveTea;
		private DevExpress.XtraEditors.SimpleButton simpleButton_SaveStu;

		private UserStyle userStyle;

		private DataSet stuState;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
		private DataSet teaState;

		public CustomInfoDefine()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

			loadUserStyleProfile();

			LoadTeaStateInfo();

			LoadStuStateInfo();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region ���ش�����
		//���������ļ����ش�����
		private void loadUserStyleProfile()
		{
			try
			{
				userStyle = ConfigurationManager.GetConfiguration(USERSTYLEPROFILE_CONFIG_NAME) as UserStyle;
				string windowsStyle = userStyle.StyleName;
				string windowsSkin = userStyle.SkinName;

				if(windowsStyle.Equals("Default"))
				{
					DevExpress.LookAndFeel.UserLookAndFeel.Default.SetDefaultStyle();
				}
				else if(windowsStyle.Equals("WindowsXP"))
				{
					DevExpress.LookAndFeel.UserLookAndFeel.Default.SetWindowsXPStyle();
				}
				else if(windowsStyle.Equals("OfficeXP"))
				{
					DevExpress.LookAndFeel.UserLookAndFeel.Default.SetOffice2003Style();
				}
				else if(windowsStyle.Equals("Office2000"))
				{
					DevExpress.LookAndFeel.UserLookAndFeel.Default.SetDefaultStyle();
				}
				else if(windowsStyle.Equals("Office2003"))
				{
					DevExpress.LookAndFeel.UserLookAndFeel.Default.SetOffice2003Style();
				}
				else if(windowsStyle.Equals("Skin"))
				{
					DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(windowsSkin);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"ϵͳ��Ϣ",MessageBoxButtons.OK,
					MessageBoxIcon.Information);
			}
		}
		#endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CustomInfoDefine));
			this.groupControl_CustomInfo = new DevExpress.XtraEditors.GroupControl();
			this.splitContainerControl_CustomInfo = new DevExpress.XtraEditors.SplitContainerControl();
			this.gridControl_TeaCustomInfo = new DevExpress.XtraGrid.GridControl();
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn_TeaPressKey = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn_TeaPressKeyInfo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.notePanel_TeaCustomInfo = new DevExpress.Utils.Frames.NotePanel();
			this.simpleButton_SaveTea = new DevExpress.XtraEditors.SimpleButton();
			this.gridControl_StuCustomInfo = new DevExpress.XtraGrid.GridControl();
			this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn_StuPressKey = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn_StuPressKeyInfo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.notePanel_StuCustomInfo = new DevExpress.Utils.Frames.NotePanel();
			this.simpleButton_SaveStu = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.groupControl_CustomInfo)).BeginInit();
			this.groupControl_CustomInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl_CustomInfo)).BeginInit();
			this.splitContainerControl_CustomInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl_TeaCustomInfo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl_StuCustomInfo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
			this.SuspendLayout();
			// 
			// groupControl_CustomInfo
			// 
			this.groupControl_CustomInfo.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
			this.groupControl_CustomInfo.Appearance.Options.UseBackColor = true;
			this.groupControl_CustomInfo.Controls.Add(this.splitContainerControl_CustomInfo);
			this.groupControl_CustomInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupControl_CustomInfo.Location = new System.Drawing.Point(0, 0);
			this.groupControl_CustomInfo.Name = "groupControl_CustomInfo";
			this.groupControl_CustomInfo.Size = new System.Drawing.Size(688, 325);
			this.groupControl_CustomInfo.TabIndex = 0;
			this.groupControl_CustomInfo.Text = "�Զ�����Ϣ����";
			// 
			// splitContainerControl_CustomInfo
			// 
			this.splitContainerControl_CustomInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitContainerControl_CustomInfo.Location = new System.Drawing.Point(3, 18);
			this.splitContainerControl_CustomInfo.Name = "splitContainerControl_CustomInfo";
			this.splitContainerControl_CustomInfo.Panel1.Controls.Add(this.simpleButton1);
			this.splitContainerControl_CustomInfo.Panel1.Controls.Add(this.gridControl_TeaCustomInfo);
			this.splitContainerControl_CustomInfo.Panel1.Controls.Add(this.notePanel_TeaCustomInfo);
			this.splitContainerControl_CustomInfo.Panel1.Controls.Add(this.simpleButton_SaveTea);
			this.splitContainerControl_CustomInfo.Panel1.Text = "splitContainerControl1_Panel1";
			this.splitContainerControl_CustomInfo.Panel2.Controls.Add(this.simpleButton2);
			this.splitContainerControl_CustomInfo.Panel2.Controls.Add(this.gridControl_StuCustomInfo);
			this.splitContainerControl_CustomInfo.Panel2.Controls.Add(this.notePanel_StuCustomInfo);
			this.splitContainerControl_CustomInfo.Panel2.Controls.Add(this.simpleButton_SaveStu);
			this.splitContainerControl_CustomInfo.Panel2.Text = "splitContainerControl1_Panel2";
			this.splitContainerControl_CustomInfo.Size = new System.Drawing.Size(682, 286);
			this.splitContainerControl_CustomInfo.SplitterPosition = 340;
			this.splitContainerControl_CustomInfo.TabIndex = 0;
			this.splitContainerControl_CustomInfo.Text = "splitContainerControl1";
			// 
			// gridControl_TeaCustomInfo
			// 
			// 
			// gridControl_TeaCustomInfo.EmbeddedNavigator
			// 
			this.gridControl_TeaCustomInfo.EmbeddedNavigator.Name = "";
			this.gridControl_TeaCustomInfo.Location = new System.Drawing.Point(0, 80);
			this.gridControl_TeaCustomInfo.MainView = this.gridView2;
			this.gridControl_TeaCustomInfo.Name = "gridControl_TeaCustomInfo";
			this.gridControl_TeaCustomInfo.Size = new System.Drawing.Size(332, 200);
			this.gridControl_TeaCustomInfo.TabIndex = 6;
			this.gridControl_TeaCustomInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
																													 this.gridView2,
																													 this.gridView1});
			// 
			// gridView2
			// 
			this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
																							 this.gridColumn_TeaPressKey,
																							 this.gridColumn_TeaPressKeyInfo});
			this.gridView2.GridControl = this.gridControl_TeaCustomInfo;
			this.gridView2.Name = "gridView2";
			this.gridView2.OptionsCustomization.AllowFilter = false;
			this.gridView2.OptionsCustomization.AllowGroup = false;
			this.gridView2.OptionsView.ShowFilterPanel = false;
			this.gridView2.OptionsView.ShowFooter = true;
			this.gridView2.OptionsView.ShowGroupPanel = false;
			// 
			// gridColumn_TeaPressKey
			// 
			this.gridColumn_TeaPressKey.Caption = "����ֵ";
			this.gridColumn_TeaPressKey.FieldName = "teafs_state";
			this.gridColumn_TeaPressKey.Name = "gridColumn_TeaPressKey";
			this.gridColumn_TeaPressKey.OptionsColumn.AllowEdit = false;
			this.gridColumn_TeaPressKey.Visible = true;
			this.gridColumn_TeaPressKey.VisibleIndex = 0;
			// 
			// gridColumn_TeaPressKeyInfo
			// 
			this.gridColumn_TeaPressKeyInfo.Caption = "��������";
			this.gridColumn_TeaPressKeyInfo.FieldName = "teafs_name";
			this.gridColumn_TeaPressKeyInfo.Name = "gridColumn_TeaPressKeyInfo";
			this.gridColumn_TeaPressKeyInfo.Visible = true;
			this.gridColumn_TeaPressKeyInfo.VisibleIndex = 1;
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl_TeaCustomInfo;
			this.gridView1.Name = "gridView1";
			// 
			// notePanel_TeaCustomInfo
			// 
			this.notePanel_TeaCustomInfo.BackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.notePanel_TeaCustomInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.notePanel_TeaCustomInfo.ForeColor = System.Drawing.Color.OrangeRed;
			this.notePanel_TeaCustomInfo.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.notePanel_TeaCustomInfo.Location = new System.Drawing.Point(0, 0);
			this.notePanel_TeaCustomInfo.MaxRows = 5;
			this.notePanel_TeaCustomInfo.Name = "notePanel_TeaCustomInfo";
			this.notePanel_TeaCustomInfo.ParentAutoHeight = true;
			this.notePanel_TeaCustomInfo.Size = new System.Drawing.Size(334, 38);
			this.notePanel_TeaCustomInfo.TabIndex = 5;
			this.notePanel_TeaCustomInfo.TabStop = false;
			this.notePanel_TeaCustomInfo.Text = "��ʦ�Զ���:                                                             (��ඨ��18��,������ʹ��" +
				"����0Ĭ��Ϊ:\"�������\")";
			// 
			// simpleButton_SaveTea
			// 
			this.simpleButton_SaveTea.Location = new System.Drawing.Point(192, 48);
			this.simpleButton_SaveTea.Name = "simpleButton_SaveTea";
			this.simpleButton_SaveTea.Size = new System.Drawing.Size(56, 23);
			this.simpleButton_SaveTea.TabIndex = 1;
			this.simpleButton_SaveTea.Text = "����";
			this.simpleButton_SaveTea.Click += new System.EventHandler(this.simpleButton_SaveTea_Click);
			// 
			// gridControl_StuCustomInfo
			// 
			// 
			// gridControl_StuCustomInfo.EmbeddedNavigator
			// 
			this.gridControl_StuCustomInfo.EmbeddedNavigator.Name = "";
			this.gridControl_StuCustomInfo.Location = new System.Drawing.Point(0, 80);
			this.gridControl_StuCustomInfo.MainView = this.gridView3;
			this.gridControl_StuCustomInfo.Name = "gridControl_StuCustomInfo";
			this.gridControl_StuCustomInfo.Size = new System.Drawing.Size(334, 200);
			this.gridControl_StuCustomInfo.TabIndex = 6;
			this.gridControl_StuCustomInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
																													 this.gridView3});
			// 
			// gridView3
			// 
			this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
																							 this.gridColumn_StuPressKey,
																							 this.gridColumn_StuPressKeyInfo});
			this.gridView3.GridControl = this.gridControl_StuCustomInfo;
			this.gridView3.Name = "gridView3";
			this.gridView3.OptionsCustomization.AllowFilter = false;
			this.gridView3.OptionsCustomization.AllowGroup = false;
			this.gridView3.OptionsView.ShowFilterPanel = false;
			this.gridView3.OptionsView.ShowFooter = true;
			this.gridView3.OptionsView.ShowGroupPanel = false;
			// 
			// gridColumn_StuPressKey
			// 
			this.gridColumn_StuPressKey.Caption = "����ֵ";
			this.gridColumn_StuPressKey.FieldName = "state_flowState";
			this.gridColumn_StuPressKey.Name = "gridColumn_StuPressKey";
			this.gridColumn_StuPressKey.OptionsColumn.AllowEdit = false;
			this.gridColumn_StuPressKey.Visible = true;
			this.gridColumn_StuPressKey.VisibleIndex = 0;
			// 
			// gridColumn_StuPressKeyInfo
			// 
			this.gridColumn_StuPressKeyInfo.Caption = "��������";
			this.gridColumn_StuPressKeyInfo.FieldName = "state_flowStateName";
			this.gridColumn_StuPressKeyInfo.Name = "gridColumn_StuPressKeyInfo";
			this.gridColumn_StuPressKeyInfo.Visible = true;
			this.gridColumn_StuPressKeyInfo.VisibleIndex = 1;
			// 
			// notePanel_StuCustomInfo
			// 
			this.notePanel_StuCustomInfo.BackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.notePanel_StuCustomInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.notePanel_StuCustomInfo.ForeColor = System.Drawing.Color.OrangeRed;
			this.notePanel_StuCustomInfo.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.notePanel_StuCustomInfo.Location = new System.Drawing.Point(0, 0);
			this.notePanel_StuCustomInfo.MaxRows = 5;
			this.notePanel_StuCustomInfo.Name = "notePanel_StuCustomInfo";
			this.notePanel_StuCustomInfo.ParentAutoHeight = true;
			this.notePanel_StuCustomInfo.Size = new System.Drawing.Size(332, 38);
			this.notePanel_StuCustomInfo.TabIndex = 5;
			this.notePanel_StuCustomInfo.TabStop = false;
			this.notePanel_StuCustomInfo.Text = "ѧ���Զ���                                                                   (��ඨ��18����" +
				"�Ӳ�Ϊ�̶��Զ����)";
			// 
			// simpleButton_SaveStu
			// 
			this.simpleButton_SaveStu.Location = new System.Drawing.Point(192, 48);
			this.simpleButton_SaveStu.Name = "simpleButton_SaveStu";
			this.simpleButton_SaveStu.Size = new System.Drawing.Size(56, 23);
			this.simpleButton_SaveStu.TabIndex = 1;
			this.simpleButton_SaveStu.Text = "����";
			this.simpleButton_SaveStu.Click += new System.EventHandler(this.simpleButton_SaveStu_Click);
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(256, 48);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(64, 23);
			this.simpleButton1.TabIndex = 7;
			this.simpleButton1.Text = "ȫ�����";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// simpleButton2
			// 
			this.simpleButton2.Location = new System.Drawing.Point(256, 48);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(64, 23);
			this.simpleButton2.TabIndex = 8;
			this.simpleButton2.Text = "ȫ�����";
			this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
			// 
			// CustomInfoDefine
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.ClientSize = new System.Drawing.Size(688, 325);
			this.Controls.Add(this.groupControl_CustomInfo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CustomInfoDefine";
			this.ShowInTaskbar = false;
			this.Text = "�Զ�����Ϣά��";
			this.Load += new System.EventHandler(this.CustomInfoDefine_Load);
			((System.ComponentModel.ISupportInitialize)(this.groupControl_CustomInfo)).EndInit();
			this.groupControl_CustomInfo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl_CustomInfo)).EndInit();
			this.splitContainerControl_CustomInfo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl_TeaCustomInfo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl_StuCustomInfo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region restriction on both admin and tourist
		private void CustomInfoDefine_Load(object sender, System.EventArgs e)
		{
			if ( System.Threading.Thread.CurrentPrincipal.Identity.Name.ToLower() == "admin" || System.Threading.Thread.CurrentPrincipal.IsInRole("һ��"))
			{
				gridColumn_StuPressKeyInfo.OptionsColumn.AllowEdit = false;
				gridColumn_TeaPressKeyInfo.OptionsColumn.AllowEdit = false;
			}
		}
		#endregion

		#region load initial Info
		private void LoadTeaStateInfo()
		{
			teaState = new FlowStateSystem().GetTeaState();

			int count = teaState.Tables[0].Rows.Count;

			for(int i=0;i<count;i++)
			{
				teaState.Tables[0].Rows[i][0] = i+1;
			}

			gridControl_TeaCustomInfo.DataSource = teaState.Tables[0];
		}

		private void LoadStuStateInfo()
		{
			stuState = new FlowStateSystem().GetStuState();

			int count = stuState.Tables[0].Rows.Count;

			for(int i=0;i<count;i++)
			{
				stuState.Tables[0].Rows[i][0] = i;
			}

			gridControl_StuCustomInfo.DataSource = stuState.Tables[0];
		}
		#endregion

		#region save update
		private void simpleButton_SaveTea_Click(object sender, System.EventArgs e)
		{
			FlowStateSystem flowStateSystem = new FlowStateSystem();

			for(int i=0;i<gridView2.RowCount;i++)
			{
				Int16 stateID = (Int16)(Convert.ToInt16(gridView2.GetDataRow(i)["teafs_state"])+2);
				string stateName = gridView2.GetDataRow(i)["teafs_name"].ToString();
				
				flowStateSystem.UpdateTeaState(stateID,stateName);
			}

			MessageBox.Show("����ɹ�.","ϵͳ��Ϣ!",
				MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void simpleButton_SaveStu_Click(object sender, System.EventArgs e)
		{
			FlowStateSystem flowStateSystem = new FlowStateSystem();

			for(int i=0;i<gridView3.RowCount;i++)
			{
				Int16 stateID = (Int16)(Convert.ToInt16(gridView3.GetDataRow(i)["state_flowState"])+5);
				string stateName = gridView3.GetDataRow(i)["state_flowStateName"].ToString();
				
				flowStateSystem.UpdateStuState(stateID,stateName);
			}

			MessageBox.Show("����ɹ�.","ϵͳ��Ϣ!",
				MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		#endregion

		private void simpleButton1_Click(object sender, System.EventArgs e)
		{
			FlowStateSystem flowStateSystem = new FlowStateSystem();
			flowStateSystem.ClearFlowState(2);
			gridControl_TeaCustomInfo.DataSource = flowStateSystem.GetTeaState().Tables[0];
			MessageBox.Show("�����ϣ�");
		}

		private void simpleButton2_Click(object sender, System.EventArgs e)
		{
			FlowStateSystem flowStateSystem = new FlowStateSystem();
			flowStateSystem.ClearFlowState(1);
			gridControl_StuCustomInfo.DataSource = flowStateSystem.GetStuState().Tables[0];
			MessageBox.Show("�����ϣ�");
		}

	}
}

