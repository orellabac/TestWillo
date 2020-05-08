#pragma warning disable
#line 1 "frmAbout.Designer.cs"
#pragma warning disable
#line 1 "frmAbout.Designer.cs"
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmAbout
   {

      [Intercepted]

      #region "Upgrade Support "
      private static frmAbout m_vb6FormDefInstance 
#line 13
                                                   { 
#line 13
                                                     get                                                        
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (SKS.frmAbout)catalog.frmAbout.m_vb6FormDefInstance;} 
#line 13

#line 13
                                                          set                                                             
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmAbout.m_vb6FormDefInstance = value;} 
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
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (bool)catalog.frmAbout.m_InitializingDefInstance;} 
#line 16

#line 16
                                                           set                                                              
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmAbout.m_InitializingDefInstance = value;} 
#line 16
                                                                }

#line 17

      [Intercepted]
      public static frmAbout DefInstance
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

      public static frmAbout CreateInstance()
      {
      	frmAbout theInstance = new frmAbout();
      	theInstance.Form_Load();
      	return theInstance;
      }

#line hidden
                                                    
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string[] visualControls_k__BackingField;
#line 48
                                                    

      [Intercepted]
      private string[] visualControls 
#line 48
                                      { 
#line 48
                                        get                                           
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_visualControls)<=0){this.visualControls_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<string[]>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_visualControls;}return this.visualControls_k__BackingField;} 
#line 48

#line 48
                                             set                                                
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<string[] >(this,_Mobilize_References,0,this.visualControls_k__BackingField,(string[])value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_visualControls;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_visualControls;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.visualControls_k__BackingField=(string[])value;} 
#line 48
                                                  } 
#line 49

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private System.ComponentModel.IContainer components_k__BackingField;
#line 53


      [Intercepted]
      //Required by the Windows Form Designer
      private
      System.ComponentModel.IContainer components 
#line 53
                                                  { 
#line 53
                                                    get                                                       
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_components)<=0){this.components_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<System.ComponentModel.IContainer>(this,_Mobilize_References,1);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_components;}return this.components_k__BackingField;} 
#line 53

#line 53
                                                         set                                                            
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<      System.ComponentModel.IContainer >(this,_Mobilize_References,1,this.components_k__BackingField,(System.ComponentModel.IContainer)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_components;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_components;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.components_k__BackingField=(System.ComponentModel.IContainer)value;} 
#line 53
                                                              }

#line 54

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolTip ToolTipMain_k__BackingField;
#line 56


      [Intercepted]
      public Mobilize.Web.ToolTip ToolTipMain 
#line 56
                                              { 
#line 56
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_ToolTipMain)<=0){this.ToolTipMain_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<Mobilize.Web.ToolTip>(this,_Mobilize_References,2);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_ToolTipMain;}return this.ToolTipMain_k__BackingField;} 
#line 56

#line 56
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Mobilize.Web.ToolTip >(this,_Mobilize_References,2,this.ToolTipMain_k__BackingField,(Mobilize.Web.ToolTip)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_ToolTipMain;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_ToolTipMain;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.ToolTipMain_k__BackingField=(Mobilize.Web.ToolTip)value;} 
#line 56
                                                          }

#line 57

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.PictureBox picIcon_k__BackingField;
#line 59


      [Intercepted]
      public Mobilize.Web.PictureBox picIcon 
#line 59
                                             { 
#line 59
                                               get                                                  
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_picIcon)<=0){this.picIcon_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.PictureBox>(this,_Mobilize_References,3);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_picIcon;;} return this.picIcon_k__BackingField; } 
#line 59

#line 59
                                                    set                                                       
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.PictureBox>(this,_Mobilize_References,3,this.picIcon_k__BackingField,(Mobilize.Web.PictureBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_picIcon;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_picIcon;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.picIcon_k__BackingField=(Mobilize.Web.PictureBox)value;} 
#line 59
                                                         }

#line 60

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdOK_k__BackingField;
#line 62


      [Intercepted]
      public Mobilize.Web.Button cmdOK 
#line 62
                                       { 
#line 62
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdOK)<=0){this.cmdOK_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,4);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdOK;;} return this.cmdOK_k__BackingField; } 
#line 62

#line 62
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,4,this.cmdOK_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdOK;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdOK;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdOK_k__BackingField=(Mobilize.Web.Button)value;} 
#line 62
                                                   }

#line 63

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label _Line1_1_k__BackingField;
#line 65


      [Intercepted]
      private Mobilize.Web.Label _Line1_1 
#line 65
                                          { 
#line 65
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__Line1_1)<=0){this._Line1_1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,5);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__Line1_1;;} return this._Line1_1_k__BackingField; } 
#line 65

#line 65
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,5,this._Line1_1_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__Line1_1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__Line1_1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._Line1_1_k__BackingField=(Mobilize.Web.Label)value;} 
#line 65
                                                      }

#line 66

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label lblDescription_k__BackingField;
#line 68


      [Intercepted]
      public Mobilize.Web.Label lblDescription 
#line 68
                                               { 
#line 68
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lblDescription)<=0){this.lblDescription_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,6);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lblDescription;;} return this.lblDescription_k__BackingField; } 
#line 68

#line 68
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,6,this.lblDescription_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lblDescription;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lblDescription;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lblDescription_k__BackingField=(Mobilize.Web.Label)value;} 
#line 68
                                                           }

#line 69

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label lblTitle_k__BackingField;
#line 71


      [Intercepted]
      public Mobilize.Web.Label lblTitle 
#line 71
                                         { 
#line 71
                                           get                                              
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lblTitle)<=0){this.lblTitle_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,7);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lblTitle;;} return this.lblTitle_k__BackingField; } 
#line 71

#line 71
                                                set                                                   
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,7,this.lblTitle_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lblTitle;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lblTitle;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lblTitle_k__BackingField=(Mobilize.Web.Label)value;} 
#line 71
                                                     }

#line 72

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label _Line1_0_k__BackingField;
#line 74


      [Intercepted]
      private Mobilize.Web.Label _Line1_0 
#line 74
                                          { 
#line 74
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__Line1_0)<=0){this._Line1_0_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,8);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__Line1_0;;} return this._Line1_0_k__BackingField; } 
#line 74

#line 74
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,8,this._Line1_0_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__Line1_0;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__Line1_0;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._Line1_0_k__BackingField=(Mobilize.Web.Label)value;} 
#line 74
                                                      }

#line 75

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label lblVersion_k__BackingField;
#line 77


      [Intercepted]
      public Mobilize.Web.Label lblVersion 
#line 77
                                           { 
#line 77
                                             get                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lblVersion)<=0){this.lblVersion_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,9);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lblVersion;;} return this.lblVersion_k__BackingField; } 
#line 77

#line 77
                                                  set                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,9,this.lblVersion_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lblVersion;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lblVersion;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lblVersion_k__BackingField=(Mobilize.Web.Label)value;} 
#line 77
                                                       }

#line 78

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label lblDisclaimer_k__BackingField;
#line 80


      [Intercepted]
      public Mobilize.Web.Label lblDisclaimer 
#line 80
                                              { 
#line 80
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lblDisclaimer)<=0){this.lblDisclaimer_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,10);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lblDisclaimer;;} return this.lblDisclaimer_k__BackingField; } 
#line 80

#line 80
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,10,this.lblDisclaimer_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lblDisclaimer;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lblDisclaimer;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lblDisclaimer_k__BackingField=(Mobilize.Web.Label)value;} 
#line 80
                                                          }

#line 81

#line hidden
                                                      
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label[] Line1_k__BackingField;
#line 83
                                                      

      [Intercepted]
      public Mobilize.Web.Label[] Line1 
#line 83
                                        { 
#line 83
                                          get                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Line1)<=0){this.Line1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<Mobilize.Web.Label[]>(this,_Mobilize_References,11);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Line1;}return this.Line1_k__BackingField;} 
#line 83

#line 83
                                               set                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Mobilize.Web.Label[] >(this,_Mobilize_References,11,this.Line1_k__BackingField,(Mobilize.Web.Label[])value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Line1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Line1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Line1_k__BackingField=(Mobilize.Web.Label[])value;} 
#line 83
                                                    } 
#line 84
      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.

      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {

#line hidden
this.Controls.DesignTime=true;
#line 92
      	this.components = new System.ComponentModel.Container();
      	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
      	this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
      	this.picIcon = new Mobilize.Web.PictureBox();
      	this.cmdOK = new Mobilize.Web.Button();
      	this._Line1_1 = new Mobilize.Web.Label();
      	this.lblDescription = new Mobilize.Web.Label();
      	this.lblTitle = new Mobilize.Web.Label();
      	this._Line1_0 = new Mobilize.Web.Label();
      	this.lblVersion = new Mobilize.Web.Label();
      	this.lblDisclaimer = new Mobilize.Web.Label();
      	this.SuspendLayout();
      	// 
      	// picIcon
      	// 
      	this.picIcon.AllowDrop = true;
      	this.picIcon.BackColor = Mobilize.Web.SystemColors.Control;
         this.picIcon.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.picIcon.Properties().CausesValidation = true;
         this.picIcon.Dock = Mobilize.Web.DockStyle.None;
         this.picIcon.Enabled = true;
         this.picIcon.Image = "assets/images/SKS.frmAbout.picIcon.Image.png";
         this.picIcon.Location = new System.Drawing.Point(16, 16);
         this.picIcon.Name = "picIcon";
         this.picIcon.Size = new System.Drawing.Size(36, 36);
         this.picIcon.SizeMode = Mobilize.Web.PictureBoxSizeMode.AutoSize;
         this.picIcon.Properties().TabIndex = 1;
         this.picIcon.Properties().TabStop = true;
         this.picIcon.Visible = true;
         // 
         // cmdOK
         // 
         this.cmdOK.AllowDrop = true;
         this.cmdOK.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdOK.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdOK.Location = new System.Drawing.Point(272, 208);
         this.cmdOK.Name = "cmdOK";
         this.cmdOK.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdOK.Size = new System.Drawing.Size(108, 23);
         this.cmdOK.TabIndex = 0;
         this.cmdOK.Text = "OK";
         this.cmdOK.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdOK.UseVisualStyleBackColor = false;
         this.cmdOK.Click += new System.EventHandler(this.cmdOk_Click);
         // 
         // _Line1_1
         // 
         this._Line1_1.AllowDrop = true;
         this._Line1_1.BackColor = System.Drawing.Color.Gray;
         this._Line1_1.BorderStyle = Mobilize.Web.BorderStyle.FixedSingle;
         this._Line1_1.Enabled = false;
         this._Line1_1.Location = new System.Drawing.Point(5, 147);
         this._Line1_1.Name = "_Line1_1";
         this._Line1_1.Size = new System.Drawing.Size(294, 1);
         this._Line1_1.Visible = true;
         // 
         // lblDescription
         // 
         this.lblDescription.AllowDrop = true;
         this.lblDescription.AutoSize = true;
         this.lblDescription.BackColor = Mobilize.Web.SystemColors.Control;
         this.lblDescription.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblDescription.ForeColor = System.Drawing.Color.Black;
         this.lblDescription.Location = new System.Drawing.Point(164, 80);
         this.lblDescription.Name = "lblDescription";
         this.lblDescription.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblDescription.Size = new System.Drawing.Size(199, 13);
         this.lblDescription.TabIndex = 2;
         this.lblDescription.Text = "Order Processing Software by Mobilize.net";
         // 
         // lblTitle
         // 
         this.lblTitle.AllowDrop = true;
         this.lblTitle.AutoSize = true;
         this.lblTitle.BackColor = Mobilize.Web.SystemColors.Control;
         this.lblTitle.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblTitle.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lblTitle.ForeColor = System.Drawing.Color.Black;
         this.lblTitle.Location = new System.Drawing.Point(163, 24);
         this.lblTitle.Name = "lblTitle";
         this.lblTitle.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblTitle.Size = new System.Drawing.Size(122, 13);
         this.lblTitle.TabIndex = 4;
         this.lblTitle.Text = "Salmon King Seafood";
         // 
         // _Line1_0
         // 
         this._Line1_0.AllowDrop = true;
         this._Line1_0.BackColor = System.Drawing.Color.White;
         this._Line1_0.Enabled = false;
         this._Line1_0.Location = new System.Drawing.Point(6, 148);
         this._Line1_0.Name = "_Line1_0";
         this._Line1_0.Size = new System.Drawing.Size(293, 1);
         this._Line1_0.Visible = true;
         // 
         // lblVersion
         // 
         this.lblVersion.AllowDrop = true;
         this.lblVersion.AutoSize = true;
         this.lblVersion.BackColor = Mobilize.Web.SystemColors.Control;
         this.lblVersion.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblVersion.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.lblVersion.Location = new System.Drawing.Point(163, 56);
         this.lblVersion.Name = "lblVersion";
         this.lblVersion.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblVersion.Size = new System.Drawing.Size(137, 13);
         this.lblVersion.TabIndex = 5;
         this.lblVersion.Text = "Version: Mobilize - WebMAP ";
         // 
         // lblDisclaimer
         // 
         this.lblDisclaimer.AllowDrop = true;
         this.lblDisclaimer.AutoSize = true;
         this.lblDisclaimer.BackColor = Mobilize.Web.SystemColors.Control;
         this.lblDisclaimer.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblDisclaimer.ForeColor = System.Drawing.Color.Black;
         this.lblDisclaimer.Location = new System.Drawing.Point(17, 175);
         this.lblDisclaimer.Name = "lblDisclaimer";
         this.lblDisclaimer.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblDisclaimer.Size = new System.Drawing.Size(132, 13);
         this.lblDisclaimer.TabIndex = 3;
         this.lblDisclaimer.Text = "Copyright 2018 Mobilize.Net";
         // 
         // frmAbout
         // 
         this.AcceptButton = this.cmdOK;
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = Mobilize.Web.SystemColors.Control;
         this.CancelButton = this.cmdOK;
         this.Properties().ClientSize = new System.Drawing.Size(394, 237);
         this.Controls.Add(this.picIcon);
         this.Controls.Add(this.cmdOK);
         this.Controls.Add(this._Line1_1);
         this.Controls.Add(this.lblDescription);
         this.Controls.Add(this.lblTitle);
         this.Controls.Add(this._Line1_0);
         this.Controls.Add(this.lblVersion);
         this.Controls.Add(this.lblDisclaimer);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedDialog;
         this.Properties().Location = new System.Drawing.Point(156, 129);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmAbout";
         this.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Properties().ShowInTaskbar = false;
         this.Text = "About Salmon King Seafood";
         this.Closed += new System.EventHandler(this.Form_Closed);
         this.ResumeLayout(false);

#line hidden
this.Controls.DesignTime=false;
#line 242
      }

      void ReLoadForm(bool addEvents)
      {
      	InitializeLine1();
      }

      void InitializeLine1()
      {
      	this.Line1 = new Mobilize.Web.Label[2];
      	this.Line1[1] = _Line1_1;
      	this.Line1[0] = _Line1_0;
      }
      #endregion

   }
}
#pragma warning restore
