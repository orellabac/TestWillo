#pragma warning disable
#line 1 "frmMain.Designer.cs"
#pragma warning disable
#line 1 "frmMain.Designer.cs"
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmMain
   {

      [Intercepted]

      #region "Upgrade Support "
      private static frmMain m_vb6FormDefInstance 
#line 13
                                                  { 
#line 13
                                                    get                                                       
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (SKS.frmMain)catalog.frmMain.m_vb6FormDefInstance;} 
#line 13

#line 13
                                                         set                                                            
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmMain.m_vb6FormDefInstance = value;} 
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
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (bool)catalog.frmMain.m_InitializingDefInstance;} 
#line 16

#line 16
                                                           set                                                              
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmMain.m_InitializingDefInstance = value;} 
#line 16
                                                                }

#line 17

      [Intercepted]
      public static frmMain DefInstance
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

      public static frmMain CreateInstance()
      {
      	frmMain theInstance = new frmMain();
      	theInstance.MDIForm_Load();
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
private Mobilize.Web.ToolStripMenuItem mnuCustomer_k__BackingField;
#line 59


      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuCustomer 
#line 59
                                                        { 
#line 59
                                                          get                                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_mnuCustomer)<=0){this.mnuCustomer_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,3);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuCustomer;;} return this.mnuCustomer_k__BackingField; } 
#line 59

#line 59
                                                               set                                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,3,this.mnuCustomer_k__BackingField,(Mobilize.Web.ToolStripMenuItem)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_mnuCustomer;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuCustomer;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.mnuCustomer_k__BackingField=(Mobilize.Web.ToolStripMenuItem)value;} 
#line 59
                                                                    }

#line 60

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripMenuItem mnuProviders_k__BackingField;
#line 62


      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuProviders 
#line 62
                                                         { 
#line 62
                                                           get                                                              
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_mnuProviders)<=0){this.mnuProviders_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,4);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuProviders;;} return this.mnuProviders_k__BackingField; } 
#line 62

#line 62
                                                                set                                                                   
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,4,this.mnuProviders_k__BackingField,(Mobilize.Web.ToolStripMenuItem)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_mnuProviders;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuProviders;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.mnuProviders_k__BackingField=(Mobilize.Web.ToolStripMenuItem)value;} 
#line 62
                                                                     }

#line 63

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripMenuItem mnuExit_k__BackingField;
#line 65


      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuExit 
#line 65
                                                    { 
#line 65
                                                      get                                                         
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_mnuExit)<=0){this.mnuExit_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,5);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuExit;;} return this.mnuExit_k__BackingField; } 
#line 65

#line 65
                                                           set                                                              
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,5,this.mnuExit_k__BackingField,(Mobilize.Web.ToolStripMenuItem)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_mnuExit;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuExit;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.mnuExit_k__BackingField=(Mobilize.Web.ToolStripMenuItem)value;} 
#line 65
                                                                }

#line 66

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripMenuItem mnuFile_k__BackingField;
#line 68


      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuFile 
#line 68
                                                    { 
#line 68
                                                      get                                                         
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_mnuFile)<=0){this.mnuFile_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,6);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuFile;;} return this.mnuFile_k__BackingField; } 
#line 68

#line 68
                                                           set                                                              
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,6,this.mnuFile_k__BackingField,(Mobilize.Web.ToolStripMenuItem)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_mnuFile;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuFile;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.mnuFile_k__BackingField=(Mobilize.Web.ToolStripMenuItem)value;} 
#line 68
                                                                }

#line 69

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripMenuItem mnuCreateOrderRequest_k__BackingField;
#line 71


      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuCreateOrderRequest 
#line 71
                                                                  { 
#line 71
                                                                    get                                                                       
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_mnuCreateOrderRequest)<=0){this.mnuCreateOrderRequest_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,7);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuCreateOrderRequest;;} return this.mnuCreateOrderRequest_k__BackingField; } 
#line 71

#line 71
                                                                         set                                                                            
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,7,this.mnuCreateOrderRequest_k__BackingField,(Mobilize.Web.ToolStripMenuItem)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_mnuCreateOrderRequest;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuCreateOrderRequest;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.mnuCreateOrderRequest_k__BackingField=(Mobilize.Web.ToolStripMenuItem)value;} 
#line 71
                                                                              }

#line 72

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripMenuItem mnuOrderRequestsApproval_k__BackingField;
#line 74


      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuOrderRequestsApproval 
#line 74
                                                                     { 
#line 74
                                                                       get                                                                          
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_mnuOrderRequestsApproval)<=0){this.mnuOrderRequestsApproval_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,8);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuOrderRequestsApproval;;} return this.mnuOrderRequestsApproval_k__BackingField; } 
#line 74

#line 74
                                                                            set                                                                               
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,8,this.mnuOrderRequestsApproval_k__BackingField,(Mobilize.Web.ToolStripMenuItem)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_mnuOrderRequestsApproval;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuOrderRequestsApproval;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.mnuOrderRequestsApproval_k__BackingField=(Mobilize.Web.ToolStripMenuItem)value;} 
#line 74
                                                                                 }

#line 75

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripSeparator lExit2_k__BackingField;
#line 77


      [Intercepted]
      public Mobilize.Web.ToolStripSeparator lExit2 
#line 77
                                                    { 
#line 77
                                                      get                                                         
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lExit2)<=0){this.lExit2_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripSeparator>(this,_Mobilize_References,9);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lExit2;;} return this.lExit2_k__BackingField; } 
#line 77

#line 77
                                                           set                                                              
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripSeparator>(this,_Mobilize_References,9,this.lExit2_k__BackingField,(Mobilize.Web.ToolStripSeparator)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lExit2;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lExit2;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lExit2_k__BackingField=(Mobilize.Web.ToolStripSeparator)value;} 
#line 77
                                                                }

#line 78

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripMenuItem mnuCreateOrderReception_k__BackingField;
#line 80


      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuCreateOrderReception 
#line 80
                                                                    { 
#line 80
                                                                      get                                                                         
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_mnuCreateOrderReception)<=0){this.mnuCreateOrderReception_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,10);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuCreateOrderReception;;} return this.mnuCreateOrderReception_k__BackingField; } 
#line 80

#line 80
                                                                           set                                                                              
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,10,this.mnuCreateOrderReception_k__BackingField,(Mobilize.Web.ToolStripMenuItem)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_mnuCreateOrderReception;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuCreateOrderReception;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.mnuCreateOrderReception_k__BackingField=(Mobilize.Web.ToolStripMenuItem)value;} 
#line 80
                                                                                }

#line 81

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripMenuItem mnuOrderReceptionsApproval_k__BackingField;
#line 83


      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuOrderReceptionsApproval 
#line 83
                                                                       { 
#line 83
                                                                         get                                                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_mnuOrderReceptionsApproval)<=0){this.mnuOrderReceptionsApproval_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,11);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuOrderReceptionsApproval;;} return this.mnuOrderReceptionsApproval_k__BackingField; } 
#line 83

#line 83
                                                                              set                                                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,11,this.mnuOrderReceptionsApproval_k__BackingField,(Mobilize.Web.ToolStripMenuItem)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_mnuOrderReceptionsApproval;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuOrderReceptionsApproval;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.mnuOrderReceptionsApproval_k__BackingField=(Mobilize.Web.ToolStripMenuItem)value;} 
#line 83
                                                                                   }

#line 84

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripMenuItem mnuOrders_k__BackingField;
#line 86


      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuOrders 
#line 86
                                                      { 
#line 86
                                                        get                                                           
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_mnuOrders)<=0){this.mnuOrders_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,12);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuOrders;;} return this.mnuOrders_k__BackingField; } 
#line 86

#line 86
                                                             set                                                                
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,12,this.mnuOrders_k__BackingField,(Mobilize.Web.ToolStripMenuItem)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_mnuOrders;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuOrders;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.mnuOrders_k__BackingField=(Mobilize.Web.ToolStripMenuItem)value;} 
#line 86
                                                                  }

#line 87

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripMenuItem mnuAddStockManually_k__BackingField;
#line 89


      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuAddStockManually 
#line 89
                                                                { 
#line 89
                                                                  get                                                                     
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_mnuAddStockManually)<=0){this.mnuAddStockManually_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,13);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuAddStockManually;;} return this.mnuAddStockManually_k__BackingField; } 
#line 89

#line 89
                                                                       set                                                                          
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,13,this.mnuAddStockManually_k__BackingField,(Mobilize.Web.ToolStripMenuItem)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_mnuAddStockManually;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuAddStockManually;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.mnuAddStockManually_k__BackingField=(Mobilize.Web.ToolStripMenuItem)value;} 
#line 89
                                                                            }

#line 90

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripMenuItem mnuAdjustStockManually_k__BackingField;
#line 92


      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuAdjustStockManually 
#line 92
                                                                   { 
#line 92
                                                                     get                                                                        
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_mnuAdjustStockManually)<=0){this.mnuAdjustStockManually_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,14);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuAdjustStockManually;;} return this.mnuAdjustStockManually_k__BackingField; } 
#line 92

#line 92
                                                                          set                                                                             
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,14,this.mnuAdjustStockManually_k__BackingField,(Mobilize.Web.ToolStripMenuItem)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_mnuAdjustStockManually;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuAdjustStockManually;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.mnuAdjustStockManually_k__BackingField=(Mobilize.Web.ToolStripMenuItem)value;} 
#line 92
                                                                               }

#line 93

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripMenuItem mnuMainInventory_k__BackingField;
#line 95


      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuMainInventory 
#line 95
                                                             { 
#line 95
                                                               get                                                                  
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_mnuMainInventory)<=0){this.mnuMainInventory_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,15);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuMainInventory;;} return this.mnuMainInventory_k__BackingField; } 
#line 95

#line 95
                                                                    set                                                                       
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,15,this.mnuMainInventory_k__BackingField,(Mobilize.Web.ToolStripMenuItem)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_mnuMainInventory;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuMainInventory;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.mnuMainInventory_k__BackingField=(Mobilize.Web.ToolStripMenuItem)value;} 
#line 95
                                                                         }

#line 96

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripMenuItem mnuProducts_k__BackingField;
#line 98


      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuProducts 
#line 98
                                                        { 
#line 98
                                                          get                                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_mnuProducts)<=0){this.mnuProducts_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,16);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuProducts;;} return this.mnuProducts_k__BackingField; } 
#line 98

#line 98
                                                               set                                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,16,this.mnuProducts_k__BackingField,(Mobilize.Web.ToolStripMenuItem)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_mnuProducts;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuProducts;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.mnuProducts_k__BackingField=(Mobilize.Web.ToolStripMenuItem)value;} 
#line 98
                                                                    }

#line 99

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripMenuItem mnuSecurity_k__BackingField;
#line 101


      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuSecurity 
#line 101
                                                        { 
#line 101
                                                          get                                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_mnuSecurity)<=0){this.mnuSecurity_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,17);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuSecurity;;} return this.mnuSecurity_k__BackingField; } 
#line 101

#line 101
                                                               set                                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,17,this.mnuSecurity_k__BackingField,(Mobilize.Web.ToolStripMenuItem)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_mnuSecurity;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuSecurity;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.mnuSecurity_k__BackingField=(Mobilize.Web.ToolStripMenuItem)value;} 
#line 101
                                                                    }

#line 102

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripMenuItem mnuAccounts_k__BackingField;
#line 104


      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuAccounts 
#line 104
                                                        { 
#line 104
                                                          get                                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_mnuAccounts)<=0){this.mnuAccounts_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,18);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuAccounts;;} return this.mnuAccounts_k__BackingField; } 
#line 104

#line 104
                                                               set                                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,18,this.mnuAccounts_k__BackingField,(Mobilize.Web.ToolStripMenuItem)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_mnuAccounts;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuAccounts;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.mnuAccounts_k__BackingField=(Mobilize.Web.ToolStripMenuItem)value;} 
#line 104
                                                                    }

#line 105

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripMenuItem mnuAbout_k__BackingField;
#line 107


      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuAbout 
#line 107
                                                     { 
#line 107
                                                       get                                                          
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_mnuAbout)<=0){this.mnuAbout_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,19);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuAbout;;} return this.mnuAbout_k__BackingField; } 
#line 107

#line 107
                                                            set                                                               
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,19,this.mnuAbout_k__BackingField,(Mobilize.Web.ToolStripMenuItem)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_mnuAbout;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuAbout;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.mnuAbout_k__BackingField=(Mobilize.Web.ToolStripMenuItem)value;} 
#line 107
                                                                 }

#line 108

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripMenuItem mnuHelp_k__BackingField;
#line 110


      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuHelp 
#line 110
                                                    { 
#line 110
                                                      get                                                         
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_mnuHelp)<=0){this.mnuHelp_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,20);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuHelp;;} return this.mnuHelp_k__BackingField; } 
#line 110

#line 110
                                                           set                                                              
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripMenuItem>(this,_Mobilize_References,20,this.mnuHelp_k__BackingField,(Mobilize.Web.ToolStripMenuItem)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_mnuHelp;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mnuHelp;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.mnuHelp_k__BackingField=(Mobilize.Web.ToolStripMenuItem)value;} 
#line 110
                                                                }

#line 111

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStrip MainMenu1_k__BackingField;
#line 113


      [Intercepted]
      public Mobilize.Web.ToolStrip MainMenu1 
#line 113
                                              { 
#line 113
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_MainMenu1)<=0){this.MainMenu1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStrip>(this,_Mobilize_References,21);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_MainMenu1;;} return this.MainMenu1_k__BackingField; } 
#line 113

#line 113
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStrip>(this,_Mobilize_References,21,this.MainMenu1_k__BackingField,(Mobilize.Web.ToolStrip)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_MainMenu1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_MainMenu1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.MainMenu1_k__BackingField=(Mobilize.Web.ToolStrip)value;} 
#line 113
                                                          }

#line 114

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel1_k__BackingField;
#line 116


      [Intercepted]
      public Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel1 
#line 116
                                                                         { 
#line 116
                                                                           get                                                                              
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_sbStatusBar_Panels_Panel1)<=0){this.sbStatusBar_Panels_Panel1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripStatusLabel>(this,_Mobilize_References,22);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar_Panels_Panel1;;} return this.sbStatusBar_Panels_Panel1_k__BackingField; } 
#line 116

#line 116
                                                                                set                                                                                   
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripStatusLabel>(this,_Mobilize_References,22,this.sbStatusBar_Panels_Panel1_k__BackingField,(Mobilize.Web.ToolStripStatusLabel)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_sbStatusBar_Panels_Panel1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar_Panels_Panel1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.sbStatusBar_Panels_Panel1_k__BackingField=(Mobilize.Web.ToolStripStatusLabel)value;} 
#line 116
                                                                                     }

#line 117

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel2_k__BackingField;
#line 119


      [Intercepted]
      public Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel2 
#line 119
                                                                         { 
#line 119
                                                                           get                                                                              
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_sbStatusBar_Panels_Panel2)<=0){this.sbStatusBar_Panels_Panel2_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripStatusLabel>(this,_Mobilize_References,23);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar_Panels_Panel2;;} return this.sbStatusBar_Panels_Panel2_k__BackingField; } 
#line 119

#line 119
                                                                                set                                                                                   
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripStatusLabel>(this,_Mobilize_References,23,this.sbStatusBar_Panels_Panel2_k__BackingField,(Mobilize.Web.ToolStripStatusLabel)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_sbStatusBar_Panels_Panel2;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar_Panels_Panel2;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.sbStatusBar_Panels_Panel2_k__BackingField=(Mobilize.Web.ToolStripStatusLabel)value;} 
#line 119
                                                                                     }

#line 120

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel3_k__BackingField;
#line 122


      [Intercepted]
      public Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel3 
#line 122
                                                                         { 
#line 122
                                                                           get                                                                              
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_sbStatusBar_Panels_Panel3)<=0){this.sbStatusBar_Panels_Panel3_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripStatusLabel>(this,_Mobilize_References,24);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar_Panels_Panel3;;} return this.sbStatusBar_Panels_Panel3_k__BackingField; } 
#line 122

#line 122
                                                                                set                                                                                   
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripStatusLabel>(this,_Mobilize_References,24,this.sbStatusBar_Panels_Panel3_k__BackingField,(Mobilize.Web.ToolStripStatusLabel)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_sbStatusBar_Panels_Panel3;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar_Panels_Panel3;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.sbStatusBar_Panels_Panel3_k__BackingField=(Mobilize.Web.ToolStripStatusLabel)value;} 
#line 122
                                                                                     }

#line 123

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.StatusStrip sbStatusBar_k__BackingField;
#line 125


      [Intercepted]
      public Mobilize.Web.StatusStrip sbStatusBar 
#line 125
                                                  { 
#line 125
                                                    get                                                       
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_sbStatusBar)<=0){this.sbStatusBar_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.StatusStrip>(this,_Mobilize_References,25);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar;;} return this.sbStatusBar_k__BackingField; } 
#line 125

#line 125
                                                         set                                                            
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.StatusStrip>(this,_Mobilize_References,25,this.sbStatusBar_k__BackingField,(Mobilize.Web.StatusStrip)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_sbStatusBar;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.sbStatusBar_k__BackingField=(Mobilize.Web.StatusStrip)value;} 
#line 125
                                                              }

#line 126
      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.

      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {

#line hidden
this.Controls.DesignTime=true;
#line 134
      	this.components = new System.ComponentModel.Container();
      	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
      	this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
      	this.MainMenu1 = new Mobilize.Web.ToolStrip();
      	this.mnuFile = new Mobilize.Web.ToolStripMenuItem();
      	this.mnuCustomer = new Mobilize.Web.ToolStripMenuItem();
      	this.mnuProviders = new Mobilize.Web.ToolStripMenuItem();
      	this.mnuExit = new Mobilize.Web.ToolStripMenuItem();
      	this.mnuOrders = new Mobilize.Web.ToolStripMenuItem();
      	this.mnuCreateOrderRequest = new Mobilize.Web.ToolStripMenuItem();
      	this.mnuOrderRequestsApproval = new Mobilize.Web.ToolStripMenuItem();
      	this.lExit2 = new Mobilize.Web.ToolStripSeparator();
      	this.mnuCreateOrderReception = new Mobilize.Web.ToolStripMenuItem();
      	this.mnuOrderReceptionsApproval = new Mobilize.Web.ToolStripMenuItem();
      	this.mnuMainInventory = new Mobilize.Web.ToolStripMenuItem();
      	this.mnuAddStockManually = new Mobilize.Web.ToolStripMenuItem();
      	this.mnuAdjustStockManually = new Mobilize.Web.ToolStripMenuItem();
      	this.mnuAccounts = new Mobilize.Web.ToolStripMenuItem();
      	this.mnuProducts = new Mobilize.Web.ToolStripMenuItem();
      	this.mnuSecurity = new Mobilize.Web.ToolStripMenuItem();
      	this.mnuHelp = new Mobilize.Web.ToolStripMenuItem();
      	this.mnuAbout = new Mobilize.Web.ToolStripMenuItem();
      	this.sbStatusBar = new Mobilize.Web.StatusStrip();
      	this.sbStatusBar_Panels_Panel1 = new Mobilize.Web.ToolStripStatusLabel();
      	this.sbStatusBar_Panels_Panel2 = new Mobilize.Web.ToolStripStatusLabel();
      	this.sbStatusBar_Panels_Panel3 = new Mobilize.Web.ToolStripStatusLabel();
      	this.sbStatusBar.SuspendLayout();
      	this.SuspendLayout();
      	// 
      	// MainMenu1
      	// 
      	this.MainMenu1.Items.AddRange(new Mobilize.Web.ToolStripItem[]{this.mnuFile, this.mnuOrders, this.mnuMainInventory, this.mnuAccounts, this.mnuHelp});
         // 
         // mnuFile
         // 
         this.mnuFile.Available = true;
         this.mnuFile.Checked = false;
         this.mnuFile.Enabled = true;
         this.mnuFile.Properties().MergeAction = Stub._System.Windows.Forms.MergeAction.Remove;
         this.mnuFile.Name = "mnuFile";
         this.mnuFile.Text = "&File";
         this.mnuFile.DropDownItems.AddRange(new Mobilize.Web.ToolStripItem[]{this.mnuCustomer, this.mnuProviders, this.mnuExit});
         // 
         // mnuCustomer
         // 
         this.mnuCustomer.Available = true;
         this.mnuCustomer.Checked = false;
         this.mnuCustomer.Enabled = true;
         this.mnuCustomer.Name = "mnuCustomer";
         this.mnuCustomer.Text = "&Manage Customers";
         this.mnuCustomer.Click += new System.EventHandler(this.mnuCustomer_Click);
         // 
         // mnuProviders
         // 
         this.mnuProviders.Available = true;
         this.mnuProviders.Checked = false;
         this.mnuProviders.Enabled = true;
         this.mnuProviders.Name = "mnuProviders";
         this.mnuProviders.Text = "Manage Su&ppliers ";
         this.mnuProviders.Click += new System.EventHandler(this.mnuProviders_Click);
         // 
         // mnuExit
         // 
         this.mnuExit.Available = true;
         this.mnuExit.Checked = false;
         this.mnuExit.Enabled = true;
         this.mnuExit.Name = "mnuExit";
         this.mnuExit.Text = "&Exit";
         this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
         // 
         // mnuOrders
         // 
         this.mnuOrders.Available = true;
         this.mnuOrders.Checked = false;
         this.mnuOrders.Enabled = true;
         this.mnuOrders.Properties().MergeAction = Stub._System.Windows.Forms.MergeAction.Remove;
         this.mnuOrders.Name = "mnuOrders";
         this.mnuOrders.Text = "&Orders";
         this.mnuOrders.DropDownItems.AddRange(new Mobilize.Web.ToolStripItem[]{this.mnuCreateOrderRequest, this.mnuOrderRequestsApproval, this.lExit2, this.mnuCreateOrderReception, this.mnuOrderReceptionsApproval});
         // 
         // mnuCreateOrderRequest
         // 
         this.mnuCreateOrderRequest.Available = true;
         this.mnuCreateOrderRequest.Checked = false;
         this.mnuCreateOrderRequest.Enabled = true;
         this.mnuCreateOrderRequest.Name = "mnuCreateOrderRequest";
         this.mnuCreateOrderRequest.Text = "Create Order";
         this.mnuCreateOrderRequest.Click += new System.EventHandler(this.mnuCreateOrderRequest_Click);
         // 
         // mnuOrderRequestsApproval
         // 
         this.mnuOrderRequestsApproval.Available = true;
         this.mnuOrderRequestsApproval.Checked = false;
         this.mnuOrderRequestsApproval.Enabled = true;
         this.mnuOrderRequestsApproval.Name = "mnuOrderRequestsApproval";
         this.mnuOrderRequestsApproval.Text = "Create Invoice";
         this.mnuOrderRequestsApproval.Click += new System.EventHandler(this.mnuOrderRequestsApproval_Click);
         // 
         // lExit2
         // 
         this.lExit2.Properties().AllowDrop = true;
         this.lExit2.Available = true;
         this.lExit2.Enabled = true;
         this.lExit2.Name = "lExit2";
         // 
         // mnuCreateOrderReception
         // 
         this.mnuCreateOrderReception.Available = true;
         this.mnuCreateOrderReception.Checked = false;
         this.mnuCreateOrderReception.Enabled = true;
         this.mnuCreateOrderReception.Name = "mnuCreateOrderReception";
         this.mnuCreateOrderReception.Text = "Add Stock Order";
         this.mnuCreateOrderReception.Click += new System.EventHandler(this.mnuCreateOrderReception_Click);
         // 
         // mnuOrderReceptionsApproval
         // 
         this.mnuOrderReceptionsApproval.Available = true;
         this.mnuOrderReceptionsApproval.Checked = false;
         this.mnuOrderReceptionsApproval.Enabled = true;
         this.mnuOrderReceptionsApproval.Name = "mnuOrderReceptionsApproval";
         this.mnuOrderReceptionsApproval.Text = "Add Stock to Inventory";
         this.mnuOrderReceptionsApproval.Click += new System.EventHandler(this.mnuOrderReceptionsApproval_Click);
         // 
         // mnuMainInventory
         // 
         this.mnuMainInventory.Available = true;
         this.mnuMainInventory.Checked = false;
         this.mnuMainInventory.Enabled = true;
         this.mnuMainInventory.Properties().MergeAction = Stub._System.Windows.Forms.MergeAction.Remove;
         this.mnuMainInventory.Name = "mnuMainInventory";
         this.mnuMainInventory.Text = "&Inventory";
         this.mnuMainInventory.DropDownItems.AddRange(new Mobilize.Web.ToolStripItem[]{this.mnuAddStockManually, this.mnuAdjustStockManually});
         // 
         // mnuAddStockManually
         // 
         this.mnuAddStockManually.Available = true;
         this.mnuAddStockManually.Checked = false;
         this.mnuAddStockManually.Enabled = true;
         this.mnuAddStockManually.Name = "mnuAddStockManually";
         this.mnuAddStockManually.Text = "Inventory Update";
         this.mnuAddStockManually.Click += new System.EventHandler(this.mnuAddStockManually_Click);
         // 
         // mnuAdjustStockManually
         // 
         this.mnuAdjustStockManually.Available = true;
         this.mnuAdjustStockManually.Checked = false;
         this.mnuAdjustStockManually.Enabled = true;
         this.mnuAdjustStockManually.Name = "mnuAdjustStockManually";
         this.mnuAdjustStockManually.Text = "Inventory Adjust";
         this.mnuAdjustStockManually.Click += new System.EventHandler(this.mnuAdjustStockManually_Click);
         // 
         // mnuAccounts
         // 
         this.mnuAccounts.Available = true;
         this.mnuAccounts.Checked = false;
         this.mnuAccounts.Enabled = true;
         this.mnuAccounts.Properties().MergeAction = Stub._System.Windows.Forms.MergeAction.Remove;
         this.mnuAccounts.Name = "mnuAccounts";
         this.mnuAccounts.Text = "&Maintenance";
         this.mnuAccounts.DropDownItems.AddRange(new Mobilize.Web.ToolStripItem[]{this.mnuProducts, this.mnuSecurity});
         // 
         // mnuProducts
         // 
         this.mnuProducts.Available = true;
         this.mnuProducts.Checked = false;
         this.mnuProducts.Enabled = true;
         this.mnuProducts.Name = "mnuProducts";
         this.mnuProducts.Text = "Manage Products";
         this.mnuProducts.Click += new System.EventHandler(this.mnuProducts_Click);
         // 
         // mnuSecurity
         // 
         this.mnuSecurity.Available = true;
         this.mnuSecurity.Checked = false;
         this.mnuSecurity.Enabled = true;
         this.mnuSecurity.Name = "mnuSecurity";
         this.mnuSecurity.Text = "Manage Users";
         this.mnuSecurity.Click += new System.EventHandler(this.mnuSecurity_Click);
         // 
         // mnuHelp
         // 
         this.mnuHelp.Available = true;
         this.mnuHelp.Checked = false;
         this.mnuHelp.Enabled = true;
         this.mnuHelp.Properties().MergeAction = Stub._System.Windows.Forms.MergeAction.Remove;
         this.mnuHelp.Name = "mnuHelp";
         this.mnuHelp.Text = "&Help";
         this.mnuHelp.DropDownItems.AddRange(new Mobilize.Web.ToolStripItem[]{this.mnuAbout});
         // 
         // mnuAbout
         // 
         this.mnuAbout.Available = true;
         this.mnuAbout.Checked = false;
         this.mnuAbout.Enabled = true;
         this.mnuAbout.Name = "mnuAbout";
         this.mnuAbout.Text = "&About";
         this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
         // 
         // sbStatusBar
         // 
         this.sbStatusBar.AllowDrop = true;
         this.sbStatusBar.Properties().BackColor = Mobilize.Web.SystemColors.Control;
         this.sbStatusBar.Dock = Mobilize.Web.DockStyle.Bottom;
         this.sbStatusBar.Location = new System.Drawing.Point(0, 683);
         this.sbStatusBar.Name = "sbStatusBar";
         this.sbStatusBar.Properties().ShowItemToolTips = true;
         this.sbStatusBar.Size = new System.Drawing.Size(1113, 25);
         this.sbStatusBar.TabIndex = 0;
         this.sbStatusBar.Items.AddRange(new Mobilize.Web.ToolStripItem[]{this.sbStatusBar_Panels_Panel1});
         this.sbStatusBar.Items.AddRange(new Mobilize.Web.ToolStripItem[]{this.sbStatusBar_Panels_Panel2});
         this.sbStatusBar.Items.AddRange(new Mobilize.Web.ToolStripItem[]{this.sbStatusBar_Panels_Panel3});
         // 
         // sbStatusBar_Panels_Panel1
         // 
         this.sbStatusBar_Panels_Panel1.Properties().BorderSides = (Mobilize.Web.ToolStripStatusLabelBorderSides) (Mobilize.Web.ToolStripStatusLabelBorderSides.Left | Mobilize.Web.ToolStripStatusLabelBorderSides.Top | Mobilize.Web.ToolStripStatusLabelBorderSides.Right | Mobilize.Web.ToolStripStatusLabelBorderSides.Bottom);
         this.sbStatusBar_Panels_Panel1.Properties().BorderStyle = Mobilize.Web.Border3DStyle.SunkenOuter;
         this.sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
         this.sbStatusBar_Panels_Panel1.Margin = new Mobilize.Web.Padding(0);
         this.sbStatusBar_Panels_Panel1.Properties().Size = new System.Drawing.Size(901, 25);
         this.sbStatusBar_Panels_Panel1.Properties().Spring = true;
         this.sbStatusBar_Panels_Panel1.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.sbStatusBar_Panels_Panel1.TextImageRelation = Mobilize.Web.TextImageRelation.ImageBeforeText;
         // 
         // sbStatusBar_Panels_Panel2
         // 
         this.sbStatusBar_Panels_Panel2.Properties().AutoSize = false;
         this.sbStatusBar_Panels_Panel2.Properties().BorderSides = (Mobilize.Web.ToolStripStatusLabelBorderSides) (Mobilize.Web.ToolStripStatusLabelBorderSides.Left | Mobilize.Web.ToolStripStatusLabelBorderSides.Top | Mobilize.Web.ToolStripStatusLabelBorderSides.Right | Mobilize.Web.ToolStripStatusLabelBorderSides.Bottom);
         this.sbStatusBar_Panels_Panel2.Properties().BorderStyle = Mobilize.Web.Border3DStyle.SunkenOuter;
         this.sbStatusBar_Panels_Panel2.DoubleClickEnabled = true;
         this.sbStatusBar_Panels_Panel2.Margin = new Mobilize.Web.Padding(0);
         this.sbStatusBar_Panels_Panel2.Properties().Size = new System.Drawing.Size(96, 25);
         this.sbStatusBar_Panels_Panel2.Text = "1:25 PM";
         this.sbStatusBar_Panels_Panel2.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.sbStatusBar_Panels_Panel2.TextImageRelation = Mobilize.Web.TextImageRelation.ImageBeforeText;
         // 
         // sbStatusBar_Panels_Panel3
         // 
         this.sbStatusBar_Panels_Panel3.Properties().AutoSize = false;
         this.sbStatusBar_Panels_Panel3.Properties().BorderSides = (Mobilize.Web.ToolStripStatusLabelBorderSides) (Mobilize.Web.ToolStripStatusLabelBorderSides.Left | Mobilize.Web.ToolStripStatusLabelBorderSides.Top | Mobilize.Web.ToolStripStatusLabelBorderSides.Right | Mobilize.Web.ToolStripStatusLabelBorderSides.Bottom);
         this.sbStatusBar_Panels_Panel3.Properties().BorderStyle = Mobilize.Web.Border3DStyle.SunkenOuter;
         this.sbStatusBar_Panels_Panel3.DoubleClickEnabled = true;
         this.sbStatusBar_Panels_Panel3.Margin = new Mobilize.Web.Padding(0);
         this.sbStatusBar_Panels_Panel3.Properties().Size = new System.Drawing.Size(96, 25);
         this.sbStatusBar_Panels_Panel3.Text = "2/21/2018";
         this.sbStatusBar_Panels_Panel3.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.sbStatusBar_Panels_Panel3.TextImageRelation = Mobilize.Web.TextImageRelation.ImageBeforeText;
         // 
         // frmMain
         // 
         this.AllowDrop = true;
         this.BackColor = Mobilize.Web.SystemColors.AppWorkspace;
         this.Properties().ClientSize = new System.Drawing.Size(1113, 708);
         this.Controls.Add(this.sbStatusBar);
         this.Controls.Add(MainMenu1);
         this.Enabled = true;
         this.IsMdiContainer = true;
         this.Properties().Location = new System.Drawing.Point(11, 54);
         this.Name = "frmMain";
         this.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Text = "Sales Agent";
         this.WindowState = Mobilize.Web.FormWindowState.Maximized;
         this.sbStatusBar.ResumeLayout(false);
         this.ResumeLayout(false);

#line hidden
this.Controls.DesignTime=false;
#line 397
      }
      #endregion

   }
}
#pragma warning restore
