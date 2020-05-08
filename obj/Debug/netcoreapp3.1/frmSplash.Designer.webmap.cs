#pragma warning disable
#line 1 "frmSplash.Designer.cs"
#pragma warning disable
#line 1 "frmSplash.Designer.cs"
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmSplash
   {

      [Intercepted]

      #region "Upgrade Support "
      private static frmSplash m_vb6FormDefInstance 
#line 13
                                                    { 
#line 13
                                                      get                                                         
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (SKS.frmSplash)catalog.frmSplash.m_vb6FormDefInstance;} 
#line 13

#line 13
                                                           set                                                              
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmSplash.m_vb6FormDefInstance = value;} 
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
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (bool)catalog.frmSplash.m_InitializingDefInstance;} 
#line 16

#line 16
                                                           set                                                              
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmSplash.m_InitializingDefInstance = value;} 
#line 16
                                                                }

#line 17

      [Intercepted]
      public static frmSplash DefInstance
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

      public static frmSplash CreateInstance()
      {
      	frmSplash theInstance = new frmSplash();
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
private Mobilize.Web.Timer Timer1_k__BackingField;
#line 58


      [Intercepted]
      public Mobilize.Web.Timer Timer1 
#line 58
                                       { 
#line 58
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Timer1)<=0){this.Timer1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Timer>(this,_Mobilize_References,3);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Timer1;;} return this.Timer1_k__BackingField; } 
#line 58

#line 58
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Timer>(this,_Mobilize_References,3,this.Timer1_k__BackingField,(Mobilize.Web.Timer)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Timer1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Timer1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Timer1_k__BackingField=(Mobilize.Web.Timer)value;} 
#line 58
                                                   }

#line 59

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.PictureBox Image1_k__BackingField;
#line 61


      [Intercepted]
      public Mobilize.Web.PictureBox Image1 
#line 61
                                            { 
#line 61
                                              get                                                 
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Image1)<=0){this.Image1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.PictureBox>(this,_Mobilize_References,4);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Image1;;} return this.Image1_k__BackingField; } 
#line 61

#line 61
                                                   set                                                      
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.PictureBox>(this,_Mobilize_References,4,this.Image1_k__BackingField,(Mobilize.Web.PictureBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Image1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Image1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Image1_k__BackingField=(Mobilize.Web.PictureBox)value;} 
#line 61
                                                        }

#line 62
      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.

      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {

#line hidden
this.Controls.DesignTime=true;
#line 70
      	this.components = new System.ComponentModel.Container();
      	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
      	this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
      	this.Timer1 = new Mobilize.Web.Timer(components);
      	this.Image1 = new Mobilize.Web.PictureBox();
      	this.SuspendLayout();
      	// 
      	// Timer1
      	// 
      	this.Timer1.Enabled = true;
      	this.Timer1.Interval = 3000;
      	this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
      	// 
      	// Image1
      	// 
      	this.Image1.AllowDrop = true;
      	this.Image1.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Image1.Enabled = true;
         this.Image1.Image = "assets/images/SKS.frmSplash.Image1.Image.png";
         this.Image1.Location = new System.Drawing.Point(0, 0);
         this.Image1.Name = "Image1";
         this.Image1.Size = new System.Drawing.Size(964, 642);
         this.Image1.SizeMode = Mobilize.Web.PictureBoxSizeMode.StretchImage;
         this.Image1.Visible = true;
         // 
         // frmSplash
         // 
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = Mobilize.Web.SystemColors.Control;
         this.Properties().ClientSize = new System.Drawing.Size(943, 613);
         this.Controls.Add(this.Image1);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedDialog;
         this.KeyPreview = true;
         this.Properties().Location = new System.Drawing.Point(17, 116);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmSplash";
         this.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Properties().ShowInTaskbar = false;
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.CenterScreen;
         this.Closed += new System.EventHandler(this.Form_Closed);
         this.KeyPress += new Mobilize.Web.KeyPressEventHandler(this.Form_KeyPress);
         this.ResumeLayout(false);

#line hidden
this.Controls.DesignTime=false;
#line 115
      }
      #endregion

   }
}
#pragma warning restore
