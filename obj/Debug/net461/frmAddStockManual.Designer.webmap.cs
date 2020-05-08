#pragma warning disable
#line 1 "frmAddStockManual.Designer.cs"
#pragma warning disable
#line 1 "frmAddStockManual.Designer.cs"
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmAddStockManual
   {

      [Intercepted]

      #region "Upgrade Support "
      private static frmAddStockManual m_vb6FormDefInstance 
#line 13
                                                            { 
#line 13
                                                              get                                                                 
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (SKS.frmAddStockManual)catalog.frmAddStockManual.m_vb6FormDefInstance;} 
#line 13

#line 13
                                                                   set                                                                      
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmAddStockManual.m_vb6FormDefInstance = value;} 
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
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (bool)catalog.frmAddStockManual.m_InitializingDefInstance;} 
#line 16

#line 16
                                                           set                                                              
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmAddStockManual.m_InitializingDefInstance = value;} 
#line 16
                                                                }

#line 17

      [Intercepted]
      public static frmAddStockManual DefInstance
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

      public static frmAddStockManual CreateInstance()
      {
      	frmAddStockManual theInstance = new frmAddStockManual();
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
private Mobilize.Web.Button cmdSave_k__BackingField;
#line 59


      [Intercepted]
      public Mobilize.Web.Button cmdSave 
#line 59
                                         { 
#line 59
                                           get                                              
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdSave)<=0){this.cmdSave_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,3);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdSave;;} return this.cmdSave_k__BackingField; } 
#line 59

#line 59
                                                set                                                   
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,3,this.cmdSave_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdSave;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdSave;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdSave_k__BackingField=(Mobilize.Web.Button)value;} 
#line 59
                                                     }

#line 60

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdClose_k__BackingField;
#line 62


      [Intercepted]
      public Mobilize.Web.Button cmdClose 
#line 62
                                          { 
#line 62
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdClose)<=0){this.cmdClose_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,4);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdClose;;} return this.cmdClose_k__BackingField; } 
#line 62

#line 62
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,4,this.cmdClose_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdClose;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdClose;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdClose_k__BackingField=(Mobilize.Web.Button)value;} 
#line 62
                                                      }

#line 63

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel1_k__BackingField;
#line 65


      [Intercepted]
      public Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel1 
#line 65
                                                                         { 
#line 65
                                                                           get                                                                              
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_sbStatusBar_Panels_Panel1)<=0){this.sbStatusBar_Panels_Panel1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripStatusLabel>(this,_Mobilize_References,5);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar_Panels_Panel1;;} return this.sbStatusBar_Panels_Panel1_k__BackingField; } 
#line 65

#line 65
                                                                                set                                                                                   
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripStatusLabel>(this,_Mobilize_References,5,this.sbStatusBar_Panels_Panel1_k__BackingField,(Mobilize.Web.ToolStripStatusLabel)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_sbStatusBar_Panels_Panel1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar_Panels_Panel1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.sbStatusBar_Panels_Panel1_k__BackingField=(Mobilize.Web.ToolStripStatusLabel)value;} 
#line 65
                                                                                     }

#line 66

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.StatusStrip sbStatusBar_k__BackingField;
#line 68


      [Intercepted]
      public Mobilize.Web.StatusStrip sbStatusBar 
#line 68
                                                  { 
#line 68
                                                    get                                                       
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_sbStatusBar)<=0){this.sbStatusBar_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.StatusStrip>(this,_Mobilize_References,6);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar;;} return this.sbStatusBar_k__BackingField; } 
#line 68

#line 68
                                                         set                                                            
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.StatusStrip>(this,_Mobilize_References,6,this.sbStatusBar_k__BackingField,(Mobilize.Web.StatusStrip)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_sbStatusBar;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.sbStatusBar_k__BackingField=(Mobilize.Web.StatusStrip)value;} 
#line 68
                                                              }

#line 69

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtUnit_k__BackingField;
#line 71


      [Intercepted]
      public Mobilize.Web.TextBox txtUnit 
#line 71
                                          { 
#line 71
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtUnit)<=0){this.txtUnit_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,7);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtUnit;;} return this.txtUnit_k__BackingField; } 
#line 71

#line 71
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,7,this.txtUnit_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtUnit;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtUnit;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtUnit_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 71
                                                      }

#line 72

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtProductName_k__BackingField;
#line 74


      [Intercepted]
      public Mobilize.Web.TextBox txtProductName 
#line 74
                                                 { 
#line 74
                                                   get                                                      
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtProductName)<=0){this.txtProductName_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,8);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtProductName;;} return this.txtProductName_k__BackingField; } 
#line 74

#line 74
                                                        set                                                           
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,8,this.txtProductName_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtProductName;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtProductName;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtProductName_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 74
                                                             }

#line 75

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtQuantityPerUnit_k__BackingField;
#line 77


      [Intercepted]
      public Mobilize.Web.TextBox txtQuantityPerUnit 
#line 77
                                                     { 
#line 77
                                                       get                                                          
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtQuantityPerUnit)<=0){this.txtQuantityPerUnit_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,9);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtQuantityPerUnit;;} return this.txtQuantityPerUnit_k__BackingField; } 
#line 77

#line 77
                                                            set                                                               
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,9,this.txtQuantityPerUnit_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtQuantityPerUnit;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtQuantityPerUnit;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtQuantityPerUnit_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 77
                                                                 }

#line 78

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox _txtValues_2_k__BackingField;
#line 80


      [Intercepted]
      private Mobilize.Web.TextBox _txtValues_2 
#line 80
                                                { 
#line 80
                                                  get                                                     
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__txtValues_2)<=0){this._txtValues_2_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,10);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtValues_2;;} return this._txtValues_2_k__BackingField; } 
#line 80

#line 80
                                                       set                                                          
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,10,this._txtValues_2_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__txtValues_2;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtValues_2;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._txtValues_2_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 80
                                                            }

#line 81

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox _txtValues_1_k__BackingField;
#line 83


      [Intercepted]
      private Mobilize.Web.TextBox _txtValues_1 
#line 83
                                                { 
#line 83
                                                  get                                                     
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__txtValues_1)<=0){this._txtValues_1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,11);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtValues_1;;} return this._txtValues_1_k__BackingField; } 
#line 83

#line 83
                                                       set                                                          
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,11,this._txtValues_1_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__txtValues_1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtValues_1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._txtValues_1_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 83
                                                            }

#line 84

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox _txtValues_0_k__BackingField;
#line 86


      [Intercepted]
      private Mobilize.Web.TextBox _txtValues_0 
#line 86
                                                { 
#line 86
                                                  get                                                     
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__txtValues_0)<=0){this._txtValues_0_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,12);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtValues_0;;} return this._txtValues_0_k__BackingField; } 
#line 86

#line 86
                                                       set                                                          
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,12,this._txtValues_0_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__txtValues_0;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtValues_0;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._txtValues_0_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 86
                                                            }

#line 87

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdProducts_k__BackingField;
#line 89


      [Intercepted]
      public Mobilize.Web.Button cmdProducts 
#line 89
                                             { 
#line 89
                                               get                                                  
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdProducts)<=0){this.cmdProducts_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,13);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdProducts;;} return this.cmdProducts_k__BackingField; } 
#line 89

#line 89
                                                    set                                                       
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,13,this.cmdProducts_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdProducts;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdProducts;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdProducts_k__BackingField=(Mobilize.Web.Button)value;} 
#line 89
                                                         }

#line 90

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtName_k__BackingField;
#line 92


      [Intercepted]
      public Mobilize.Web.TextBox txtName 
#line 92
                                          { 
#line 92
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtName)<=0){this.txtName_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,14);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtName;;} return this.txtName_k__BackingField; } 
#line 92

#line 92
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,14,this.txtName_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtName;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtName;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtName_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 92
                                                      }

#line 93

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtCode_k__BackingField;
#line 95


      [Intercepted]
      public Mobilize.Web.TextBox txtCode 
#line 95
                                          { 
#line 95
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtCode)<=0){this.txtCode_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,15);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtCode;;} return this.txtCode_k__BackingField; } 
#line 95

#line 95
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,15,this.txtCode_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtCode;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtCode;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtCode_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 95
                                                      }

#line 96

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label4_k__BackingField;
#line 98


      [Intercepted]
      public Mobilize.Web.Label Label4 
#line 98
                                       { 
#line 98
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label4)<=0){this.Label4_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,16);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label4;;} return this.Label4_k__BackingField; } 
#line 98

#line 98
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,16,this.Label4_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label4;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label4;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label4_k__BackingField=(Mobilize.Web.Label)value;} 
#line 98
                                                   }

#line 99

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label5_k__BackingField;
#line 101


      [Intercepted]
      public Mobilize.Web.Label Label5 
#line 101
                                       { 
#line 101
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label5)<=0){this.Label5_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,17);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label5;;} return this.Label5_k__BackingField; } 
#line 101

#line 101
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,17,this.Label5_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label5;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label5;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label5_k__BackingField=(Mobilize.Web.Label)value;} 
#line 101
                                                   }

#line 102

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.GroupBox Frame1_k__BackingField;
#line 104


      [Intercepted]
      public Mobilize.Web.GroupBox Frame1 
#line 104
                                          { 
#line 104
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Frame1)<=0){this.Frame1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.GroupBox>(this,_Mobilize_References,18);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Frame1;;} return this.Frame1_k__BackingField; } 
#line 104

#line 104
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.GroupBox>(this,_Mobilize_References,18,this.Frame1_k__BackingField,(Mobilize.Web.GroupBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Frame1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Frame1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Frame1_k__BackingField=(Mobilize.Web.GroupBox)value;} 
#line 104
                                                      }

#line 105

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_1__k__BackingField;
#line 107


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_1_ 
#line 107
                                                                          { 
#line 107
                                                                            get                                                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProducts_ColumnHeader_1_)<=0){this.lvProducts_ColumnHeader_1__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,19);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_1_;;} return this.lvProducts_ColumnHeader_1__k__BackingField; } 
#line 107

#line 107
                                                                                 set                                                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,19,this.lvProducts_ColumnHeader_1__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lvProducts_ColumnHeader_1_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_1_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProducts_ColumnHeader_1__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 107
                                                                                      }

#line 108

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_2__k__BackingField;
#line 110


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_2_ 
#line 110
                                                                          { 
#line 110
                                                                            get                                                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProducts_ColumnHeader_2_)<=0){this.lvProducts_ColumnHeader_2__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,20);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_2_;;} return this.lvProducts_ColumnHeader_2__k__BackingField; } 
#line 110

#line 110
                                                                                 set                                                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,20,this.lvProducts_ColumnHeader_2__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lvProducts_ColumnHeader_2_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_2_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProducts_ColumnHeader_2__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 110
                                                                                      }

#line 111

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_3__k__BackingField;
#line 113


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_3_ 
#line 113
                                                                          { 
#line 113
                                                                            get                                                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProducts_ColumnHeader_3_)<=0){this.lvProducts_ColumnHeader_3__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,21);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_3_;;} return this.lvProducts_ColumnHeader_3__k__BackingField; } 
#line 113

#line 113
                                                                                 set                                                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,21,this.lvProducts_ColumnHeader_3__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lvProducts_ColumnHeader_3_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_3_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProducts_ColumnHeader_3__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 113
                                                                                      }

#line 114

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_4__k__BackingField;
#line 116


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_4_ 
#line 116
                                                                          { 
#line 116
                                                                            get                                                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProducts_ColumnHeader_4_)<=0){this.lvProducts_ColumnHeader_4__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,22);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_4_;;} return this.lvProducts_ColumnHeader_4__k__BackingField; } 
#line 116

#line 116
                                                                                 set                                                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,22,this.lvProducts_ColumnHeader_4__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvProducts_ColumnHeader_4_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_4_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProducts_ColumnHeader_4__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 116
                                                                                      }

#line 117

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_5__k__BackingField;
#line 119


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_5_ 
#line 119
                                                                          { 
#line 119
                                                                            get                                                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProducts_ColumnHeader_5_)<=0){this.lvProducts_ColumnHeader_5__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,23);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_5_;;} return this.lvProducts_ColumnHeader_5__k__BackingField; } 
#line 119

#line 119
                                                                                 set                                                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,23,this.lvProducts_ColumnHeader_5__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvProducts_ColumnHeader_5_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_5_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProducts_ColumnHeader_5__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 119
                                                                                      }

#line 120

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_6__k__BackingField;
#line 122


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_6_ 
#line 122
                                                                          { 
#line 122
                                                                            get                                                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProducts_ColumnHeader_6_)<=0){this.lvProducts_ColumnHeader_6__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,24);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_6_;;} return this.lvProducts_ColumnHeader_6__k__BackingField; } 
#line 122

#line 122
                                                                                 set                                                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,24,this.lvProducts_ColumnHeader_6__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvProducts_ColumnHeader_6_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_6_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProducts_ColumnHeader_6__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 122
                                                                                      }

#line 123

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_7__k__BackingField;
#line 125


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_7_ 
#line 125
                                                                          { 
#line 125
                                                                            get                                                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProducts_ColumnHeader_7_)<=0){this.lvProducts_ColumnHeader_7__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,25);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_7_;;} return this.lvProducts_ColumnHeader_7__k__BackingField; } 
#line 125

#line 125
                                                                                 set                                                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,25,this.lvProducts_ColumnHeader_7__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvProducts_ColumnHeader_7_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_7_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProducts_ColumnHeader_7__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 125
                                                                                      }

#line 126

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListView lvProducts_k__BackingField;
#line 128


      [Intercepted]
      public Mobilize.Web.ListView lvProducts 
#line 128
                                              { 
#line 128
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProducts)<=0){this.lvProducts_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListView>(this,_Mobilize_References,26);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts;;} return this.lvProducts_k__BackingField; } 
#line 128

#line 128
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListView>(this,_Mobilize_References,26,this.lvProducts_k__BackingField,(Mobilize.Web.ListView)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvProducts;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProducts_k__BackingField=(Mobilize.Web.ListView)value;} 
#line 128
                                                          }

#line 129

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label lblNewQuantity_k__BackingField;
#line 131


      [Intercepted]
      public Mobilize.Web.Label lblNewQuantity 
#line 131
                                               { 
#line 131
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lblNewQuantity)<=0){this.lblNewQuantity_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,27);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lblNewQuantity;;} return this.lblNewQuantity_k__BackingField; } 
#line 131

#line 131
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,27,this.lblNewQuantity_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lblNewQuantity;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lblNewQuantity;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lblNewQuantity_k__BackingField=(Mobilize.Web.Label)value;} 
#line 131
                                                           }

#line 132

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label10_k__BackingField;
#line 134


      [Intercepted]
      public Mobilize.Web.Label Label10 
#line 134
                                        { 
#line 134
                                          get                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label10)<=0){this.Label10_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,28);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label10;;} return this.Label10_k__BackingField; } 
#line 134

#line 134
                                               set                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,28,this.Label10_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label10;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label10;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label10_k__BackingField=(Mobilize.Web.Label)value;} 
#line 134
                                                    }

#line 135

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label9_k__BackingField;
#line 137


      [Intercepted]
      public Mobilize.Web.Label Label9 
#line 137
                                       { 
#line 137
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label9)<=0){this.Label9_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,29);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label9;;} return this.Label9_k__BackingField; } 
#line 137

#line 137
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,29,this.Label9_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label9;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label9;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label9_k__BackingField=(Mobilize.Web.Label)value;} 
#line 137
                                                   }

#line 138

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label8_k__BackingField;
#line 140


      [Intercepted]
      public Mobilize.Web.Label Label8 
#line 140
                                       { 
#line 140
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label8)<=0){this.Label8_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,30);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label8;;} return this.Label8_k__BackingField; } 
#line 140

#line 140
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,30,this.Label8_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label8;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label8;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label8_k__BackingField=(Mobilize.Web.Label)value;} 
#line 140
                                                   }

#line 141

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label7_k__BackingField;
#line 143


      [Intercepted]
      public Mobilize.Web.Label Label7 
#line 143
                                       { 
#line 143
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label7)<=0){this.Label7_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,31);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label7;;} return this.Label7_k__BackingField; } 
#line 143

#line 143
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,31,this.Label7_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label7;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label7;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label7_k__BackingField=(Mobilize.Web.Label)value;} 
#line 143
                                                   }

#line 144

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label6_k__BackingField;
#line 146


      [Intercepted]
      public Mobilize.Web.Label Label6 
#line 146
                                       { 
#line 146
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label6)<=0){this.Label6_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,32);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label6;;} return this.Label6_k__BackingField; } 
#line 146

#line 146
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,32,this.Label6_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label6;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label6;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label6_k__BackingField=(Mobilize.Web.Label)value;} 
#line 146
                                                   }

#line 147

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label1_k__BackingField;
#line 149


      [Intercepted]
      public Mobilize.Web.Label Label1 
#line 149
                                       { 
#line 149
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label1)<=0){this.Label1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,33);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label1;;} return this.Label1_k__BackingField; } 
#line 149

#line 149
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,33,this.Label1_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label1;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label1_k__BackingField=(Mobilize.Web.Label)value;} 
#line 149
                                                   }

#line 150

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label2_k__BackingField;
#line 152


      [Intercepted]
      public Mobilize.Web.Label Label2 
#line 152
                                       { 
#line 152
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label2)<=0){this.Label2_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,34);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label2;;} return this.Label2_k__BackingField; } 
#line 152

#line 152
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,34,this.Label2_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label2;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label2;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label2_k__BackingField=(Mobilize.Web.Label)value;} 
#line 152
                                                   }

#line 153

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label3_k__BackingField;
#line 155


      [Intercepted]
      public Mobilize.Web.Label Label3 
#line 155
                                       { 
#line 155
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label3)<=0){this.Label3_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,35);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label3;;} return this.Label3_k__BackingField; } 
#line 155

#line 155
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,35,this.Label3_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label3;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label3;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label3_k__BackingField=(Mobilize.Web.Label)value;} 
#line 155
                                                   }

#line 156

#line hidden
                                                            
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox[] txtValues_k__BackingField;
#line 158
                                                            

      [Intercepted]
      public Mobilize.Web.TextBox[] txtValues 
#line 158
                                              { 
#line 158
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_txtValues)<=0){this.txtValues_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<Mobilize.Web.TextBox[]>(this,_Mobilize_References,36);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_txtValues;}return this.txtValues_k__BackingField;} 
#line 158

#line 158
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Mobilize.Web.TextBox[] >(this,_Mobilize_References,36,this.txtValues_k__BackingField,(Mobilize.Web.TextBox[])value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_txtValues;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_txtValues;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtValues_k__BackingField=(Mobilize.Web.TextBox[])value;} 
#line 158
                                                          } 
#line 159

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListView listViewHelper1_k__BackingField;
#line 161


      [Intercepted]
      private Mobilize.Web.ListView listViewHelper1 
#line 161
                                                    { 
#line 161
                                                      get                                                         
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_listViewHelper1)<=0){this.listViewHelper1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListView>(this,_Mobilize_References,37);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_listViewHelper1;;} return this.listViewHelper1_k__BackingField; } 
#line 161

#line 161
                                                           set                                                              
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListView>(this,_Mobilize_References,37,this.listViewHelper1_k__BackingField,(Mobilize.Web.ListView)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_listViewHelper1;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_listViewHelper1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.listViewHelper1_k__BackingField=(Mobilize.Web.ListView)value;} 
#line 161
                                                                }

#line 162
      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.

      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {

#line hidden
this.Controls.DesignTime=true;
#line 170
      	this.components = new System.ComponentModel.Container();
      	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStockManual));
      	this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
      	this.cmdSave = new Mobilize.Web.Button();
      	this.cmdClose = new Mobilize.Web.Button();
      	this.sbStatusBar = new Mobilize.Web.StatusStrip();
      	this.sbStatusBar_Panels_Panel1 = new Mobilize.Web.ToolStripStatusLabel();
      	this.txtUnit = new Mobilize.Web.TextBox();
      	this.txtProductName = new Mobilize.Web.TextBox();
      	this.txtQuantityPerUnit = new Mobilize.Web.TextBox();
      	this._txtValues_2 = new Mobilize.Web.TextBox();
      	this._txtValues_1 = new Mobilize.Web.TextBox();
      	this._txtValues_0 = new Mobilize.Web.TextBox();
      	this.Frame1 = new Mobilize.Web.GroupBox();
      	this.cmdProducts = new Mobilize.Web.Button();
      	this.txtName = new Mobilize.Web.TextBox();
      	this.txtCode = new Mobilize.Web.TextBox();
      	this.Label4 = new Mobilize.Web.Label();
      	this.Label5 = new Mobilize.Web.Label();
      	this.lvProducts = new Mobilize.Web.ListView();
      	this.lvProducts_ColumnHeader_1_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProducts_ColumnHeader_2_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProducts_ColumnHeader_3_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProducts_ColumnHeader_4_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProducts_ColumnHeader_5_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProducts_ColumnHeader_6_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProducts_ColumnHeader_7_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lblNewQuantity = new Mobilize.Web.Label();
      	this.Label10 = new Mobilize.Web.Label();
      	this.Label9 = new Mobilize.Web.Label();
      	this.Label8 = new Mobilize.Web.Label();
      	this.Label7 = new Mobilize.Web.Label();
      	this.Label6 = new Mobilize.Web.Label();
      	this.Label1 = new Mobilize.Web.Label();
      	this.Label2 = new Mobilize.Web.Label();
      	this.Label3 = new Mobilize.Web.Label();
      	this.sbStatusBar.SuspendLayout();
      	this.Frame1.SuspendLayout();
      	this.lvProducts.SuspendLayout();
      	this.SuspendLayout();
      	this.listViewHelper1 = new Mobilize.Web.ListView(this.components);
      	// 
      	// cmdSave
      	// 
      	this.cmdSave.AllowDrop = true;
      	this.cmdSave.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdSave.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdSave.Location = new System.Drawing.Point(224, 376);
         this.cmdSave.Name = "cmdSave";
         this.cmdSave.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdSave.Size = new System.Drawing.Size(89, 25);
         this.cmdSave.TabIndex = 24;
         this.cmdSave.Text = "&Save";
         this.cmdSave.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdSave.UseVisualStyleBackColor = false;
         this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
         // 
         // cmdClose
         // 
         this.cmdClose.AllowDrop = true;
         this.cmdClose.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdClose.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdClose.Location = new System.Drawing.Point(328, 376);
         this.cmdClose.Name = "cmdClose";
         this.cmdClose.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdClose.Size = new System.Drawing.Size(89, 25);
         this.cmdClose.TabIndex = 23;
         this.cmdClose.Text = "&Close";
         this.cmdClose.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdClose.UseVisualStyleBackColor = false;
         this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
         // 
         // sbStatusBar
         // 
         this.sbStatusBar.AllowDrop = true;
         this.sbStatusBar.Properties().BackColor = Mobilize.Web.SystemColors.Control;
         this.sbStatusBar.Dock = Mobilize.Web.DockStyle.Bottom;
         this.sbStatusBar.Location = new System.Drawing.Point(0, 416);
         this.sbStatusBar.Name = "sbStatusBar";
         this.sbStatusBar.Properties().ShowItemToolTips = true;
         this.sbStatusBar.Size = new System.Drawing.Size(424, 23);
         this.sbStatusBar.TabIndex = 20;
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
         // txtUnit
         // 
         this.txtUnit.AcceptsReturn = true;
         this.txtUnit.AllowDrop = true;
         this.txtUnit.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtUnit.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtUnit.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtUnit.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtUnit.Location = new System.Drawing.Point(320, 264);
         this.txtUnit.MaxLength = 0;
         this.txtUnit.Name = "txtUnit";
         this.txtUnit.ReadOnly = true;
         this.txtUnit.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtUnit.Size = new System.Drawing.Size(81, 20);
         this.txtUnit.TabIndex = 18;
         this.txtUnit.TabStop = false;
         // 
         // txtProductName
         // 
         this.txtProductName.AcceptsReturn = true;
         this.txtProductName.AllowDrop = true;
         this.txtProductName.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtProductName.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtProductName.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtProductName.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtProductName.Location = new System.Drawing.Point(96, 264);
         this.txtProductName.MaxLength = 0;
         this.txtProductName.Name = "txtProductName";
         this.txtProductName.ReadOnly = true;
         this.txtProductName.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtProductName.Size = new System.Drawing.Size(145, 20);
         this.txtProductName.TabIndex = 16;
         this.txtProductName.TabStop = false;
         // 
         // txtQuantityPerUnit
         // 
         this.txtQuantityPerUnit.AcceptsReturn = true;
         this.txtQuantityPerUnit.AllowDrop = true;
         this.txtQuantityPerUnit.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtQuantityPerUnit.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtQuantityPerUnit.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtQuantityPerUnit.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtQuantityPerUnit.Location = new System.Drawing.Point(320, 296);
         this.txtQuantityPerUnit.MaxLength = 0;
         this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
         this.txtQuantityPerUnit.ReadOnly = true;
         this.txtQuantityPerUnit.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtQuantityPerUnit.Size = new System.Drawing.Size(81, 20);
         this.txtQuantityPerUnit.TabIndex = 15;
         this.txtQuantityPerUnit.TabStop = false;
         this.txtQuantityPerUnit.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         // 
         // _txtValues_2
         // 
         this._txtValues_2.AcceptsReturn = true;
         this._txtValues_2.AllowDrop = true;
         this._txtValues_2.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtValues_2.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtValues_2.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this._txtValues_2.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtValues_2.Location = new System.Drawing.Point(320, 328);
         this._txtValues_2.MaxLength = 0;
         this._txtValues_2.Name = "_txtValues_2";
         this._txtValues_2.ReadOnly = true;
         this._txtValues_2.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtValues_2.Size = new System.Drawing.Size(81, 20);
         this._txtValues_2.TabIndex = 5;
         this._txtValues_2.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this._txtValues_2.Enter += new System.EventHandler(this.txtValues_Enter);
         this._txtValues_2.KeyPress += new Mobilize.Web.KeyPressEventHandler(this.txtValues_KeyPress);
         this._txtValues_2.TextChanged += new System.EventHandler(this.txtValues_TextChanged);
         // 
         // _txtValues_1
         // 
         this._txtValues_1.AcceptsReturn = true;
         this._txtValues_1.AllowDrop = true;
         this._txtValues_1.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtValues_1.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtValues_1.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this._txtValues_1.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtValues_1.Location = new System.Drawing.Point(96, 328);
         this._txtValues_1.MaxLength = 0;
         this._txtValues_1.Name = "_txtValues_1";
         this._txtValues_1.ReadOnly = true;
         this._txtValues_1.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtValues_1.Size = new System.Drawing.Size(81, 20);
         this._txtValues_1.TabIndex = 4;
         this._txtValues_1.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this._txtValues_1.Enter += new System.EventHandler(this.txtValues_Enter);
         this._txtValues_1.KeyPress += new Mobilize.Web.KeyPressEventHandler(this.txtValues_KeyPress);
         this._txtValues_1.TextChanged += new System.EventHandler(this.txtValues_TextChanged);
         // 
         // _txtValues_0
         // 
         this._txtValues_0.AcceptsReturn = true;
         this._txtValues_0.AllowDrop = true;
         this._txtValues_0.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtValues_0.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtValues_0.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this._txtValues_0.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtValues_0.Location = new System.Drawing.Point(96, 296);
         this._txtValues_0.MaxLength = 0;
         this._txtValues_0.Name = "_txtValues_0";
         this._txtValues_0.ReadOnly = true;
         this._txtValues_0.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtValues_0.Size = new System.Drawing.Size(81, 20);
         this._txtValues_0.TabIndex = 3;
         this._txtValues_0.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this._txtValues_0.Enter += new System.EventHandler(this.txtValues_Enter);
         this._txtValues_0.KeyPress += new Mobilize.Web.KeyPressEventHandler(this.txtValues_KeyPress);
         this._txtValues_0.TextChanged += new System.EventHandler(this.txtValues_TextChanged);
         // 
         // Frame1
         // 
         this.Frame1.AllowDrop = true;
         this.Frame1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Frame1.Controls.Add(this.cmdProducts);
         this.Frame1.Controls.Add(this.txtName);
         this.Frame1.Controls.Add(this.txtCode);
         this.Frame1.Controls.Add(this.Label4);
         this.Frame1.Controls.Add(this.Label5);
         this.Frame1.Enabled = true;
         this.Frame1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Frame1.Location = new System.Drawing.Point(8, 32);
         this.Frame1.Name = "Frame1";
         this.Frame1.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Frame1.Size = new System.Drawing.Size(409, 65);
         this.Frame1.TabIndex = 6;
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
         this.cmdProducts.TabIndex = 7;
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
         this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
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
         this.Label4.Text = "Name ";
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
         this.lvProducts.Location = new System.Drawing.Point(8, 104);
         this.lvProducts.MultiSelect = false;
         this.lvProducts.Name = "lvProducts";
         this.lvProducts.Size = new System.Drawing.Size(409, 153);
         this.lvProducts.TabIndex = 2;
         this.lvProducts.View = Mobilize.Web.ListViewMode.Details;
         this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_1_);
         this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_2_);
         this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_3_);
         this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_4_);
         this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_5_);
         this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_6_);
         this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_7_);
         this.lvProducts.Click += new System.EventHandler(this.lvProducts_Click);
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
         // lblNewQuantity
         // 
         this.lblNewQuantity.AllowDrop = true;
         this.lblNewQuantity.BackColor = Mobilize.Web.SystemColors.Control;
         this.lblNewQuantity.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblNewQuantity.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.lblNewQuantity.Location = new System.Drawing.Point(104, 363);
         this.lblNewQuantity.Name = "lblNewQuantity";
         this.lblNewQuantity.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblNewQuantity.Size = new System.Drawing.Size(89, 17);
         this.lblNewQuantity.TabIndex = 22;
         // 
         // Label10
         // 
         this.Label10.AllowDrop = true;
         this.Label10.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label10.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label10.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label10.Location = new System.Drawing.Point(8, 363);
         this.Label10.Name = "Label10";
         this.Label10.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label10.Size = new System.Drawing.Size(73, 17);
         this.Label10.TabIndex = 21;
         this.Label10.Text = "Stock quantity";
         // 
         // Label9
         // 
         this.Label9.AllowDrop = true;
         this.Label9.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label9.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label9.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label9.Location = new System.Drawing.Point(288, 264);
         this.Label9.Name = "Label9";
         this.Label9.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label9.Size = new System.Drawing.Size(25, 17);
         this.Label9.TabIndex = 19;
         this.Label9.Text = "Unit";
         // 
         // Label8
         // 
         this.Label8.AllowDrop = true;
         this.Label8.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label8.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label8.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label8.Location = new System.Drawing.Point(8, 264);
         this.Label8.Name = "Label8";
         this.Label8.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label8.Size = new System.Drawing.Size(74, 17);
         this.Label8.TabIndex = 17;
         this.Label8.Text = "Product";
         // 
         // Label7
         // 
         this.Label7.AllowDrop = true;
         this.Label7.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label7.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label7.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label7.Location = new System.Drawing.Point(224, 296);
         this.Label7.Name = "Label7";
         this.Label7.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label7.Size = new System.Drawing.Size(89, 17);
         this.Label7.TabIndex = 14;
         this.Label7.Text = "Units";
         // 
         // Label6
         // 
         this.Label6.AllowDrop = true;
         this.Label6.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label6.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label6.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label6.Location = new System.Drawing.Point(224, 331);
         this.Label6.Name = "Label6";
         this.Label6.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label6.Size = new System.Drawing.Size(73, 17);
         this.Label6.TabIndex = 13;
         this.Label6.Text = "Unit Price";
         // 
         // Label1
         // 
         this.Label1.AllowDrop = true;
         this.Label1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label1.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label1.Location = new System.Drawing.Point(8, 331);
         this.Label1.Name = "Label1";
         this.Label1.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label1.Size = new System.Drawing.Size(73, 17);
         this.Label1.TabIndex = 12;
         this.Label1.Text = "Price";
         // 
         // Label2
         // 
         this.Label2.AllowDrop = true;
         this.Label2.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label2.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label2.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label2.Location = new System.Drawing.Point(8, 299);
         this.Label2.Name = "Label2";
         this.Label2.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label2.Size = new System.Drawing.Size(74, 17);
         this.Label2.TabIndex = 11;
         this.Label2.Text = "Quantity";
         // 
         // Label3
         // 
         this.Label3.AllowDrop = true;
         this.Label3.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label3.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label3.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label3.Location = new System.Drawing.Point(16, 8);
         this.Label3.Name = "Label3";
         this.Label3.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label3.Size = new System.Drawing.Size(121, 17);
         this.Label3.TabIndex = 10;
         this.Label3.Text = "Select a product first";
         // 
         // frmAddStockManual
         // 
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.AutoScroll = true;
         this.BackColor = Mobilize.Web.SystemColors.Control;
         this.Properties().ClientSize = new System.Drawing.Size(424, 439);
         this.Controls.Add(this.cmdSave);
         this.Controls.Add(this.cmdClose);
         this.Controls.Add(this.sbStatusBar);
         this.Controls.Add(this.txtUnit);
         this.Controls.Add(this.txtProductName);
         this.Controls.Add(this.txtQuantityPerUnit);
         this.Controls.Add(this._txtValues_2);
         this.Controls.Add(this._txtValues_1);
         this.Controls.Add(this._txtValues_0);
         this.Controls.Add(this.Frame1);
         this.Controls.Add(this.lvProducts);
         this.Controls.Add(this.lblNewQuantity);
         this.Controls.Add(this.Label10);
         this.Controls.Add(this.Label9);
         this.Controls.Add(this.Label8);
         this.Controls.Add(this.Label7);
         this.Controls.Add(this.Label6);
         this.Controls.Add(this.Label1);
         this.Controls.Add(this.Label2);
         this.Controls.Add(this.Label3);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedSingle;
         this.Properties().Location = new System.Drawing.Point(3, 25);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmAddStockManual";
         this.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.Manual;
         this.Text = "Inventory Update";
         this.Closed += new System.EventHandler(this.Form_Closed);
         this.FormClosing += new Mobilize.Web.FormClosingEventHandler(this.Form_FormClosing);this.lvProducts.ItemClick += new Mobilize.Web.ListViewItemClickEventHandler(this.lvProducts_ItemClick);
         this.listViewHelper1.SetCorrectEventsBehavior(this.lvProducts, true);
         this.sbStatusBar.ResumeLayout(false);
         this.Frame1.ResumeLayout(false);
         this.lvProducts.ResumeLayout(false);
         this.ResumeLayout(false);

#line hidden
this.Controls.DesignTime=false;
#line 696
      }

      void ReLoadForm(bool addEvents)
      {
      	InitializetxtValues();
      	//This form is an MDI child.
      	//This code simulates the VB6 
      	// functionality of automatically
      	// loading and showing an MDI
      	// child's parent.
      	this.MdiParent = SKS.frmMain.DefInstance;
      	SKS.frmMain.DefInstance.Show();
      }

      void InitializetxtValues()
      {
      	this.txtValues = new Mobilize.Web.TextBox[3];
      	this.txtValues[2] = _txtValues_2;
      	this.txtValues[1] = _txtValues_1;
      	this.txtValues[0] = _txtValues_0;
      }
      #endregion

   }
}
#pragma warning restore
