#pragma warning disable
#line 1 "frmActionOrderRequest.Designer.cs"
#pragma warning disable
#line 1 "frmActionOrderRequest.Designer.cs"
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmActionOrderRequest
   {

      [Intercepted]

      #region "Upgrade Support "
      private static frmActionOrderRequest m_vb6FormDefInstance 
#line 13
                                                                { 
#line 13
                                                                  get                                                                     
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (SKS.frmActionOrderRequest)catalog.frmActionOrderRequest.m_vb6FormDefInstance;} 
#line 13

#line 13
                                                                       set                                                                          
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmActionOrderRequest.m_vb6FormDefInstance = value;} 
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
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (bool)catalog.frmActionOrderRequest.m_InitializingDefInstance;} 
#line 16

#line 16
                                                           set                                                              
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmActionOrderRequest.m_InitializingDefInstance = value;} 
#line 16
                                                                }

#line 17

      [Intercepted]
      public static frmActionOrderRequest DefInstance
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

      public static frmActionOrderRequest CreateInstance()
      {
      	frmActionOrderRequest theInstance = new frmActionOrderRequest();
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
private Mobilize.Web.TextBox txtPromisedBy_k__BackingField;
#line 59


      [Intercepted]
      public Mobilize.Web.TextBox txtPromisedBy 
#line 59
                                                { 
#line 59
                                                  get                                                     
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtPromisedBy)<=0){this.txtPromisedBy_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,3);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtPromisedBy;;} return this.txtPromisedBy_k__BackingField; } 
#line 59

#line 59
                                                       set                                                          
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,3,this.txtPromisedBy_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtPromisedBy;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtPromisedBy;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtPromisedBy_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 59
                                                            }

#line 60

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtRequiredBy_k__BackingField;
#line 62


      [Intercepted]
      public Mobilize.Web.TextBox txtRequiredBy 
#line 62
                                                { 
#line 62
                                                  get                                                     
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtRequiredBy)<=0){this.txtRequiredBy_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,4);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtRequiredBy;;} return this.txtRequiredBy_k__BackingField; } 
#line 62

#line 62
                                                       set                                                          
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,4,this.txtRequiredBy_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtRequiredBy;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtRequiredBy;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtRequiredBy_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 62
                                                            }

#line 63

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtReceivedBy_k__BackingField;
#line 65


      [Intercepted]
      public Mobilize.Web.TextBox txtReceivedBy 
#line 65
                                                { 
#line 65
                                                  get                                                     
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtReceivedBy)<=0){this.txtReceivedBy_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,5);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtReceivedBy;;} return this.txtReceivedBy_k__BackingField; } 
#line 65

#line 65
                                                       set                                                          
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,5,this.txtReceivedBy_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtReceivedBy;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtReceivedBy;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtReceivedBy_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 65
                                                            }

#line 66

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdApprove_k__BackingField;
#line 68


      [Intercepted]
      public Mobilize.Web.Button cmdApprove 
#line 68
                                            { 
#line 68
                                              get                                                 
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdApprove)<=0){this.cmdApprove_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,6);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdApprove;;} return this.cmdApprove_k__BackingField; } 
#line 68

#line 68
                                                   set                                                      
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,6,this.cmdApprove_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdApprove;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdApprove;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdApprove_k__BackingField=(Mobilize.Web.Button)value;} 
#line 68
                                                        }

#line 69

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtStatus_k__BackingField;
#line 71


      [Intercepted]
      public Mobilize.Web.TextBox txtStatus 
#line 71
                                            { 
#line 71
                                              get                                                 
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtStatus)<=0){this.txtStatus_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,7);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtStatus;;} return this.txtStatus_k__BackingField; } 
#line 71

#line 71
                                                   set                                                      
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,7,this.txtStatus_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtStatus;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtStatus;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtStatus_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 71
                                                        }

#line 72

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtReceived_k__BackingField;
#line 74


      [Intercepted]
      public Mobilize.Web.TextBox txtReceived 
#line 74
                                              { 
#line 74
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtReceived)<=0){this.txtReceived_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,8);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtReceived;;} return this.txtReceived_k__BackingField; } 
#line 74

#line 74
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,8,this.txtReceived_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtReceived;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtReceived;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtReceived_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 74
                                                          }

#line 75

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtChangedBy_k__BackingField;
#line 77


      [Intercepted]
      public Mobilize.Web.TextBox txtChangedBy 
#line 77
                                               { 
#line 77
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtChangedBy)<=0){this.txtChangedBy_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,9);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtChangedBy;;} return this.txtChangedBy_k__BackingField; } 
#line 77

#line 77
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,9,this.txtChangedBy_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtChangedBy;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtChangedBy;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtChangedBy_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 77
                                                           }

#line 78

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtChanged_k__BackingField;
#line 80


      [Intercepted]
      public Mobilize.Web.TextBox txtChanged 
#line 80
                                             { 
#line 80
                                               get                                                  
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtChanged)<=0){this.txtChanged_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,10);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtChanged;;} return this.txtChanged_k__BackingField; } 
#line 80

#line 80
                                                    set                                                       
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,10,this.txtChanged_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtChanged;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtChanged;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtChanged_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 80
                                                         }

#line 81

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtOrderID_k__BackingField;
#line 83


      [Intercepted]
      public Mobilize.Web.TextBox txtOrderID 
#line 83
                                             { 
#line 83
                                               get                                                  
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtOrderID)<=0){this.txtOrderID_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,11);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtOrderID;;} return this.txtOrderID_k__BackingField; } 
#line 83

#line 83
                                                    set                                                       
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,11,this.txtOrderID_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtOrderID;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtOrderID;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtOrderID_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 83
                                                         }

#line 84

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtNotes_k__BackingField;
#line 86


      [Intercepted]
      public Mobilize.Web.TextBox txtNotes 
#line 86
                                           { 
#line 86
                                             get                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtNotes)<=0){this.txtNotes_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,12);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtNotes;;} return this.txtNotes_k__BackingField; } 
#line 86

#line 86
                                                  set                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,12,this.txtNotes_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtNotes;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtNotes;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtNotes_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 86
                                                       }

#line 87

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtSubTotal_k__BackingField;
#line 89


      [Intercepted]
      public Mobilize.Web.TextBox txtSubTotal 
#line 89
                                              { 
#line 89
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtSubTotal)<=0){this.txtSubTotal_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,13);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtSubTotal;;} return this.txtSubTotal_k__BackingField; } 
#line 89

#line 89
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,13,this.txtSubTotal_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtSubTotal;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtSubTotal;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtSubTotal_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 89
                                                          }

#line 90

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtTotal_k__BackingField;
#line 92


      [Intercepted]
      public Mobilize.Web.TextBox txtTotal 
#line 92
                                           { 
#line 92
                                             get                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtTotal)<=0){this.txtTotal_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,14);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtTotal;;} return this.txtTotal_k__BackingField; } 
#line 92

#line 92
                                                  set                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,14,this.txtTotal_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtTotal;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtTotal;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtTotal_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 92
                                                       }

#line 93

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtTotalTax_k__BackingField;
#line 95


      [Intercepted]
      public Mobilize.Web.TextBox txtTotalTax 
#line 95
                                              { 
#line 95
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtTotalTax)<=0){this.txtTotalTax_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,15);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtTotalTax;;} return this.txtTotalTax_k__BackingField; } 
#line 95

#line 95
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,15,this.txtTotalTax_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtTotalTax;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtTotalTax;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtTotalTax_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 95
                                                          }

#line 96

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtFreightCharge_k__BackingField;
#line 98


      [Intercepted]
      public Mobilize.Web.TextBox txtFreightCharge 
#line 98
                                                   { 
#line 98
                                                     get                                                        
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtFreightCharge)<=0){this.txtFreightCharge_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,16);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtFreightCharge;;} return this.txtFreightCharge_k__BackingField; } 
#line 98

#line 98
                                                          set                                                             
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,16,this.txtFreightCharge_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtFreightCharge;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtFreightCharge;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtFreightCharge_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 98
                                                               }

#line 99

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtSalesTax_k__BackingField;
#line 101


      [Intercepted]
      public Mobilize.Web.TextBox txtSalesTax 
#line 101
                                              { 
#line 101
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtSalesTax)<=0){this.txtSalesTax_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,17);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtSalesTax;;} return this.txtSalesTax_k__BackingField; } 
#line 101

#line 101
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,17,this.txtSalesTax_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtSalesTax;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtSalesTax;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtSalesTax_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 101
                                                          }

#line 102

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtEntry_k__BackingField;
#line 104


      [Intercepted]
      public Mobilize.Web.TextBox txtEntry 
#line 104
                                           { 
#line 104
                                             get                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtEntry)<=0){this.txtEntry_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,18);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtEntry;;} return this.txtEntry_k__BackingField; } 
#line 104

#line 104
                                                  set                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,18,this.txtEntry_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtEntry;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtEntry;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtEntry_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 104
                                                       }

#line 105

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.VBUC.FlexGrid fgDetails_k__BackingField;
#line 107


      [Intercepted]
      public Mobilize.Web.VBUC.FlexGrid fgDetails 
#line 107
                                                  { 
#line 107
                                                    get                                                       
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_fgDetails)<=0){this.fgDetails_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.VBUC.FlexGrid>(this,_Mobilize_References,19);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_fgDetails;;} return this.fgDetails_k__BackingField; } 
#line 107

#line 107
                                                         set                                                            
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.VBUC.FlexGrid>(this,_Mobilize_References,19,this.fgDetails_k__BackingField,(Mobilize.Web.VBUC.FlexGrid)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_fgDetails;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_fgDetails;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.fgDetails_k__BackingField=(Mobilize.Web.VBUC.FlexGrid)value;} 
#line 107
                                                              }

#line 108

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel1_k__BackingField;
#line 110


      [Intercepted]
      public Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel1 
#line 110
                                                                         { 
#line 110
                                                                           get                                                                              
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_sbStatusBar_Panels_Panel1)<=0){this.sbStatusBar_Panels_Panel1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripStatusLabel>(this,_Mobilize_References,20);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar_Panels_Panel1;;} return this.sbStatusBar_Panels_Panel1_k__BackingField; } 
#line 110

#line 110
                                                                                set                                                                                   
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripStatusLabel>(this,_Mobilize_References,20,this.sbStatusBar_Panels_Panel1_k__BackingField,(Mobilize.Web.ToolStripStatusLabel)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_sbStatusBar_Panels_Panel1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar_Panels_Panel1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.sbStatusBar_Panels_Panel1_k__BackingField=(Mobilize.Web.ToolStripStatusLabel)value;} 
#line 110
                                                                                     }

#line 111

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.StatusStrip sbStatusBar_k__BackingField;
#line 113


      [Intercepted]
      public Mobilize.Web.StatusStrip sbStatusBar 
#line 113
                                                  { 
#line 113
                                                    get                                                       
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_sbStatusBar)<=0){this.sbStatusBar_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.StatusStrip>(this,_Mobilize_References,21);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar;;} return this.sbStatusBar_k__BackingField; } 
#line 113

#line 113
                                                         set                                                            
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.StatusStrip>(this,_Mobilize_References,21,this.sbStatusBar_k__BackingField,(Mobilize.Web.StatusStrip)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_sbStatusBar;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.sbStatusBar_k__BackingField=(Mobilize.Web.StatusStrip)value;} 
#line 113
                                                              }

#line 114

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdCancel_k__BackingField;
#line 116


      [Intercepted]
      public Mobilize.Web.Button cmdCancel 
#line 116
                                           { 
#line 116
                                             get                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdCancel)<=0){this.cmdCancel_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,22);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdCancel;;} return this.cmdCancel_k__BackingField; } 
#line 116

#line 116
                                                  set                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,22,this.cmdCancel_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdCancel;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdCancel;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdCancel_k__BackingField=(Mobilize.Web.Button)value;} 
#line 116
                                                       }

#line 117

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdClose_k__BackingField;
#line 119


      [Intercepted]
      public Mobilize.Web.Button cmdClose 
#line 119
                                          { 
#line 119
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdClose)<=0){this.cmdClose_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,23);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdClose;;} return this.cmdClose_k__BackingField; } 
#line 119

#line 119
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,23,this.cmdClose_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdClose;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdClose;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdClose_k__BackingField=(Mobilize.Web.Button)value;} 
#line 119
                                                      }

#line 120

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtCustomerContact_k__BackingField;
#line 122


      [Intercepted]
      public Mobilize.Web.TextBox txtCustomerContact 
#line 122
                                                     { 
#line 122
                                                       get                                                          
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtCustomerContact)<=0){this.txtCustomerContact_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,24);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtCustomerContact;;} return this.txtCustomerContact_k__BackingField; } 
#line 122

#line 122
                                                            set                                                               
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,24,this.txtCustomerContact_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtCustomerContact;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtCustomerContact;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtCustomerContact_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 122
                                                                 }

#line 123

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtCustomerCompany_k__BackingField;
#line 125


      [Intercepted]
      public Mobilize.Web.TextBox txtCustomerCompany 
#line 125
                                                     { 
#line 125
                                                       get                                                          
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtCustomerCompany)<=0){this.txtCustomerCompany_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,25);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtCustomerCompany;;} return this.txtCustomerCompany_k__BackingField; } 
#line 125

#line 125
                                                            set                                                               
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,25,this.txtCustomerCompany_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_txtCustomerCompany;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtCustomerCompany;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtCustomerCompany_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 125
                                                                 }

#line 126

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label5_k__BackingField;
#line 128


      [Intercepted]
      public Mobilize.Web.Label Label5 
#line 128
                                       { 
#line 128
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label5)<=0){this.Label5_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,26);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label5;;} return this.Label5_k__BackingField; } 
#line 128

#line 128
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,26,this.Label5_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label5;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label5;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label5_k__BackingField=(Mobilize.Web.Label)value;} 
#line 128
                                                   }

#line 129

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label1_k__BackingField;
#line 131


      [Intercepted]
      public Mobilize.Web.Label Label1 
#line 131
                                       { 
#line 131
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label1)<=0){this.Label1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,27);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label1;;} return this.Label1_k__BackingField; } 
#line 131

#line 131
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,27,this.Label1_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label1_k__BackingField=(Mobilize.Web.Label)value;} 
#line 131
                                                   }

#line 132

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.GroupBox Frame2_k__BackingField;
#line 134


      [Intercepted]
      public Mobilize.Web.GroupBox Frame2 
#line 134
                                          { 
#line 134
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Frame2)<=0){this.Frame2_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.GroupBox>(this,_Mobilize_References,28);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Frame2;;} return this.Frame2_k__BackingField; } 
#line 134

#line 134
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.GroupBox>(this,_Mobilize_References,28,this.Frame2_k__BackingField,(Mobilize.Web.GroupBox)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Frame2;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Frame2;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Frame2_k__BackingField=(Mobilize.Web.GroupBox)value;} 
#line 134
                                                      }

#line 135

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label13_k__BackingField;
#line 137


      [Intercepted]
      public Mobilize.Web.Label Label13 
#line 137
                                        { 
#line 137
                                          get                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label13)<=0){this.Label13_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,29);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label13;;} return this.Label13_k__BackingField; } 
#line 137

#line 137
                                               set                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,29,this.Label13_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label13;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label13;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label13_k__BackingField=(Mobilize.Web.Label)value;} 
#line 137
                                                    }

#line 138

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label2_k__BackingField;
#line 140


      [Intercepted]
      public Mobilize.Web.Label Label2 
#line 140
                                       { 
#line 140
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label2)<=0){this.Label2_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,30);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label2;;} return this.Label2_k__BackingField; } 
#line 140

#line 140
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,30,this.Label2_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label2;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label2;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label2_k__BackingField=(Mobilize.Web.Label)value;} 
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
private Mobilize.Web.Label Label3_k__BackingField;
#line 146


      [Intercepted]
      public Mobilize.Web.Label Label3 
#line 146
                                       { 
#line 146
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label3)<=0){this.Label3_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,32);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label3;;} return this.Label3_k__BackingField; } 
#line 146

#line 146
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,32,this.Label3_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label3;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label3;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label3_k__BackingField=(Mobilize.Web.Label)value;} 
#line 146
                                                   }

#line 147

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label19_k__BackingField;
#line 149


      [Intercepted]
      public Mobilize.Web.Label Label19 
#line 149
                                        { 
#line 149
                                          get                                             
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label19)<=0){this.Label19_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,33);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label19;;} return this.Label19_k__BackingField; } 
#line 149

#line 149
                                               set                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,33,this.Label19_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label19;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label19;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label19_k__BackingField=(Mobilize.Web.Label)value;} 
#line 149
                                                    }

#line 150

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label lblChangedBy_k__BackingField;
#line 152


      [Intercepted]
      public Mobilize.Web.Label lblChangedBy 
#line 152
                                             { 
#line 152
                                               get                                                  
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_lblChangedBy)<=0){this.lblChangedBy_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,34);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_lblChangedBy;;} return this.lblChangedBy_k__BackingField; } 
#line 152

#line 152
                                                    set                                                       
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,34,this.lblChangedBy_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lblChangedBy;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_lblChangedBy;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lblChangedBy_k__BackingField=(Mobilize.Web.Label)value;} 
#line 152
                                                         }

#line 153

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label4_k__BackingField;
#line 155


      [Intercepted]
      public Mobilize.Web.Label Label4 
#line 155
                                       { 
#line 155
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label4)<=0){this.Label4_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,35);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label4;;} return this.Label4_k__BackingField; } 
#line 155

#line 155
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,35,this.Label4_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label4;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label4;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label4_k__BackingField=(Mobilize.Web.Label)value;} 
#line 155
                                                   }

#line 156

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label lblChanged_k__BackingField;
#line 158


      [Intercepted]
      public Mobilize.Web.Label lblChanged 
#line 158
                                           { 
#line 158
                                             get                                                
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_lblChanged)<=0){this.lblChanged_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,36);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_lblChanged;;} return this.lblChanged_k__BackingField; } 
#line 158

#line 158
                                                  set                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,36,this.lblChanged_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lblChanged;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_lblChanged;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lblChanged_k__BackingField=(Mobilize.Web.Label)value;} 
#line 158
                                                       }

#line 159

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label12_k__BackingField;
#line 161


      [Intercepted]
      public Mobilize.Web.Label Label12 
#line 161
                                        { 
#line 161
                                          get                                             
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label12)<=0){this.Label12_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,37);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label12;;} return this.Label12_k__BackingField; } 
#line 161

#line 161
                                               set                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,37,this.Label12_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label12;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label12;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label12_k__BackingField=(Mobilize.Web.Label)value;} 
#line 161
                                                    }

#line 162

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label11_k__BackingField;
#line 164


      [Intercepted]
      public Mobilize.Web.Label Label11 
#line 164
                                        { 
#line 164
                                          get                                             
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label11)<=0){this.Label11_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,38);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label11;;} return this.Label11_k__BackingField; } 
#line 164

#line 164
                                               set                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,38,this.Label11_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label11;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label11;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label11_k__BackingField=(Mobilize.Web.Label)value;} 
#line 164
                                                    }

#line 165

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label10_k__BackingField;
#line 167


      [Intercepted]
      public Mobilize.Web.Label Label10 
#line 167
                                        { 
#line 167
                                          get                                             
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label10)<=0){this.Label10_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,39);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label10;;} return this.Label10_k__BackingField; } 
#line 167

#line 167
                                               set                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,39,this.Label10_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label10;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label10;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label10_k__BackingField=(Mobilize.Web.Label)value;} 
#line 167
                                                    }

#line 168

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label9_k__BackingField;
#line 170


      [Intercepted]
      public Mobilize.Web.Label Label9 
#line 170
                                       { 
#line 170
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label9)<=0){this.Label9_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,40);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label9;;} return this.Label9_k__BackingField; } 
#line 170

#line 170
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,40,this.Label9_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label9;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label9;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label9_k__BackingField=(Mobilize.Web.Label)value;} 
#line 170
                                                   }

#line 171

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label8_k__BackingField;
#line 173


      [Intercepted]
      public Mobilize.Web.Label Label8 
#line 173
                                       { 
#line 173
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label8)<=0){this.Label8_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,41);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label8;;} return this.Label8_k__BackingField; } 
#line 173

#line 173
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,41,this.Label8_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label8;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label8;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label8_k__BackingField=(Mobilize.Web.Label)value;} 
#line 173
                                                   }

#line 174

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label6_k__BackingField;
#line 176


      [Intercepted]
      public Mobilize.Web.Label Label6 
#line 176
                                       { 
#line 176
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label6)<=0){this.Label6_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,42);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label6;;} return this.Label6_k__BackingField; } 
#line 176

#line 176
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,42,this.Label6_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label6;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label6;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label6_k__BackingField=(Mobilize.Web.Label)value;} 
#line 176
                                                   }

#line 177
      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.

      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {

#line hidden
this.Controls.DesignTime=true;
#line 185
      	this.components = new System.ComponentModel.Container();
      	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActionOrderRequest));
      	this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
      	this.txtPromisedBy = new Mobilize.Web.TextBox();
      	this.txtRequiredBy = new Mobilize.Web.TextBox();
      	this.txtReceivedBy = new Mobilize.Web.TextBox();
      	this.cmdApprove = new Mobilize.Web.Button();
      	this.txtStatus = new Mobilize.Web.TextBox();
      	this.txtReceived = new Mobilize.Web.TextBox();
      	this.txtChangedBy = new Mobilize.Web.TextBox();
      	this.txtChanged = new Mobilize.Web.TextBox();
      	this.txtOrderID = new Mobilize.Web.TextBox();
      	this.txtNotes = new Mobilize.Web.TextBox();
      	this.txtSubTotal = new Mobilize.Web.TextBox();
      	this.txtTotal = new Mobilize.Web.TextBox();
      	this.txtTotalTax = new Mobilize.Web.TextBox();
      	this.txtFreightCharge = new Mobilize.Web.TextBox();
      	this.txtSalesTax = new Mobilize.Web.TextBox();
      	this.txtEntry = new Mobilize.Web.TextBox();
      	this.fgDetails = new Mobilize.Web.VBUC.FlexGrid(this.components);
      	this.sbStatusBar = new Mobilize.Web.StatusStrip();
      	this.sbStatusBar_Panels_Panel1 = new Mobilize.Web.ToolStripStatusLabel();
      	this.cmdCancel = new Mobilize.Web.Button();
      	this.cmdClose = new Mobilize.Web.Button();
      	this.Frame2 = new Mobilize.Web.GroupBox();
      	this.txtCustomerContact = new Mobilize.Web.TextBox();
      	this.txtCustomerCompany = new Mobilize.Web.TextBox();
      	this.Label5 = new Mobilize.Web.Label();
      	this.Label1 = new Mobilize.Web.Label();
      	this.Label13 = new Mobilize.Web.Label();
      	this.Label2 = new Mobilize.Web.Label();
      	this.Label7 = new Mobilize.Web.Label();
      	this.Label3 = new Mobilize.Web.Label();
      	this.Label19 = new Mobilize.Web.Label();
      	this.lblChangedBy = new Mobilize.Web.Label();
      	this.Label4 = new Mobilize.Web.Label();
      	this.lblChanged = new Mobilize.Web.Label();
      	this.Label12 = new Mobilize.Web.Label();
      	this.Label11 = new Mobilize.Web.Label();
      	this.Label10 = new Mobilize.Web.Label();
      	this.Label9 = new Mobilize.Web.Label();
      	this.Label8 = new Mobilize.Web.Label();
      	this.Label6 = new Mobilize.Web.Label();
      	this.sbStatusBar.SuspendLayout();
      	this.Frame2.SuspendLayout();
      	this.SuspendLayout();
      	// 
      	// txtPromisedBy
      	// 
      	this.txtPromisedBy.AcceptsReturn = true;
      	this.txtPromisedBy.AllowDrop = true;
      	this.txtPromisedBy.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtPromisedBy.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtPromisedBy.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtPromisedBy.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtPromisedBy.Location = new System.Drawing.Point(368, 200);
         this.txtPromisedBy.MaxLength = 0;
         this.txtPromisedBy.Name = "txtPromisedBy";
         this.txtPromisedBy.ReadOnly = true;
         this.txtPromisedBy.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtPromisedBy.Size = new System.Drawing.Size(105, 20);
         this.txtPromisedBy.TabIndex = 38;
         this.txtPromisedBy.TabStop = false;
         // 
         // txtRequiredBy
         // 
         this.txtRequiredBy.AcceptsReturn = true;
         this.txtRequiredBy.AllowDrop = true;
         this.txtRequiredBy.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtRequiredBy.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtRequiredBy.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtRequiredBy.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtRequiredBy.Location = new System.Drawing.Point(120, 200);
         this.txtRequiredBy.MaxLength = 0;
         this.txtRequiredBy.Name = "txtRequiredBy";
         this.txtRequiredBy.ReadOnly = true;
         this.txtRequiredBy.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtRequiredBy.Size = new System.Drawing.Size(105, 20);
         this.txtRequiredBy.TabIndex = 37;
         this.txtRequiredBy.TabStop = false;
         // 
         // txtReceivedBy
         // 
         this.txtReceivedBy.AcceptsReturn = true;
         this.txtReceivedBy.AllowDrop = true;
         this.txtReceivedBy.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtReceivedBy.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtReceivedBy.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtReceivedBy.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtReceivedBy.Location = new System.Drawing.Point(96, 64);
         this.txtReceivedBy.MaxLength = 0;
         this.txtReceivedBy.Name = "txtReceivedBy";
         this.txtReceivedBy.ReadOnly = true;
         this.txtReceivedBy.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtReceivedBy.Size = new System.Drawing.Size(105, 20);
         this.txtReceivedBy.TabIndex = 33;
         this.txtReceivedBy.TabStop = false;
         // 
         // cmdApprove
         // 
         this.cmdApprove.AllowDrop = true;
         this.cmdApprove.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdApprove.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdApprove.Location = new System.Drawing.Point(232, 480);
         this.cmdApprove.Name = "cmdApprove";
         this.cmdApprove.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdApprove.Size = new System.Drawing.Size(89, 25);
         this.cmdApprove.TabIndex = 0;
         this.cmdApprove.Text = "&Create";
         this.cmdApprove.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdApprove.UseVisualStyleBackColor = false;
         this.cmdApprove.Click += new System.EventHandler(this.cmdApprove_Click);
         // 
         // txtStatus
         // 
         this.txtStatus.AcceptsReturn = true;
         this.txtStatus.AllowDrop = true;
         this.txtStatus.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtStatus.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtStatus.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtStatus.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtStatus.Location = new System.Drawing.Point(408, 8);
         this.txtStatus.MaxLength = 0;
         this.txtStatus.Name = "txtStatus";
         this.txtStatus.ReadOnly = true;
         this.txtStatus.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtStatus.Size = new System.Drawing.Size(105, 20);
         this.txtStatus.TabIndex = 31;
         this.txtStatus.TabStop = false;
         // 
         // txtReceived
         // 
         this.txtReceived.AcceptsReturn = true;
         this.txtReceived.AllowDrop = true;
         this.txtReceived.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtReceived.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtReceived.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtReceived.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtReceived.Location = new System.Drawing.Point(96, 36);
         this.txtReceived.MaxLength = 0;
         this.txtReceived.Name = "txtReceived";
         this.txtReceived.ReadOnly = true;
         this.txtReceived.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtReceived.Size = new System.Drawing.Size(105, 20);
         this.txtReceived.TabIndex = 29;
         this.txtReceived.TabStop = false;
         // 
         // txtChangedBy
         // 
         this.txtChangedBy.AcceptsReturn = true;
         this.txtChangedBy.AllowDrop = true;
         this.txtChangedBy.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtChangedBy.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtChangedBy.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtChangedBy.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtChangedBy.Location = new System.Drawing.Point(408, 64);
         this.txtChangedBy.MaxLength = 0;
         this.txtChangedBy.Name = "txtChangedBy";
         this.txtChangedBy.ReadOnly = true;
         this.txtChangedBy.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtChangedBy.Size = new System.Drawing.Size(105, 20);
         this.txtChangedBy.TabIndex = 25;
         this.txtChangedBy.TabStop = false;
         // 
         // txtChanged
         // 
         this.txtChanged.AcceptsReturn = true;
         this.txtChanged.AllowDrop = true;
         this.txtChanged.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtChanged.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtChanged.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtChanged.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtChanged.Location = new System.Drawing.Point(408, 36);
         this.txtChanged.MaxLength = 0;
         this.txtChanged.Name = "txtChanged";
         this.txtChanged.ReadOnly = true;
         this.txtChanged.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtChanged.Size = new System.Drawing.Size(105, 20);
         this.txtChanged.TabIndex = 24;
         this.txtChanged.TabStop = false;
         // 
         // txtOrderID
         // 
         this.txtOrderID.AcceptsReturn = true;
         this.txtOrderID.AllowDrop = true;
         this.txtOrderID.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtOrderID.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtOrderID.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtOrderID.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtOrderID.Location = new System.Drawing.Point(96, 8);
         this.txtOrderID.MaxLength = 0;
         this.txtOrderID.Name = "txtOrderID";
         this.txtOrderID.ReadOnly = true;
         this.txtOrderID.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtOrderID.Size = new System.Drawing.Size(105, 20);
         this.txtOrderID.TabIndex = 23;
         this.txtOrderID.TabStop = false;
         // 
         // txtNotes
         // 
         this.txtNotes.AcceptsReturn = true;
         this.txtNotes.AllowDrop = true;
         this.txtNotes.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtNotes.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtNotes.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtNotes.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtNotes.Location = new System.Drawing.Point(56, 152);
         this.txtNotes.MaxLength = 0;
         this.txtNotes.Multiline = true;
         this.txtNotes.Name = "txtNotes";
         this.txtNotes.ReadOnly = true;
         this.txtNotes.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtNotes.Size = new System.Drawing.Size(457, 44);
         this.txtNotes.TabIndex = 3;
         this.txtNotes.TabStop = false;
         // 
         // txtSubTotal
         // 
         this.txtSubTotal.AcceptsReturn = true;
         this.txtSubTotal.AllowDrop = true;
         this.txtSubTotal.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtSubTotal.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtSubTotal.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtSubTotal.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtSubTotal.Location = new System.Drawing.Point(368, 432);
         this.txtSubTotal.MaxLength = 0;
         this.txtSubTotal.Name = "txtSubTotal";
         this.txtSubTotal.ReadOnly = true;
         this.txtSubTotal.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtSubTotal.Size = new System.Drawing.Size(145, 20);
         this.txtSubTotal.TabIndex = 21;
         this.txtSubTotal.TabStop = false;
         this.txtSubTotal.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         // 
         // txtTotal
         // 
         this.txtTotal.AcceptsReturn = true;
         this.txtTotal.AllowDrop = true;
         this.txtTotal.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtTotal.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtTotal.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtTotal.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtTotal.Location = new System.Drawing.Point(88, 456);
         this.txtTotal.MaxLength = 0;
         this.txtTotal.Name = "txtTotal";
         this.txtTotal.ReadOnly = true;
         this.txtTotal.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtTotal.Size = new System.Drawing.Size(145, 20);
         this.txtTotal.TabIndex = 19;
         this.txtTotal.TabStop = false;
         this.txtTotal.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         // 
         // txtTotalTax
         // 
         this.txtTotalTax.AcceptsReturn = true;
         this.txtTotalTax.AllowDrop = true;
         this.txtTotalTax.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtTotalTax.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtTotalTax.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtTotalTax.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtTotalTax.Location = new System.Drawing.Point(368, 408);
         this.txtTotalTax.MaxLength = 0;
         this.txtTotalTax.Name = "txtTotalTax";
         this.txtTotalTax.ReadOnly = true;
         this.txtTotalTax.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtTotalTax.Size = new System.Drawing.Size(145, 20);
         this.txtTotalTax.TabIndex = 17;
         this.txtTotalTax.TabStop = false;
         this.txtTotalTax.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         // 
         // txtFreightCharge
         // 
         this.txtFreightCharge.AcceptsReturn = true;
         this.txtFreightCharge.AllowDrop = true;
         this.txtFreightCharge.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtFreightCharge.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtFreightCharge.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtFreightCharge.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtFreightCharge.Location = new System.Drawing.Point(88, 432);
         this.txtFreightCharge.MaxLength = 0;
         this.txtFreightCharge.Name = "txtFreightCharge";
         this.txtFreightCharge.ReadOnly = true;
         this.txtFreightCharge.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtFreightCharge.Size = new System.Drawing.Size(145, 20);
         this.txtFreightCharge.TabIndex = 6;
         this.txtFreightCharge.TabStop = false;
         this.txtFreightCharge.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         // 
         // txtSalesTax
         // 
         this.txtSalesTax.AcceptsReturn = true;
         this.txtSalesTax.AllowDrop = true;
         this.txtSalesTax.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtSalesTax.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtSalesTax.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtSalesTax.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtSalesTax.Location = new System.Drawing.Point(88, 408);
         this.txtSalesTax.MaxLength = 0;
         this.txtSalesTax.Name = "txtSalesTax";
         this.txtSalesTax.ReadOnly = true;
         this.txtSalesTax.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtSalesTax.Size = new System.Drawing.Size(145, 20);
         this.txtSalesTax.TabIndex = 5;
         this.txtSalesTax.TabStop = false;
         this.txtSalesTax.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         // 
         // txtEntry
         // 
         this.txtEntry.AcceptsReturn = true;
         this.txtEntry.AllowDrop = true;
         this.txtEntry.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtEntry.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.txtEntry.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtEntry.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtEntry.Location = new System.Drawing.Point(416, 336);
         this.txtEntry.MaxLength = 0;
         this.txtEntry.Name = "txtEntry";
         this.txtEntry.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtEntry.Size = new System.Drawing.Size(73, 19);
         this.txtEntry.TabIndex = 14;
         this.txtEntry.Visible = false;
         // 
         // fgDetails
         // 
         this.fgDetails.AllowDrop = true;
         this.fgDetails.AllowUserToAddRows = false;
         this.fgDetails.AllowUserToDeleteRows = false;
         this.fgDetails.Properties().AllowUserToResizeColumns = false;
         this.fgDetails.Properties().AllowUserToResizeRows = false;
         this.fgDetails.Properties().BorderStyle = Mobilize.Web.BorderStyle.None;
         this.fgDetails.Properties().ColumnHeadersHeightSizeMode = Mobilize.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.fgDetails.ColumnsCount = 0;
         this.fgDetails.FixedColumns = 0;
         this.fgDetails.FixedRows = 0;
         this.fgDetails.Location = new System.Drawing.Point(8, 224);
         this.fgDetails.Name = "fgDetails";
         this.fgDetails.Properties().ReadOnly = true;
         this.fgDetails.Size = new System.Drawing.Size(505, 177);
         this.fgDetails.Properties().StandardTab = true;
         this.fgDetails.TabIndex = 4;
         this.fgDetails.TabStop = false;
         // 
         // sbStatusBar
         // 
         this.sbStatusBar.AllowDrop = true;
         this.sbStatusBar.Properties().BackColor = Mobilize.Web.SystemColors.Control;
         this.sbStatusBar.Dock = Mobilize.Web.DockStyle.Bottom;
         this.sbStatusBar.Location = new System.Drawing.Point(0, 509);
         this.sbStatusBar.Name = "sbStatusBar";
         this.sbStatusBar.Properties().ShowItemToolTips = true;
         this.sbStatusBar.Size = new System.Drawing.Size(523, 25);
         this.sbStatusBar.TabIndex = 13;
         this.sbStatusBar.Items.AddRange(new Mobilize.Web.ToolStripItem[]{this.sbStatusBar_Panels_Panel1});
         // 
         // sbStatusBar_Panels_Panel1
         // 
         this.sbStatusBar_Panels_Panel1.Properties().BorderSides = (Mobilize.Web.ToolStripStatusLabelBorderSides) (Mobilize.Web.ToolStripStatusLabelBorderSides.Left | Mobilize.Web.ToolStripStatusLabelBorderSides.Top | Mobilize.Web.ToolStripStatusLabelBorderSides.Right | Mobilize.Web.ToolStripStatusLabelBorderSides.Bottom);
         this.sbStatusBar_Panels_Panel1.Properties().BorderStyle = Mobilize.Web.Border3DStyle.SunkenOuter;
         this.sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
         this.sbStatusBar_Panels_Panel1.Margin = new Mobilize.Web.Padding(0);
         this.sbStatusBar_Panels_Panel1.Properties().Size = new System.Drawing.Size(523, 25);
         this.sbStatusBar_Panels_Panel1.Properties().Spring = true;
         this.sbStatusBar_Panels_Panel1.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.sbStatusBar_Panels_Panel1.TextImageRelation = Mobilize.Web.TextImageRelation.ImageBeforeText;
         // 
         // cmdCancel
         // 
         this.cmdCancel.AllowDrop = true;
         this.cmdCancel.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdCancel.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdCancel.Location = new System.Drawing.Point(328, 480);
         this.cmdCancel.Name = "cmdCancel";
         this.cmdCancel.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdCancel.Size = new System.Drawing.Size(89, 25);
         this.cmdCancel.TabIndex = 1;
         this.cmdCancel.Text = "&Cancel";
         this.cmdCancel.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdCancel.UseVisualStyleBackColor = false;
         this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
         // 
         // cmdClose
         // 
         this.cmdClose.AllowDrop = true;
         this.cmdClose.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdClose.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdClose.Location = new System.Drawing.Point(424, 480);
         this.cmdClose.Name = "cmdClose";
         this.cmdClose.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdClose.Size = new System.Drawing.Size(89, 25);
         this.cmdClose.TabIndex = 2;
         this.cmdClose.Text = "&Close";
         this.cmdClose.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdClose.UseVisualStyleBackColor = false;
         this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
         // 
         // Frame2
         // 
         this.Frame2.AllowDrop = true;
         this.Frame2.BackColor = Mobilize.Web.SystemColors.Control;
         this.Frame2.Controls.Add(this.txtCustomerContact);
         this.Frame2.Controls.Add(this.txtCustomerCompany);
         this.Frame2.Controls.Add(this.Label5);
         this.Frame2.Controls.Add(this.Label1);
         this.Frame2.Enabled = true;
         this.Frame2.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Frame2.Location = new System.Drawing.Point(8, 96);
         this.Frame2.Name = "Frame2";
         this.Frame2.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Frame2.Size = new System.Drawing.Size(505, 49);
         this.Frame2.TabIndex = 7;
         this.Frame2.Text = "Customer";
         this.Frame2.Visible = true;
         // 
         // txtCustomerContact
         // 
         this.txtCustomerContact.AcceptsReturn = true;
         this.txtCustomerContact.AllowDrop = true;
         this.txtCustomerContact.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtCustomerContact.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtCustomerContact.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtCustomerContact.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtCustomerContact.Location = new System.Drawing.Point(288, 16);
         this.txtCustomerContact.MaxLength = 0;
         this.txtCustomerContact.Name = "txtCustomerContact";
         this.txtCustomerContact.ReadOnly = true;
         this.txtCustomerContact.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtCustomerContact.Size = new System.Drawing.Size(209, 20);
         this.txtCustomerContact.TabIndex = 11;
         this.txtCustomerContact.TabStop = false;
         // 
         // txtCustomerCompany
         // 
         this.txtCustomerCompany.AcceptsReturn = true;
         this.txtCustomerCompany.AllowDrop = true;
         this.txtCustomerCompany.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtCustomerCompany.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtCustomerCompany.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtCustomerCompany.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtCustomerCompany.Location = new System.Drawing.Point(72, 16);
         this.txtCustomerCompany.MaxLength = 0;
         this.txtCustomerCompany.Name = "txtCustomerCompany";
         this.txtCustomerCompany.ReadOnly = true;
         this.txtCustomerCompany.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtCustomerCompany.Size = new System.Drawing.Size(145, 20);
         this.txtCustomerCompany.TabIndex = 10;
         this.txtCustomerCompany.TabStop = false;
         // 
         // Label5
         // 
         this.Label5.AllowDrop = true;
         this.Label5.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label5.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label5.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label5.Location = new System.Drawing.Point(8, 16);
         this.Label5.Name = "Label5";
         this.Label5.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label5.Size = new System.Drawing.Size(57, 17);
         this.Label5.TabIndex = 9;
         this.Label5.Text = "Name:";
         // 
         // Label1
         // 
         this.Label1.AllowDrop = true;
         this.Label1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label1.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label1.Location = new System.Drawing.Point(232, 16);
         this.Label1.Name = "Label1";
         this.Label1.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label1.Size = new System.Drawing.Size(57, 17);
         this.Label1.TabIndex = 8;
         this.Label1.Text = "Contact:";
         // 
         // Label13
         // 
         this.Label13.AllowDrop = true;
         this.Label13.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label13.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label13.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label13.Location = new System.Drawing.Point(16, 200);
         this.Label13.Name = "Label13";
         this.Label13.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label13.Size = new System.Drawing.Size(105, 17);
         this.Label13.TabIndex = 36;
         this.Label13.Text = "Required";
         // 
         // Label2
         // 
         this.Label2.AllowDrop = true;
         this.Label2.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label2.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label2.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label2.Location = new System.Drawing.Point(264, 200);
         this.Label2.Name = "Label2";
         this.Label2.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label2.Size = new System.Drawing.Size(105, 17);
         this.Label2.TabIndex = 35;
         this.Label2.Text = "Promised";
         // 
         // Label7
         // 
         this.Label7.AllowDrop = true;
         this.Label7.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label7.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label7.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label7.Location = new System.Drawing.Point(8, 64);
         this.Label7.Name = "Label7";
         this.Label7.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label7.Size = new System.Drawing.Size(73, 17);
         this.Label7.TabIndex = 34;
         this.Label7.Text = "By";
         // 
         // Label3
         // 
         this.Label3.AllowDrop = true;
         this.Label3.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label3.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label3.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label3.Location = new System.Drawing.Point(320, 8);
         this.Label3.Name = "Label3";
         this.Label3.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label3.Size = new System.Drawing.Size(49, 17);
         this.Label3.TabIndex = 32;
         this.Label3.Text = "Status:";
         // 
         // Label19
         // 
         this.Label19.AllowDrop = true;
         this.Label19.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label19.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label19.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label19.Location = new System.Drawing.Point(8, 32);
         this.Label19.Name = "Label19";
         this.Label19.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label19.Size = new System.Drawing.Size(57, 17);
         this.Label19.TabIndex = 30;
         this.Label19.Text = "Requested:";
         // 
         // lblChangedBy
         // 
         this.lblChangedBy.AllowDrop = true;
         this.lblChangedBy.BackColor = Mobilize.Web.SystemColors.Control;
         this.lblChangedBy.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblChangedBy.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.lblChangedBy.Location = new System.Drawing.Point(320, 64);
         this.lblChangedBy.Name = "lblChangedBy";
         this.lblChangedBy.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblChangedBy.Size = new System.Drawing.Size(89, 17);
         this.lblChangedBy.TabIndex = 28;
         this.lblChangedBy.Text = "By";
         // 
         // Label4
         // 
         this.Label4.AllowDrop = true;
         this.Label4.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label4.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label4.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label4.Location = new System.Drawing.Point(12, 8);
         this.Label4.Name = "Label4";
         this.Label4.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label4.Size = new System.Drawing.Size(49, 17);
         this.Label4.TabIndex = 27;
         this.Label4.Text = "Order Id:";
         // 
         // lblChanged
         // 
         this.lblChanged.AllowDrop = true;
         this.lblChanged.BackColor = Mobilize.Web.SystemColors.Control;
         this.lblChanged.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblChanged.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.lblChanged.Location = new System.Drawing.Point(320, 36);
         this.lblChanged.Name = "lblChanged";
         this.lblChanged.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblChanged.Size = new System.Drawing.Size(89, 17);
         this.lblChanged.TabIndex = 26;
         this.lblChanged.Text = "Changed:";
         // 
         // Label12
         // 
         this.Label12.AllowDrop = true;
         this.Label12.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label12.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label12.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label12.Location = new System.Drawing.Point(8, 432);
         this.Label12.Name = "Label12";
         this.Label12.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label12.Size = new System.Drawing.Size(89, 17);
         this.Label12.TabIndex = 22;
         this.Label12.Text = "Freight";
         // 
         // Label11
         // 
         this.Label11.AllowDrop = true;
         this.Label11.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label11.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label11.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label11.Location = new System.Drawing.Point(8, 456);
         this.Label11.Name = "Label11";
         this.Label11.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label11.Size = new System.Drawing.Size(89, 17);
         this.Label11.TabIndex = 20;
         this.Label11.Text = "Total:";
         // 
         // Label10
         // 
         this.Label10.AllowDrop = true;
         this.Label10.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label10.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label10.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label10.Location = new System.Drawing.Point(288, 408);
         this.Label10.Name = "Label10";
         this.Label10.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label10.Size = new System.Drawing.Size(89, 17);
         this.Label10.TabIndex = 18;
         this.Label10.Text = "Total Tax:";
         // 
         // Label9
         // 
         this.Label9.AllowDrop = true;
         this.Label9.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label9.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label9.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label9.Location = new System.Drawing.Point(288, 432);
         this.Label9.Name = "Label9";
         this.Label9.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label9.Size = new System.Drawing.Size(89, 17);
         this.Label9.TabIndex = 16;
         this.Label9.Text = "Sub Total:";
         // 
         // Label8
         // 
         this.Label8.AllowDrop = true;
         this.Label8.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label8.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label8.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label8.Location = new System.Drawing.Point(8, 408);
         this.Label8.Name = "Label8";
         this.Label8.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label8.Size = new System.Drawing.Size(89, 17);
         this.Label8.TabIndex = 15;
         this.Label8.Text = "Sales Tax:";
         // 
         // Label6
         // 
         this.Label6.AllowDrop = true;
         this.Label6.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label6.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label6.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label6.Location = new System.Drawing.Point(8, 160);
         this.Label6.Name = "Label6";
         this.Label6.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label6.Size = new System.Drawing.Size(33, 17);
         this.Label6.TabIndex = 12;
         this.Label6.Text = "Notes:";
         // 
         // frmActionOrderRequest
         // 
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.AutoScroll = true;
         this.BackColor = Mobilize.Web.SystemColors.Control;
         this.Properties().ClientSize = new System.Drawing.Size(523, 534);
         this.Controls.Add(this.txtPromisedBy);
         this.Controls.Add(this.txtRequiredBy);
         this.Controls.Add(this.txtReceivedBy);
         this.Controls.Add(this.cmdApprove);
         this.Controls.Add(this.txtStatus);
         this.Controls.Add(this.txtReceived);
         this.Controls.Add(this.txtChangedBy);
         this.Controls.Add(this.txtChanged);
         this.Controls.Add(this.txtOrderID);
         this.Controls.Add(this.txtNotes);
         this.Controls.Add(this.txtSubTotal);
         this.Controls.Add(this.txtTotal);
         this.Controls.Add(this.txtTotalTax);
         this.Controls.Add(this.txtFreightCharge);
         this.Controls.Add(this.txtSalesTax);
         this.Controls.Add(this.txtEntry);
         this.Controls.Add(this.fgDetails);
         this.Controls.Add(this.sbStatusBar);
         this.Controls.Add(this.cmdCancel);
         this.Controls.Add(this.cmdClose);
         this.Controls.Add(this.Frame2);
         this.Controls.Add(this.Label13);
         this.Controls.Add(this.Label2);
         this.Controls.Add(this.Label7);
         this.Controls.Add(this.Label3);
         this.Controls.Add(this.Label19);
         this.Controls.Add(this.lblChangedBy);
         this.Controls.Add(this.Label4);
         this.Controls.Add(this.lblChanged);
         this.Controls.Add(this.Label12);
         this.Controls.Add(this.Label11);
         this.Controls.Add(this.Label10);
         this.Controls.Add(this.Label9);
         this.Controls.Add(this.Label8);
         this.Controls.Add(this.Label6);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedSingle;
         this.Properties().Location = new System.Drawing.Point(3, 25);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmActionOrderRequest";
         this.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.Manual;
         this.Text = "Create Invoice";
         this.Closed += new System.EventHandler(this.Form_Closed);
         this.sbStatusBar.ResumeLayout(false);
         this.Frame2.ResumeLayout(false);
         this.ResumeLayout(false);

#line hidden
this.Controls.DesignTime=false;
#line 895
      }

      void ReLoadForm(bool addEvents)
      {
      	//This form is an MDI child.
      	//This code simulates the VB6 
      	// functionality of automatically
      	// loading and showing an MDI
      	// child's parent.
      	this.MdiParent = SKS.frmMain.DefInstance;
      	SKS.frmMain.DefInstance.Show();
      }
      #endregion

   }
}
#pragma warning restore
