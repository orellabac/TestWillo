#pragma warning disable
#line 1 "frmAddProductTo.Designer.cs"
#pragma warning disable
#line 1 "frmAddProductTo.Designer.cs"
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmAddProductTo
   {

      [Intercepted]

      #region "Upgrade Support "
      private static frmAddProductTo m_vb6FormDefInstance 
#line 13
                                                          { 
#line 13
                                                            get                                                               
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (SKS.frmAddProductTo)catalog.frmAddProductTo.m_vb6FormDefInstance;} 
#line 13

#line 13
                                                                 set                                                                    
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmAddProductTo.m_vb6FormDefInstance = value;} 
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
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (bool)catalog.frmAddProductTo.m_InitializingDefInstance;} 
#line 16

#line 16
                                                           set                                                              
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmAddProductTo.m_InitializingDefInstance = value;} 
#line 16
                                                                }

#line 17

      [Intercepted]
      public static frmAddProductTo DefInstance
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

      public static frmAddProductTo CreateInstance()
      {
      	frmAddProductTo theInstance = new frmAddProductTo();
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
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_visualControls)<=0){this.visualControls_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<string[]>(this,_Mobilize_References,3);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_visualControls;}return this.visualControls_k__BackingField;} 
#line 47

#line 47
                                             set                                                
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<string[] >(this,_Mobilize_References,3,this.visualControls_k__BackingField,(string[])value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_visualControls;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_visualControls;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.visualControls_k__BackingField=(string[])value;} 
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
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_components)<=0){this.components_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<System.ComponentModel.IContainer>(this,_Mobilize_References,4);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_components;}return this.components_k__BackingField;} 
#line 52

#line 52
                                                         set                                                            
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<      System.ComponentModel.IContainer >(this,_Mobilize_References,4,this.components_k__BackingField,(System.ComponentModel.IContainer)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_components;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_components;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.components_k__BackingField=(System.ComponentModel.IContainer)value;} 
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
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_ToolTipMain)<=0){this.ToolTipMain_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<Mobilize.Web.ToolTip>(this,_Mobilize_References,5);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_ToolTipMain;}return this.ToolTipMain_k__BackingField;} 
#line 55

#line 55
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Mobilize.Web.ToolTip >(this,_Mobilize_References,5,this.ToolTipMain_k__BackingField,(Mobilize.Web.ToolTip)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_ToolTipMain;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_ToolTipMain;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.ToolTipMain_k__BackingField=(Mobilize.Web.ToolTip)value;} 
#line 55
                                                          }

#line 56

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.CheckBox chkAll_k__BackingField;
#line 58


      [Intercepted]
      public Mobilize.Web.CheckBox chkAll 
#line 58
                                          { 
#line 58
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_chkAll)<=0){this.chkAll_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.CheckBox>(this,_Mobilize_References,6);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_chkAll;;} return this.chkAll_k__BackingField; } 
#line 58

#line 58
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.CheckBox>(this,_Mobilize_References,6,this.chkAll_k__BackingField,(Mobilize.Web.CheckBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_chkAll;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_chkAll;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.chkAll_k__BackingField=(Mobilize.Web.CheckBox)value;} 
#line 58
                                                      }

#line 59

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdRemove_k__BackingField;
#line 61


      [Intercepted]
      public Mobilize.Web.Button cmdRemove 
#line 61
                                           { 
#line 61
                                             get                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdRemove)<=0){this.cmdRemove_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,7);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdRemove;;} return this.cmdRemove_k__BackingField; } 
#line 61

#line 61
                                                  set                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,7,this.cmdRemove_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdRemove;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdRemove;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdRemove_k__BackingField=(Mobilize.Web.Button)value;} 
#line 61
                                                       }

#line 62

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel1_k__BackingField;
#line 64


      [Intercepted]
      public Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel1 
#line 64
                                                                         { 
#line 64
                                                                           get                                                                              
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_sbStatusBar_Panels_Panel1)<=0){this.sbStatusBar_Panels_Panel1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripStatusLabel>(this,_Mobilize_References,8);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar_Panels_Panel1;;} return this.sbStatusBar_Panels_Panel1_k__BackingField; } 
#line 64

#line 64
                                                                                set                                                                                   
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripStatusLabel>(this,_Mobilize_References,8,this.sbStatusBar_Panels_Panel1_k__BackingField,(Mobilize.Web.ToolStripStatusLabel)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_sbStatusBar_Panels_Panel1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar_Panels_Panel1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.sbStatusBar_Panels_Panel1_k__BackingField=(Mobilize.Web.ToolStripStatusLabel)value;} 
#line 64
                                                                                     }

#line 65

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.StatusStrip sbStatusBar_k__BackingField;
#line 67


      [Intercepted]
      public Mobilize.Web.StatusStrip sbStatusBar 
#line 67
                                                  { 
#line 67
                                                    get                                                       
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_sbStatusBar)<=0){this.sbStatusBar_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.StatusStrip>(this,_Mobilize_References,9);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar;;} return this.sbStatusBar_k__BackingField; } 
#line 67

#line 67
                                                         set                                                            
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.StatusStrip>(this,_Mobilize_References,9,this.sbStatusBar_k__BackingField,(Mobilize.Web.StatusStrip)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_sbStatusBar;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.sbStatusBar_k__BackingField=(Mobilize.Web.StatusStrip)value;} 
#line 67
                                                              }

#line 68

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdClose_k__BackingField;
#line 70


      [Intercepted]
      public Mobilize.Web.Button cmdClose 
#line 70
                                          { 
#line 70
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdClose)<=0){this.cmdClose_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,10);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdClose;;} return this.cmdClose_k__BackingField; } 
#line 70

#line 70
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,10,this.cmdClose_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdClose;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdClose;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdClose_k__BackingField=(Mobilize.Web.Button)value;} 
#line 70
                                                      }

#line 71

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdSave_k__BackingField;
#line 73


      [Intercepted]
      public Mobilize.Web.Button cmdSave 
#line 73
                                         { 
#line 73
                                           get                                              
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdSave)<=0){this.cmdSave_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,11);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdSave;;} return this.cmdSave_k__BackingField; } 
#line 73

#line 73
                                                set                                                   
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,11,this.cmdSave_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdSave;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdSave;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdSave_k__BackingField=(Mobilize.Web.Button)value;} 
#line 73
                                                     }

#line 74

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdProducts_k__BackingField;
#line 76


      [Intercepted]
      public Mobilize.Web.Button cmdProducts 
#line 76
                                             { 
#line 76
                                               get                                                  
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdProducts)<=0){this.cmdProducts_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,12);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdProducts;;} return this.cmdProducts_k__BackingField; } 
#line 76

#line 76
                                                    set                                                       
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,12,this.cmdProducts_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdProducts;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdProducts;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdProducts_k__BackingField=(Mobilize.Web.Button)value;} 
#line 76
                                                         }

#line 77

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtName_k__BackingField;
#line 79


      [Intercepted]
      public Mobilize.Web.TextBox txtName 
#line 79
                                          { 
#line 79
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtName)<=0){this.txtName_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,13);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtName;;} return this.txtName_k__BackingField; } 
#line 79

#line 79
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,13,this.txtName_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtName;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtName;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtName_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 79
                                                      }

#line 80

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtCode_k__BackingField;
#line 82


      [Intercepted]
      public Mobilize.Web.TextBox txtCode 
#line 82
                                          { 
#line 82
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtCode)<=0){this.txtCode_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,14);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtCode;;} return this.txtCode_k__BackingField; } 
#line 82

#line 82
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,14,this.txtCode_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtCode;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtCode;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtCode_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 82
                                                      }

#line 83

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_1__k__BackingField;
#line 85


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_1_ 
#line 85
                                                                          { 
#line 85
                                                                            get                                                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProducts_ColumnHeader_1_)<=0){this.lvProducts_ColumnHeader_1__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,15);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_1_;;} return this.lvProducts_ColumnHeader_1__k__BackingField; } 
#line 85

#line 85
                                                                                 set                                                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,15,this.lvProducts_ColumnHeader_1__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lvProducts_ColumnHeader_1_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_1_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProducts_ColumnHeader_1__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 85
                                                                                      }

#line 86

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_2__k__BackingField;
#line 88


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_2_ 
#line 88
                                                                          { 
#line 88
                                                                            get                                                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProducts_ColumnHeader_2_)<=0){this.lvProducts_ColumnHeader_2__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,16);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_2_;;} return this.lvProducts_ColumnHeader_2__k__BackingField; } 
#line 88

#line 88
                                                                                 set                                                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,16,this.lvProducts_ColumnHeader_2__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lvProducts_ColumnHeader_2_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_2_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProducts_ColumnHeader_2__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 88
                                                                                      }

#line 89

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_3__k__BackingField;
#line 91


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_3_ 
#line 91
                                                                          { 
#line 91
                                                                            get                                                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProducts_ColumnHeader_3_)<=0){this.lvProducts_ColumnHeader_3__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,17);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_3_;;} return this.lvProducts_ColumnHeader_3__k__BackingField; } 
#line 91

#line 91
                                                                                 set                                                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,17,this.lvProducts_ColumnHeader_3__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lvProducts_ColumnHeader_3_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_3_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProducts_ColumnHeader_3__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 91
                                                                                      }

#line 92

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_4__k__BackingField;
#line 94


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_4_ 
#line 94
                                                                          { 
#line 94
                                                                            get                                                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProducts_ColumnHeader_4_)<=0){this.lvProducts_ColumnHeader_4__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,18);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_4_;;} return this.lvProducts_ColumnHeader_4__k__BackingField; } 
#line 94

#line 94
                                                                                 set                                                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,18,this.lvProducts_ColumnHeader_4__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lvProducts_ColumnHeader_4_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_4_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProducts_ColumnHeader_4__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 94
                                                                                      }

#line 95

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_5__k__BackingField;
#line 97


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_5_ 
#line 97
                                                                          { 
#line 97
                                                                            get                                                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProducts_ColumnHeader_5_)<=0){this.lvProducts_ColumnHeader_5__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,19);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_5_;;} return this.lvProducts_ColumnHeader_5__k__BackingField; } 
#line 97

#line 97
                                                                                 set                                                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,19,this.lvProducts_ColumnHeader_5__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lvProducts_ColumnHeader_5_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_5_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProducts_ColumnHeader_5__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 97
                                                                                      }

#line 98

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_6__k__BackingField;
#line 100


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_6_ 
#line 100
                                                                          { 
#line 100
                                                                            get                                                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProducts_ColumnHeader_6_)<=0){this.lvProducts_ColumnHeader_6__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,20);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_6_;;} return this.lvProducts_ColumnHeader_6__k__BackingField; } 
#line 100

#line 100
                                                                                 set                                                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,20,this.lvProducts_ColumnHeader_6__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lvProducts_ColumnHeader_6_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_6_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProducts_ColumnHeader_6__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 100
                                                                                      }

#line 101

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_7__k__BackingField;
#line 103


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_7_ 
#line 103
                                                                          { 
#line 103
                                                                            get                                                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProducts_ColumnHeader_7_)<=0){this.lvProducts_ColumnHeader_7__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,21);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_7_;;} return this.lvProducts_ColumnHeader_7__k__BackingField; } 
#line 103

#line 103
                                                                                 set                                                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,21,this.lvProducts_ColumnHeader_7__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lvProducts_ColumnHeader_7_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_7_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProducts_ColumnHeader_7__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 103
                                                                                      }

#line 104

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListView lvProducts_k__BackingField;
#line 106


      [Intercepted]
      public Mobilize.Web.ListView lvProducts 
#line 106
                                              { 
#line 106
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProducts)<=0){this.lvProducts_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListView>(this,_Mobilize_References,22);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts;;} return this.lvProducts_k__BackingField; } 
#line 106

#line 106
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListView>(this,_Mobilize_References,22,this.lvProducts_k__BackingField,(Mobilize.Web.ListView)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lvProducts;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProducts_k__BackingField=(Mobilize.Web.ListView)value;} 
#line 106
                                                          }

#line 107

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label4_k__BackingField;
#line 109


      [Intercepted]
      public Mobilize.Web.Label Label4 
#line 109
                                       { 
#line 109
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label4)<=0){this.Label4_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,23);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label4;;} return this.Label4_k__BackingField; } 
#line 109

#line 109
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,23,this.Label4_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label4;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label4;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label4_k__BackingField=(Mobilize.Web.Label)value;} 
#line 109
                                                   }

#line 110

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label5_k__BackingField;
#line 112


      [Intercepted]
      public Mobilize.Web.Label Label5 
#line 112
                                       { 
#line 112
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label5)<=0){this.Label5_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,24);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label5;;} return this.Label5_k__BackingField; } 
#line 112

#line 112
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,24,this.Label5_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label5;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label5;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label5_k__BackingField=(Mobilize.Web.Label)value;} 
#line 112
                                                   }

#line 113

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.GroupBox Frame1_k__BackingField;
#line 115


      [Intercepted]
      public Mobilize.Web.GroupBox Frame1 
#line 115
                                          { 
#line 115
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Frame1)<=0){this.Frame1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.GroupBox>(this,_Mobilize_References,25);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Frame1;;} return this.Frame1_k__BackingField; } 
#line 115

#line 115
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.GroupBox>(this,_Mobilize_References,25,this.Frame1_k__BackingField,(Mobilize.Web.GroupBox)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Frame1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Frame1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Frame1_k__BackingField=(Mobilize.Web.GroupBox)value;} 
#line 115
                                                      }

#line 116

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProductsBy_ColumnHeader_1__k__BackingField;
#line 118


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProductsBy_ColumnHeader_1_ 
#line 118
                                                                            { 
#line 118
                                                                              get                                                                                 
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProductsBy_ColumnHeader_1_)<=0){this.lvProductsBy_ColumnHeader_1__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,26);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProductsBy_ColumnHeader_1_;;} return this.lvProductsBy_ColumnHeader_1__k__BackingField; } 
#line 118

#line 118
                                                                                   set                                                                                      
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,26,this.lvProductsBy_ColumnHeader_1__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvProductsBy_ColumnHeader_1_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProductsBy_ColumnHeader_1_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProductsBy_ColumnHeader_1__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 118
                                                                                        }

#line 119

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProductsBy_ColumnHeader_2__k__BackingField;
#line 121


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProductsBy_ColumnHeader_2_ 
#line 121
                                                                            { 
#line 121
                                                                              get                                                                                 
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProductsBy_ColumnHeader_2_)<=0){this.lvProductsBy_ColumnHeader_2__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,27);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProductsBy_ColumnHeader_2_;;} return this.lvProductsBy_ColumnHeader_2__k__BackingField; } 
#line 121

#line 121
                                                                                   set                                                                                      
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,27,this.lvProductsBy_ColumnHeader_2__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvProductsBy_ColumnHeader_2_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProductsBy_ColumnHeader_2_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProductsBy_ColumnHeader_2__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 121
                                                                                        }

#line 122

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProductsBy_ColumnHeader_3__k__BackingField;
#line 124


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProductsBy_ColumnHeader_3_ 
#line 124
                                                                            { 
#line 124
                                                                              get                                                                                 
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProductsBy_ColumnHeader_3_)<=0){this.lvProductsBy_ColumnHeader_3__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,28);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProductsBy_ColumnHeader_3_;;} return this.lvProductsBy_ColumnHeader_3__k__BackingField; } 
#line 124

#line 124
                                                                                   set                                                                                      
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,28,this.lvProductsBy_ColumnHeader_3__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvProductsBy_ColumnHeader_3_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProductsBy_ColumnHeader_3_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProductsBy_ColumnHeader_3__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 124
                                                                                        }

#line 125

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProductsBy_ColumnHeader_4__k__BackingField;
#line 127


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProductsBy_ColumnHeader_4_ 
#line 127
                                                                            { 
#line 127
                                                                              get                                                                                 
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProductsBy_ColumnHeader_4_)<=0){this.lvProductsBy_ColumnHeader_4__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,29);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProductsBy_ColumnHeader_4_;;} return this.lvProductsBy_ColumnHeader_4__k__BackingField; } 
#line 127

#line 127
                                                                                   set                                                                                      
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,29,this.lvProductsBy_ColumnHeader_4__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvProductsBy_ColumnHeader_4_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProductsBy_ColumnHeader_4_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProductsBy_ColumnHeader_4__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 127
                                                                                        }

#line 128

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListView lvProductsBy_k__BackingField;
#line 130


      [Intercepted]
      public Mobilize.Web.ListView lvProductsBy 
#line 130
                                                { 
#line 130
                                                  get                                                     
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProductsBy)<=0){this.lvProductsBy_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListView>(this,_Mobilize_References,30);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProductsBy;;} return this.lvProductsBy_k__BackingField; } 
#line 130

#line 130
                                                       set                                                          
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListView>(this,_Mobilize_References,30,this.lvProductsBy_k__BackingField,(Mobilize.Web.ListView)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvProductsBy;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProductsBy;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProductsBy_k__BackingField=(Mobilize.Web.ListView)value;} 
#line 130
                                                            }

#line 131

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label lblProductsRelated_k__BackingField;
#line 133


      [Intercepted]
      public Mobilize.Web.Label lblProductsRelated 
#line 133
                                                   { 
#line 133
                                                     get                                                        
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lblProductsRelated)<=0){this.lblProductsRelated_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,31);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lblProductsRelated;;} return this.lblProductsRelated_k__BackingField; } 
#line 133

#line 133
                                                          set                                                             
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,31,this.lblProductsRelated_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lblProductsRelated;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lblProductsRelated;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lblProductsRelated_k__BackingField=(Mobilize.Web.Label)value;} 
#line 133
                                                               }

#line 134

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListView listViewHelper1_k__BackingField;
#line 136


      [Intercepted]
      private Mobilize.Web.ListView listViewHelper1 
#line 136
                                                    { 
#line 136
                                                      get                                                         
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_listViewHelper1)<=0){this.listViewHelper1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListView>(this,_Mobilize_References,32);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_listViewHelper1;;} return this.listViewHelper1_k__BackingField; } 
#line 136

#line 136
                                                           set                                                              
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListView>(this,_Mobilize_References,32,this.listViewHelper1_k__BackingField,(Mobilize.Web.ListView)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_listViewHelper1;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_listViewHelper1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.listViewHelper1_k__BackingField=(Mobilize.Web.ListView)value;} 
#line 136
                                                                }

#line 137
      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.

      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {

#line hidden
this.Controls.DesignTime=true;
#line 145
      	this.components = new System.ComponentModel.Container();
      	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProductTo));
      	this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
      	this.chkAll = new Mobilize.Web.CheckBox();
      	this.cmdRemove = new Mobilize.Web.Button();
      	this.sbStatusBar = new Mobilize.Web.StatusStrip();
      	this.sbStatusBar_Panels_Panel1 = new Mobilize.Web.ToolStripStatusLabel();
      	this.cmdClose = new Mobilize.Web.Button();
      	this.cmdSave = new Mobilize.Web.Button();
      	this.Frame1 = new Mobilize.Web.GroupBox();
      	this.cmdProducts = new Mobilize.Web.Button();
      	this.txtName = new Mobilize.Web.TextBox();
      	this.txtCode = new Mobilize.Web.TextBox();
      	this.lvProducts = new Mobilize.Web.ListView();
      	this.lvProducts_ColumnHeader_1_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProducts_ColumnHeader_2_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProducts_ColumnHeader_3_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProducts_ColumnHeader_4_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProducts_ColumnHeader_5_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProducts_ColumnHeader_6_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProducts_ColumnHeader_7_ = new Mobilize.Web.ListViewColumnHeader();
      	this.Label4 = new Mobilize.Web.Label();
      	this.Label5 = new Mobilize.Web.Label();
      	this.lvProductsBy = new Mobilize.Web.ListView();
      	this.lvProductsBy_ColumnHeader_1_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProductsBy_ColumnHeader_2_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProductsBy_ColumnHeader_3_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProductsBy_ColumnHeader_4_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lblProductsRelated = new Mobilize.Web.Label();
      	this.sbStatusBar.SuspendLayout();
      	this.Frame1.SuspendLayout();
      	this.lvProducts.SuspendLayout();
      	this.lvProductsBy.SuspendLayout();
      	this.SuspendLayout();
      	this.listViewHelper1 = new Mobilize.Web.ListView(this.components);
      	// 
      	// chkAll
      	// 
      	this.chkAll.AllowDrop = true;
      	this.chkAll.Appearance = Mobilize.Web.Appearance.Normal;
         this.chkAll.BackColor = Mobilize.Web.SystemColors.Control;
         this.chkAll.CausesValidation = true;
         this.chkAll.CheckAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.chkAll.CheckState = Mobilize.Web.CheckState.Unchecked;
         this.chkAll.Enabled = true;
         this.chkAll.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.chkAll.Location = new System.Drawing.Point(112, 454);
         this.chkAll.Name = "chkAll";
         this.chkAll.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.chkAll.Size = new System.Drawing.Size(81, 17);
         this.chkAll.TabIndex = 13;
         this.chkAll.TabStop = false;
         this.chkAll.Text = "Check All";
         this.chkAll.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.chkAll.Visible = true;
         this.chkAll.CheckStateChanged += new System.EventHandler(this.chkAll_CheckStateChanged);
         // 
         // cmdRemove
         // 
         this.cmdRemove.AllowDrop = true;
         this.cmdRemove.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdRemove.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdRemove.Location = new System.Drawing.Point(8, 448);
         this.cmdRemove.Name = "cmdRemove";
         this.cmdRemove.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdRemove.Size = new System.Drawing.Size(97, 25);
         this.cmdRemove.TabIndex = 12;
         this.cmdRemove.TabStop = false;
         this.cmdRemove.Text = "&Remove ";
         this.cmdRemove.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdRemove.UseVisualStyleBackColor = false;
         this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
         // 
         // sbStatusBar
         // 
         this.sbStatusBar.AllowDrop = true;
         this.sbStatusBar.Properties().BackColor = Mobilize.Web.SystemColors.Control;
         this.sbStatusBar.Dock = Mobilize.Web.DockStyle.Bottom;
         this.sbStatusBar.Location = new System.Drawing.Point(0, 488);
         this.sbStatusBar.Name = "sbStatusBar";
         this.sbStatusBar.Properties().ShowItemToolTips = true;
         this.sbStatusBar.Size = new System.Drawing.Size(424, 23);
         this.sbStatusBar.TabIndex = 11;
         this.sbStatusBar.Items.AddRange(new Mobilize.Web.ToolStripItem[]{this.sbStatusBar_Panels_Panel1});
         // 
         // sbStatusBar_Panels_Panel1
         // 
         this.sbStatusBar_Panels_Panel1.Properties().BorderSides = (Mobilize.Web.ToolStripStatusLabelBorderSides) (Mobilize.Web.ToolStripStatusLabelBorderSides.Left | Mobilize.Web.ToolStripStatusLabelBorderSides.Top | Mobilize.Web.ToolStripStatusLabelBorderSides.Right | Mobilize.Web.ToolStripStatusLabelBorderSides.Bottom);
         this.sbStatusBar_Panels_Panel1.Properties().BorderStyle = Mobilize.Web.Border3DStyle.SunkenOuter;
         this.sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
         this.sbStatusBar_Panels_Panel1.Margin = new Mobilize.Web.Padding(0);
         this.sbStatusBar_Panels_Panel1.Properties().Size = new System.Drawing.Size(423, 23);
         this.sbStatusBar_Panels_Panel1.Properties().Spring = true;
         this.sbStatusBar_Panels_Panel1.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.sbStatusBar_Panels_Panel1.TextImageRelation = Mobilize.Web.TextImageRelation.ImageBeforeText;
         // 
         // cmdClose
         // 
         this.cmdClose.AllowDrop = true;
         this.cmdClose.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdClose.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdClose.Location = new System.Drawing.Point(328, 448);
         this.cmdClose.Name = "cmdClose";
         this.cmdClose.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdClose.Size = new System.Drawing.Size(89, 25);
         this.cmdClose.TabIndex = 7;
         this.cmdClose.Text = "&Close";
         this.cmdClose.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdClose.UseVisualStyleBackColor = false;
         this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
         // 
         // cmdSave
         // 
         this.cmdSave.AllowDrop = true;
         this.cmdSave.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdSave.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdSave.Location = new System.Drawing.Point(224, 448);
         this.cmdSave.Name = "cmdSave";
         this.cmdSave.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdSave.Size = new System.Drawing.Size(89, 25);
         this.cmdSave.TabIndex = 6;
         this.cmdSave.Text = "&Save";
         this.cmdSave.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdSave.UseVisualStyleBackColor = false;
         this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
         // 
         // Frame1
         // 
         this.Frame1.AllowDrop = true;
         this.Frame1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Frame1.Controls.Add(this.cmdProducts);
         this.Frame1.Controls.Add(this.txtName);
         this.Frame1.Controls.Add(this.txtCode);
         this.Frame1.Controls.Add(this.lvProducts);
         this.Frame1.Controls.Add(this.Label4);
         this.Frame1.Controls.Add(this.Label5);
         this.Frame1.Enabled = true;
         this.Frame1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Frame1.Location = new System.Drawing.Point(8, 8);
         this.Frame1.Name = "Frame1";
         this.Frame1.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Frame1.Size = new System.Drawing.Size(409, 233);
         this.Frame1.TabIndex = 4;
         this.Frame1.Text = "Search product ";
         this.Frame1.Visible = true;
         // 
         // cmdProducts
         // 
         this.cmdProducts.AllowDrop = true;
         this.cmdProducts.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdProducts.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdProducts.Location = new System.Drawing.Point(360, 16);
         this.cmdProducts.Name = "cmdProducts";
         this.cmdProducts.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdProducts.Size = new System.Drawing.Size(25, 21);
         this.cmdProducts.TabIndex = 5;
         this.cmdProducts.TabStop = false;
         this.cmdProducts.Text = "...";
         this.cmdProducts.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdProducts.UseVisualStyleBackColor = false;
         this.cmdProducts.Click += new System.EventHandler(this.cmdProducts_Click);
         // 
         // txtName
         // 
         this.txtName.AcceptsReturn = true;
         this.txtName.AllowDrop = true;
         this.txtName.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtName.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtName.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtName.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtName.Location = new System.Drawing.Point(112, 40);
         this.txtName.MaxLength = 0;
         this.txtName.Name = "txtName";
         this.txtName.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtName.Size = new System.Drawing.Size(145, 20);
         this.txtName.TabIndex = 1;
         this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
         // 
         // txtCode
         // 
         this.txtCode.AcceptsReturn = true;
         this.txtCode.AllowDrop = true;
         this.txtCode.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtCode.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtCode.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtCode.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtCode.Location = new System.Drawing.Point(112, 16);
         this.txtCode.MaxLength = 0;
         this.txtCode.Name = "txtCode";
         this.txtCode.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtCode.Size = new System.Drawing.Size(97, 20);
         this.txtCode.TabIndex = 0;
         this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
         this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
         // 
         // lvProducts
         // 
         this.lvProducts.AllowDrop = true;
         this.lvProducts.BackColor = Mobilize.Web.SystemColors.Window;
         this.lvProducts.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.lvProducts.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.lvProducts.FullRowSelect = true;
         this.lvProducts.GridLines = true;
         this.lvProducts.HideSelection = false;
         this.lvProducts.Properties().HotTracking = true;
         this.lvProducts.LabelEdit = false;
         this.lvProducts.Location = new System.Drawing.Point(8, 64);
         this.lvProducts.MultiSelect = false;
         this.lvProducts.Name = "lvProducts";
         this.lvProducts.Size = new System.Drawing.Size(393, 161);
         this.lvProducts.TabIndex = 2;
         this.lvProducts.View = Mobilize.Web.ListViewMode.Details;
         this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_1_);
         this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_2_);
         this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_3_);
         this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_4_);
         this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_5_);
         this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_6_);
         this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_7_);
         // 
         // lvProducts_ColumnHeader_1_
         // 
         this.lvProducts_ColumnHeader_1_.Text = "Code";
         this.lvProducts_ColumnHeader_1_.Width = 97;
         // 
         // lvProducts_ColumnHeader_2_
         // 
         this.lvProducts_ColumnHeader_2_.Text = "Name";
         this.lvProducts_ColumnHeader_2_.Width = 97;
         // 
         // lvProducts_ColumnHeader_3_
         // 
         this.lvProducts_ColumnHeader_3_.Text = "Price";
         this.lvProducts_ColumnHeader_3_.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this.lvProducts_ColumnHeader_3_.Width = 97;
         // 
         // lvProducts_ColumnHeader_4_
         // 
         this.lvProducts_ColumnHeader_4_.Text = "Existence";
         this.lvProducts_ColumnHeader_4_.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this.lvProducts_ColumnHeader_4_.Width = 97;
         // 
         // lvProducts_ColumnHeader_5_
         // 
         this.lvProducts_ColumnHeader_5_.Text = "Ordered";
         this.lvProducts_ColumnHeader_5_.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this.lvProducts_ColumnHeader_5_.Width = 97;
         // 
         // lvProducts_ColumnHeader_6_
         // 
         this.lvProducts_ColumnHeader_6_.Text = "Qty per Unit";
         this.lvProducts_ColumnHeader_6_.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this.lvProducts_ColumnHeader_6_.Width = 97;
         // 
         // lvProducts_ColumnHeader_7_
         // 
         this.lvProducts_ColumnHeader_7_.Text = "Unit";
         this.lvProducts_ColumnHeader_7_.Width = 97;
         // 
         // Label4
         // 
         this.Label4.AllowDrop = true;
         this.Label4.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label4.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label4.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label4.Location = new System.Drawing.Point(16, 40);
         this.Label4.Name = "Label4";
         this.Label4.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label4.Size = new System.Drawing.Size(89, 17);
         this.Label4.TabIndex = 9;
         this.Label4.Text = "Name";
         // 
         // Label5
         // 
         this.Label5.AllowDrop = true;
         this.Label5.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label5.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label5.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label5.Location = new System.Drawing.Point(16, 16);
         this.Label5.Name = "Label5";
         this.Label5.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label5.Size = new System.Drawing.Size(89, 17);
         this.Label5.TabIndex = 8;
         this.Label5.Text = "Code";
         // 
         // lvProductsBy
         // 
         this.lvProductsBy.AllowDrop = true;
         this.lvProductsBy.BackColor = Mobilize.Web.SystemColors.Window;
         this.lvProductsBy.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.lvProductsBy.CheckBoxes = true;
         this.lvProductsBy.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.lvProductsBy.FullRowSelect = true;
         this.lvProductsBy.GridLines = true;
         this.lvProductsBy.HideSelection = false;
         this.lvProductsBy.Properties().HotTracking = true;
         this.lvProductsBy.LabelEdit = false;
         this.lvProductsBy.Location = new System.Drawing.Point(8, 272);
         this.lvProductsBy.MultiSelect = false;
         this.lvProductsBy.Name = "lvProductsBy";
         this.lvProductsBy.Size = new System.Drawing.Size(409, 169);
         this.lvProductsBy.TabIndex = 3;
         this.lvProductsBy.View = Mobilize.Web.ListViewMode.Details;
         this.lvProductsBy.Columns.Add(this.lvProductsBy_ColumnHeader_1_);
         this.lvProductsBy.Columns.Add(this.lvProductsBy_ColumnHeader_2_);
         this.lvProductsBy.Columns.Add(this.lvProductsBy_ColumnHeader_3_);
         this.lvProductsBy.Columns.Add(this.lvProductsBy_ColumnHeader_4_);
         // 
         // lvProductsBy_ColumnHeader_1_
         // 
         this.lvProductsBy_ColumnHeader_1_.Text = "Code";
         this.lvProductsBy_ColumnHeader_1_.Width = 97;
         // 
         // lvProductsBy_ColumnHeader_2_
         // 
         this.lvProductsBy_ColumnHeader_2_.Text = "Name";
         this.lvProductsBy_ColumnHeader_2_.Width = 97;
         // 
         // lvProductsBy_ColumnHeader_3_
         // 
         this.lvProductsBy_ColumnHeader_3_.Text = "Price";
         this.lvProductsBy_ColumnHeader_3_.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this.lvProductsBy_ColumnHeader_3_.Width = 61;
         // 
         // lvProductsBy_ColumnHeader_4_
         // 
         this.lvProductsBy_ColumnHeader_4_.Text = "Quantity per Unit";
         this.lvProductsBy_ColumnHeader_4_.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this.lvProductsBy_ColumnHeader_4_.Width = 94;
         // 
         // lblProductsRelated
         // 
         this.lblProductsRelated.AllowDrop = true;
         this.lblProductsRelated.BackColor = Mobilize.Web.SystemColors.Control;
         this.lblProductsRelated.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblProductsRelated.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.lblProductsRelated.Location = new System.Drawing.Point(8, 248);
         this.lblProductsRelated.Name = "lblProductsRelated";
         this.lblProductsRelated.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblProductsRelated.Size = new System.Drawing.Size(409, 17);
         this.lblProductsRelated.TabIndex = 10;
         this.lblProductsRelated.Text = "Products";
         // 
         // frmAddProductTo
         // 
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = Mobilize.Web.SystemColors.Control;
         this.Properties().ClientSize = new System.Drawing.Size(424, 511);
         this.Controls.Add(this.chkAll);
         this.Controls.Add(this.cmdRemove);
         this.Controls.Add(this.sbStatusBar);
         this.Controls.Add(this.cmdClose);
         this.Controls.Add(this.cmdSave);
         this.Controls.Add(this.Frame1);
         this.Controls.Add(this.lvProductsBy);
         this.Controls.Add(this.lblProductsRelated);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedSingle;
         this.Properties().Location = new System.Drawing.Point(3, 25);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmAddProductTo";
         this.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Text = "Create New Product Item";
         this.Closed += new System.EventHandler(this.Form_Closed);
         this.FormClosing += new Mobilize.Web.FormClosingEventHandler(this.Form_FormClosing);this.lvProducts.ItemClick += new Mobilize.Web.ListViewItemClickEventHandler(this.lvProducts_ItemClick);
         this.listViewHelper1.SetCorrectEventsBehavior(this.lvProducts, true);
         this.sbStatusBar.ResumeLayout(false);
         this.Frame1.ResumeLayout(false);
         this.lvProducts.ResumeLayout(false);
         this.lvProductsBy.ResumeLayout(false);
         this.ResumeLayout(false);

#line hidden
this.Controls.DesignTime=false;
#line 518
      }
      #endregion

   }
}
#pragma warning restore
