#pragma warning disable
#line 1 "frmLogin.Designer.cs"
#pragma warning disable
#line 1 "frmLogin.Designer.cs"
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmLogin
   {

      [Intercepted]

      #region "Upgrade Support "
      private static frmLogin m_vb6FormDefInstance 
#line 13
                                                   { 
#line 13
                                                     get                                                        
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (SKS.frmLogin)catalog.frmLogin.m_vb6FormDefInstance;} 
#line 13

#line 13
                                                          set                                                             
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmLogin.m_vb6FormDefInstance = value;} 
#line 13
                                                               }

#line 14

      [Intercepted]
      private static bool m_InitializingDefInstance 
#line 16
                                                    { 
#line 16
                                                      get                                                         
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (bool)catalog.frmLogin.m_InitializingDefInstance;} 
#line 16

#line 16
                                                           set                                                              
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmLogin.m_InitializingDefInstance = value;} 
#line 16
                                                                }

#line 17

      [Intercepted]
      public static frmLogin DefInstance
      {
      	get
      	{
      		if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
            {
            	m_InitializingDefInstance = true;
            	m_vb6FormDefInstance = CreateInstance();
            	m_InitializingDefInstance = false;
            }
            return m_vb6FormDefInstance;
         }
         set
         {
            m_vb6FormDefInstance = value;
         }
      }

      #endregion
      #region "Windows Form Designer generated code "

      public static frmLogin CreateInstance()
      {
      	frmLogin theInstance = new frmLogin();
      	return theInstance;
      }

#line hidden
                                                    
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string[] visualControls_k__BackingField;
#line 47
                                                    

      [Intercepted]
      private string[] visualControls 
#line 47
                                      { 
#line 47
                                        get                                           
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_visualControls)<=0){this.visualControls_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<string[]>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_visualControls;}return this.visualControls_k__BackingField;} 
#line 47

#line 47
                                             set                                                
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<string[] >(this,_Mobilize_References,0,this.visualControls_k__BackingField,(string[])value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_visualControls;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_visualControls;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.visualControls_k__BackingField=(string[])value;} 
#line 47
                                                  } 
#line 48

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private System.ComponentModel.IContainer components_k__BackingField;
#line 52


      [Intercepted]
      //Required by the Windows Form Designer
      private
      System.ComponentModel.IContainer components 
#line 52
                                                  { 
#line 52
                                                    get                                                       
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_components)<=0){this.components_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<System.ComponentModel.IContainer>(this,_Mobilize_References,1);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_components;}return this.components_k__BackingField;} 
#line 52

#line 52
                                                         set                                                            
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<      System.ComponentModel.IContainer >(this,_Mobilize_References,1,this.components_k__BackingField,(System.ComponentModel.IContainer)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_components;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_components;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.components_k__BackingField=(System.ComponentModel.IContainer)value;} 
#line 52
                                                              }

#line 53

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolTip ToolTipMain_k__BackingField;
#line 55


      [Intercepted]
      public Mobilize.Web.ToolTip ToolTipMain 
#line 55
                                              { 
#line 55
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_ToolTipMain)<=0){this.ToolTipMain_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<Mobilize.Web.ToolTip>(this,_Mobilize_References,2);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_ToolTipMain;}return this.ToolTipMain_k__BackingField;} 
#line 55

#line 55
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Mobilize.Web.ToolTip >(this,_Mobilize_References,2,this.ToolTipMain_k__BackingField,(Mobilize.Web.ToolTip)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_ToolTipMain;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_ToolTipMain;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.ToolTipMain_k__BackingField=(Mobilize.Web.ToolTip)value;} 
#line 55
                                                          }

#line 56

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtUserName_k__BackingField;
#line 58


      [Intercepted]
      public Mobilize.Web.TextBox txtUserName 
#line 58
                                              { 
#line 58
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtUserName)<=0){this.txtUserName_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,3);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtUserName;;} return this.txtUserName_k__BackingField; } 
#line 58

#line 58
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,3,this.txtUserName_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtUserName;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtUserName;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtUserName_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 58
                                                          }

#line 59

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdCancel_k__BackingField;
#line 61


      [Intercepted]
      public Mobilize.Web.Button cmdCancel 
#line 61
                                           { 
#line 61
                                             get                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdCancel)<=0){this.cmdCancel_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,4);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdCancel;;} return this.cmdCancel_k__BackingField; } 
#line 61

#line 61
                                                  set                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,4,this.cmdCancel_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdCancel;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdCancel;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdCancel_k__BackingField=(Mobilize.Web.Button)value;} 
#line 61
                                                       }

#line 62

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtPassword_k__BackingField;
#line 64


      [Intercepted]
      public Mobilize.Web.TextBox txtPassword 
#line 64
                                              { 
#line 64
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtPassword)<=0){this.txtPassword_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,5);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtPassword;;} return this.txtPassword_k__BackingField; } 
#line 64

#line 64
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,5,this.txtPassword_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtPassword;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtPassword;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtPassword_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 64
                                                          }

#line 65

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdOK_k__BackingField;
#line 67


      [Intercepted]
      public Mobilize.Web.Button cmdOK 
#line 67
                                       { 
#line 67
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdOK)<=0){this.cmdOK_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,6);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdOK;;} return this.cmdOK_k__BackingField; } 
#line 67

#line 67
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,6,this.cmdOK_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdOK;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdOK;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdOK_k__BackingField=(Mobilize.Web.Button)value;} 
#line 67
                                                   }

#line 68

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label _lblLabels_0_k__BackingField;
#line 70


      [Intercepted]
      private Mobilize.Web.Label _lblLabels_0 
#line 70
                                              { 
#line 70
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__lblLabels_0)<=0){this._lblLabels_0_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,7);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__lblLabels_0;;} return this._lblLabels_0_k__BackingField; } 
#line 70

#line 70
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,7,this._lblLabels_0_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__lblLabels_0;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__lblLabels_0;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._lblLabels_0_k__BackingField=(Mobilize.Web.Label)value;} 
#line 70
                                                          }

#line 71

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label _lblLabels_1_k__BackingField;
#line 73


      [Intercepted]
      private Mobilize.Web.Label _lblLabels_1 
#line 73
                                              { 
#line 73
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__lblLabels_1)<=0){this._lblLabels_1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,8);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__lblLabels_1;;} return this._lblLabels_1_k__BackingField; } 
#line 73

#line 73
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,8,this._lblLabels_1_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__lblLabels_1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__lblLabels_1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._lblLabels_1_k__BackingField=(Mobilize.Web.Label)value;} 
#line 73
                                                          }

#line 74

#line hidden
                                                          
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label[] lblLabels_k__BackingField;
#line 76
                                                          

      [Intercepted]
      public Mobilize.Web.Label[] lblLabels 
#line 76
                                            { 
#line 76
                                              get                                                 
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lblLabels)<=0){this.lblLabels_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<Mobilize.Web.Label[]>(this,_Mobilize_References,9);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lblLabels;}return this.lblLabels_k__BackingField;} 
#line 76

#line 76
                                                   set                                                      
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Mobilize.Web.Label[] >(this,_Mobilize_References,9,this.lblLabels_k__BackingField,(Mobilize.Web.Label[])value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lblLabels;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lblLabels;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lblLabels_k__BackingField=(Mobilize.Web.Label[])value;} 
#line 76
                                                        } 
#line 77
      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.

      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {

#line hidden
this.Controls.DesignTime=true;
#line 85
      	this.components = new System.ComponentModel.Container();
      	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
      	this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
      	this.txtUserName = new Mobilize.Web.TextBox();
      	this.cmdCancel = new Mobilize.Web.Button();
      	this.txtPassword = new Mobilize.Web.TextBox();
      	this.cmdOK = new Mobilize.Web.Button();
      	this._lblLabels_0 = new Mobilize.Web.Label();
      	this._lblLabels_1 = new Mobilize.Web.Label();
      	this.SuspendLayout();
      	// 
      	// txtUserName
      	// 
      	this.txtUserName.AcceptsReturn = true;
      	this.txtUserName.AllowDrop = true;
      	this.txtUserName.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtUserName.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtUserName.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtUserName.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtUserName.Location = new System.Drawing.Point(118, 25);
         this.txtUserName.MaxLength = 0;
         this.txtUserName.Name = "txtUserName";
         this.txtUserName.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtUserName.Size = new System.Drawing.Size(155, 23);
         this.txtUserName.TabIndex = 1;
         // 
         // cmdCancel
         // 
         this.cmdCancel.AllowDrop = true;
         this.cmdCancel.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdCancel.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdCancel.Location = new System.Drawing.Point(196, 100);
         this.cmdCancel.Name = "cmdCancel";
         this.cmdCancel.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdCancel.Size = new System.Drawing.Size(76, 26);
         this.cmdCancel.TabIndex = 5;
         this.cmdCancel.Text = "Cancel";
         this.cmdCancel.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdCancel.UseVisualStyleBackColor = false;
         this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
         // 
         // txtPassword
         // 
         this.txtPassword.AcceptsReturn = true;
         this.txtPassword.AllowDrop = true;
         this.txtPassword.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtPassword.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtPassword.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtPassword.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtPassword.Properties().ImeMode = Mobilize.Web.ImeMode.Disable;
         this.txtPassword.Location = new System.Drawing.Point(118, 51);
         this.txtPassword.MaxLength = 0;
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.PasswordChar = (char) 42;
         this.txtPassword.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtPassword.Size = new System.Drawing.Size(155, 23);
         this.txtPassword.TabIndex = 3;
         // 
         // cmdOK
         // 
         this.cmdOK.AllowDrop = true;
         this.cmdOK.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdOK.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdOK.Location = new System.Drawing.Point(89, 100);
         this.cmdOK.Name = "cmdOK";
         this.cmdOK.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdOK.Size = new System.Drawing.Size(76, 26);
         this.cmdOK.TabIndex = 4;
         this.cmdOK.Text = "OK";
         this.cmdOK.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdOK.UseVisualStyleBackColor = false;
         this.cmdOK.Click += new System.EventHandler(this.cmdOk_Click);
         // 
         // _lblLabels_0
         // 
         this._lblLabels_0.AllowDrop = true;
         this._lblLabels_0.BackColor = Mobilize.Web.SystemColors.Control;
         this._lblLabels_0.BorderStyle = Mobilize.Web.BorderStyle.None;
         this._lblLabels_0.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this._lblLabels_0.Location = new System.Drawing.Point(39, 26);
         this._lblLabels_0.Name = "_lblLabels_0";
         this._lblLabels_0.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._lblLabels_0.Size = new System.Drawing.Size(72, 18);
         this._lblLabels_0.TabIndex = 0;
         this._lblLabels_0.Text = "&User Name:";
         // 
         // _lblLabels_1
         // 
         this._lblLabels_1.AllowDrop = true;
         this._lblLabels_1.BackColor = Mobilize.Web.SystemColors.Control;
         this._lblLabels_1.BorderStyle = Mobilize.Web.BorderStyle.None;
         this._lblLabels_1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this._lblLabels_1.Location = new System.Drawing.Point(39, 52);
         this._lblLabels_1.Name = "_lblLabels_1";
         this._lblLabels_1.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._lblLabels_1.Size = new System.Drawing.Size(72, 18);
         this._lblLabels_1.TabIndex = 2;
         this._lblLabels_1.Text = "&Password:";
         // 
         // frmLogin
         // 
         this.AcceptButton = this.cmdOK;
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = Mobilize.Web.SystemColors.Control;
         this.CancelButton = this.cmdCancel;
         this.Properties().ClientSize = new System.Drawing.Size(289, 137);
         this.Controls.Add(this.txtUserName);
         this.Controls.Add(this.cmdCancel);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.cmdOK);
         this.Controls.Add(this._lblLabels_0);
         this.Controls.Add(this._lblLabels_1);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedSingle;
         this.Icon = (Mobilize.Web.Icon)new Mobilize.Web.Icon("assets/images/SKS.frmLogin.frmLogin.Icon.png");
         this.Properties().Location = new System.Drawing.Point(189, 232);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmLogin";
         this.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Properties().ShowInTaskbar = false;
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.CenterScreen;
         this.Text = "Login";
         this.Closed += new System.EventHandler(this.Form_Closed);
         this.ResumeLayout(false);

#line hidden
this.Controls.DesignTime=false;
#line 211
      }

      void ReLoadForm(bool addEvents)
      {
      	InitializelblLabels();
      }

      void InitializelblLabels()
      {
      	this.lblLabels = new Mobilize.Web.Label[2];
      	this.lblLabels[0] = _lblLabels_0;
      	this.lblLabels[1] = _lblLabels_1;
      }
      #endregion

   }
}
#pragma warning restore
