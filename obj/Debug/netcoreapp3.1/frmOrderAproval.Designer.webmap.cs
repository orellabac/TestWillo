#pragma warning disable
#line 1 "frmOrderAproval.Designer.cs"
#pragma warning disable
#line 1 "frmOrderAproval.Designer.cs"
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmReceptionApproval
   {

      [Intercepted]

      #region "Upgrade Support "
      private static frmReceptionApproval m_vb6FormDefInstance 
#line 13
                                                               { 
#line 13
                                                                 get                                                                    
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (SKS.frmReceptionApproval)catalog.frmReceptionApproval.m_vb6FormDefInstance;} 
#line 13

#line 13
                                                                      set                                                                         
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmReceptionApproval.m_vb6FormDefInstance = value;} 
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
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (bool)catalog.frmReceptionApproval.m_InitializingDefInstance;} 
#line 16

#line 16
                                                           set                                                              
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmReceptionApproval.m_InitializingDefInstance = value;} 
#line 16
                                                                }

#line 17

      [Intercepted]
      public static frmReceptionApproval DefInstance
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

      public static frmReceptionApproval CreateInstance()
      {
      	frmReceptionApproval theInstance = new frmReceptionApproval();
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
private Mobilize.Web.Button cmdApprove_k__BackingField;
#line 59


      [Intercepted]
      public Mobilize.Web.Button cmdApprove 
#line 59
                                            { 
#line 59
                                              get                                                 
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdApprove)<=0){this.cmdApprove_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,3);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdApprove;;} return this.cmdApprove_k__BackingField; } 
#line 59

#line 59
                                                   set                                                      
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,3,this.cmdApprove_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdApprove;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdApprove;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdApprove_k__BackingField=(Mobilize.Web.Button)value;} 
#line 59
                                                        }

#line 60

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdInfo_k__BackingField;
#line 62


      [Intercepted]
      public Mobilize.Web.Button cmdInfo 
#line 62
                                         { 
#line 62
                                           get                                              
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdInfo)<=0){this.cmdInfo_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,4);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdInfo;;} return this.cmdInfo_k__BackingField; } 
#line 62

#line 62
                                                set                                                   
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,4,this.cmdInfo_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdInfo;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdInfo;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdInfo_k__BackingField=(Mobilize.Web.Button)value;} 
#line 62
                                                     }

#line 63

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.VBUC.FlexGrid fgOrders_k__BackingField;
#line 65


      [Intercepted]
      public Mobilize.Web.VBUC.FlexGrid fgOrders 
#line 65
                                                 { 
#line 65
                                                   get                                                      
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_fgOrders)<=0){this.fgOrders_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.VBUC.FlexGrid>(this,_Mobilize_References,5);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_fgOrders;;} return this.fgOrders_k__BackingField; } 
#line 65

#line 65
                                                        set                                                           
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.VBUC.FlexGrid>(this,_Mobilize_References,5,this.fgOrders_k__BackingField,(Mobilize.Web.VBUC.FlexGrid)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_fgOrders;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_fgOrders;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.fgOrders_k__BackingField=(Mobilize.Web.VBUC.FlexGrid)value;} 
#line 65
                                                             }

#line 66

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel1_k__BackingField;
#line 68


      [Intercepted]
      public Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel1 
#line 68
                                                                         { 
#line 68
                                                                           get                                                                              
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_sbStatusBar_Panels_Panel1)<=0){this.sbStatusBar_Panels_Panel1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripStatusLabel>(this,_Mobilize_References,6);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar_Panels_Panel1;;} return this.sbStatusBar_Panels_Panel1_k__BackingField; } 
#line 68

#line 68
                                                                                set                                                                                   
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripStatusLabel>(this,_Mobilize_References,6,this.sbStatusBar_Panels_Panel1_k__BackingField,(Mobilize.Web.ToolStripStatusLabel)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_sbStatusBar_Panels_Panel1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar_Panels_Panel1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.sbStatusBar_Panels_Panel1_k__BackingField=(Mobilize.Web.ToolStripStatusLabel)value;} 
#line 68
                                                                                     }

#line 69

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.StatusStrip sbStatusBar_k__BackingField;
#line 71


      [Intercepted]
      public Mobilize.Web.StatusStrip sbStatusBar 
#line 71
                                                  { 
#line 71
                                                    get                                                       
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_sbStatusBar)<=0){this.sbStatusBar_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.StatusStrip>(this,_Mobilize_References,7);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar;;} return this.sbStatusBar_k__BackingField; } 
#line 71

#line 71
                                                         set                                                            
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.StatusStrip>(this,_Mobilize_References,7,this.sbStatusBar_k__BackingField,(Mobilize.Web.StatusStrip)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_sbStatusBar;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.sbStatusBar_k__BackingField=(Mobilize.Web.StatusStrip)value;} 
#line 71
                                                              }

#line 72

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdCancel_k__BackingField;
#line 74


      [Intercepted]
      public Mobilize.Web.Button cmdCancel 
#line 74
                                           { 
#line 74
                                             get                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdCancel)<=0){this.cmdCancel_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,8);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdCancel;;} return this.cmdCancel_k__BackingField; } 
#line 74

#line 74
                                                  set                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,8,this.cmdCancel_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdCancel;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdCancel;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdCancel_k__BackingField=(Mobilize.Web.Button)value;} 
#line 74
                                                       }

#line 75

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdClose_k__BackingField;
#line 77


      [Intercepted]
      public Mobilize.Web.Button cmdClose 
#line 77
                                          { 
#line 77
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdClose)<=0){this.cmdClose_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,9);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdClose;;} return this.cmdClose_k__BackingField; } 
#line 77

#line 77
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,9,this.cmdClose_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdClose;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdClose;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdClose_k__BackingField=(Mobilize.Web.Button)value;} 
#line 77
                                                      }

#line 78

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ComboBox cmbStatus_k__BackingField;
#line 80


      [Intercepted]
      public Mobilize.Web.ComboBox cmbStatus 
#line 80
                                             { 
#line 80
                                               get                                                  
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmbStatus)<=0){this.cmbStatus_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ComboBox>(this,_Mobilize_References,10);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmbStatus;;} return this.cmbStatus_k__BackingField; } 
#line 80

#line 80
                                                    set                                                       
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ComboBox>(this,_Mobilize_References,10,this.cmbStatus_k__BackingField,(Mobilize.Web.ComboBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmbStatus;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmbStatus;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmbStatus_k__BackingField=(Mobilize.Web.ComboBox)value;} 
#line 80
                                                         }

#line 81

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.CheckBox chkTo_k__BackingField;
#line 83


      [Intercepted]
      public Mobilize.Web.CheckBox chkTo 
#line 83
                                         { 
#line 83
                                           get                                              
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_chkTo)<=0){this.chkTo_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.CheckBox>(this,_Mobilize_References,11);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_chkTo;;} return this.chkTo_k__BackingField; } 
#line 83

#line 83
                                                set                                                   
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.CheckBox>(this,_Mobilize_References,11,this.chkTo_k__BackingField,(Mobilize.Web.CheckBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_chkTo;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_chkTo;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.chkTo_k__BackingField=(Mobilize.Web.CheckBox)value;} 
#line 83
                                                     }

#line 84

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.CheckBox chkFrom_k__BackingField;
#line 86


      [Intercepted]
      public Mobilize.Web.CheckBox chkFrom 
#line 86
                                           { 
#line 86
                                             get                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_chkFrom)<=0){this.chkFrom_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.CheckBox>(this,_Mobilize_References,12);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_chkFrom;;} return this.chkFrom_k__BackingField; } 
#line 86

#line 86
                                                  set                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.CheckBox>(this,_Mobilize_References,12,this.chkFrom_k__BackingField,(Mobilize.Web.CheckBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_chkFrom;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_chkFrom;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.chkFrom_k__BackingField=(Mobilize.Web.CheckBox)value;} 
#line 86
                                                       }

#line 87

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtProductID_k__BackingField;
#line 89


      [Intercepted]
      public Mobilize.Web.TextBox txtProductID 
#line 89
                                               { 
#line 89
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtProductID)<=0){this.txtProductID_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,13);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtProductID;;} return this.txtProductID_k__BackingField; } 
#line 89

#line 89
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,13,this.txtProductID_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtProductID;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtProductID;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtProductID_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 89
                                                           }

#line 90

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtOrderID_k__BackingField;
#line 92


      [Intercepted]
      public Mobilize.Web.TextBox txtOrderID 
#line 92
                                             { 
#line 92
                                               get                                                  
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtOrderID)<=0){this.txtOrderID_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,14);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtOrderID;;} return this.txtOrderID_k__BackingField; } 
#line 92

#line 92
                                                    set                                                       
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,14,this.txtOrderID_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtOrderID;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtOrderID;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtOrderID_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 92
                                                         }

#line 93

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtContactLastName_k__BackingField;
#line 95


      [Intercepted]
      public Mobilize.Web.TextBox txtContactLastName 
#line 95
                                                     { 
#line 95
                                                       get                                                          
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtContactLastName)<=0){this.txtContactLastName_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,15);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtContactLastName;;} return this.txtContactLastName_k__BackingField; } 
#line 95

#line 95
                                                            set                                                               
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,15,this.txtContactLastName_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtContactLastName;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtContactLastName;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtContactLastName_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 95
                                                                 }

#line 96

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtContactName_k__BackingField;
#line 98


      [Intercepted]
      public Mobilize.Web.TextBox txtContactName 
#line 98
                                                 { 
#line 98
                                                   get                                                      
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtContactName)<=0){this.txtContactName_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,16);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtContactName;;} return this.txtContactName_k__BackingField; } 
#line 98

#line 98
                                                        set                                                           
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,16,this.txtContactName_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtContactName;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtContactName;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtContactName_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 98
                                                             }

#line 99

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdProviders_k__BackingField;
#line 101


      [Intercepted]
      public Mobilize.Web.Button cmdProviders 
#line 101
                                              { 
#line 101
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdProviders)<=0){this.cmdProviders_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,17);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdProviders;;} return this.cmdProviders_k__BackingField; } 
#line 101

#line 101
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,17,this.cmdProviders_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdProviders;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdProviders;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdProviders_k__BackingField=(Mobilize.Web.Button)value;} 
#line 101
                                                          }

#line 102

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtProviderName_k__BackingField;
#line 104


      [Intercepted]
      public Mobilize.Web.TextBox txtProviderName 
#line 104
                                                  { 
#line 104
                                                    get                                                       
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtProviderName)<=0){this.txtProviderName_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,18);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtProviderName;;} return this.txtProviderName_k__BackingField; } 
#line 104

#line 104
                                                         set                                                            
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,18,this.txtProviderName_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtProviderName;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtProviderName;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtProviderName_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 104
                                                              }

#line 105

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.DateTimePicker dtFrom_k__BackingField;
#line 107


      [Intercepted]
      public Mobilize.Web.DateTimePicker dtFrom 
#line 107
                                                { 
#line 107
                                                  get                                                     
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_dtFrom)<=0){this.dtFrom_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.DateTimePicker>(this,_Mobilize_References,19);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_dtFrom;;} return this.dtFrom_k__BackingField; } 
#line 107

#line 107
                                                       set                                                          
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.DateTimePicker>(this,_Mobilize_References,19,this.dtFrom_k__BackingField,(Mobilize.Web.DateTimePicker)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_dtFrom;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_dtFrom;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.dtFrom_k__BackingField=(Mobilize.Web.DateTimePicker)value;} 
#line 107
                                                            }

#line 108

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.DateTimePicker dtTo_k__BackingField;
#line 110


      [Intercepted]
      public Mobilize.Web.DateTimePicker dtTo 
#line 110
                                              { 
#line 110
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_dtTo)<=0){this.dtTo_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.DateTimePicker>(this,_Mobilize_References,20);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_dtTo;;} return this.dtTo_k__BackingField; } 
#line 110

#line 110
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.DateTimePicker>(this,_Mobilize_References,20,this.dtTo_k__BackingField,(Mobilize.Web.DateTimePicker)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_dtTo;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_dtTo;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.dtTo_k__BackingField=(Mobilize.Web.DateTimePicker)value;} 
#line 110
                                                          }

#line 111

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label5_k__BackingField;
#line 113


      [Intercepted]
      public Mobilize.Web.Label Label5 
#line 113
                                       { 
#line 113
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label5)<=0){this.Label5_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,21);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label5;;} return this.Label5_k__BackingField; } 
#line 113

#line 113
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,21,this.Label5_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label5;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label5;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label5_k__BackingField=(Mobilize.Web.Label)value;} 
#line 113
                                                   }

#line 114

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label8_k__BackingField;
#line 116


      [Intercepted]
      public Mobilize.Web.Label Label8 
#line 116
                                       { 
#line 116
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label8)<=0){this.Label8_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,22);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label8;;} return this.Label8_k__BackingField; } 
#line 116

#line 116
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,22,this.Label8_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label8;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label8;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label8_k__BackingField=(Mobilize.Web.Label)value;} 
#line 116
                                                   }

#line 117

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label1_k__BackingField;
#line 119


      [Intercepted]
      public Mobilize.Web.Label Label1 
#line 119
                                       { 
#line 119
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label1)<=0){this.Label1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,23);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label1;;} return this.Label1_k__BackingField; } 
#line 119

#line 119
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,23,this.Label1_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label1_k__BackingField=(Mobilize.Web.Label)value;} 
#line 119
                                                   }

#line 120

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label6_k__BackingField;
#line 122


      [Intercepted]
      public Mobilize.Web.Label Label6 
#line 122
                                       { 
#line 122
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label6)<=0){this.Label6_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,24);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label6;;} return this.Label6_k__BackingField; } 
#line 122

#line 122
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,24,this.Label6_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label6;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label6;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label6_k__BackingField=(Mobilize.Web.Label)value;} 
#line 122
                                                   }

#line 123

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label3_k__BackingField;
#line 125


      [Intercepted]
      public Mobilize.Web.Label Label3 
#line 125
                                       { 
#line 125
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label3)<=0){this.Label3_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,25);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label3;;} return this.Label3_k__BackingField; } 
#line 125

#line 125
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,25,this.Label3_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label3;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label3;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label3_k__BackingField=(Mobilize.Web.Label)value;} 
#line 125
                                                   }

#line 126

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label4_k__BackingField;
#line 128


      [Intercepted]
      public Mobilize.Web.Label Label4 
#line 128
                                       { 
#line 128
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label4)<=0){this.Label4_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,26);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label4;;} return this.Label4_k__BackingField; } 
#line 128

#line 128
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,26,this.Label4_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label4;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label4;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label4_k__BackingField=(Mobilize.Web.Label)value;} 
#line 128
                                                   }

#line 129

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label2_k__BackingField;
#line 131


      [Intercepted]
      public Mobilize.Web.Label Label2 
#line 131
                                       { 
#line 131
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label2)<=0){this.Label2_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,27);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label2;;} return this.Label2_k__BackingField; } 
#line 131

#line 131
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,27,this.Label2_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label2;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label2;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label2_k__BackingField=(Mobilize.Web.Label)value;} 
#line 131
                                                   }

#line 132

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.GroupBox Frame1_k__BackingField;
#line 134


      [Intercepted]
      public Mobilize.Web.GroupBox Frame1 
#line 134
                                          { 
#line 134
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Frame1)<=0){this.Frame1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.GroupBox>(this,_Mobilize_References,28);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Frame1;;} return this.Frame1_k__BackingField; } 
#line 134

#line 134
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.GroupBox>(this,_Mobilize_References,28,this.Frame1_k__BackingField,(Mobilize.Web.GroupBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Frame1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Frame1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Frame1_k__BackingField=(Mobilize.Web.GroupBox)value;} 
#line 134
                                                      }

#line 135

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Stub._UpgradeHelpers.Gui.ListControlHelper listBoxComboBoxHelper1_k__BackingField;
#line 137


      [Intercepted]
      private Stub._UpgradeHelpers.Gui.ListControlHelper listBoxComboBoxHelper1 
#line 137
                                                                                { 
#line 137
                                                                                  get                                                                                     
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_listBoxComboBoxHelper1)<=0){this.listBoxComboBoxHelper1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<Stub._UpgradeHelpers.Gui.ListControlHelper>(this,_Mobilize_References,29);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_listBoxComboBoxHelper1;}return this.listBoxComboBoxHelper1_k__BackingField;} 
#line 137

#line 137
                                                                                       set                                                                                          
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Stub._UpgradeHelpers.Gui.ListControlHelper >(this,_Mobilize_References,29,this.listBoxComboBoxHelper1_k__BackingField,(Stub._UpgradeHelpers.Gui.ListControlHelper)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_listBoxComboBoxHelper1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_listBoxComboBoxHelper1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.listBoxComboBoxHelper1_k__BackingField=(Stub._UpgradeHelpers.Gui.ListControlHelper)value;} 
#line 137
                                                                                            }

#line 138
      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.

      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {

#line hidden
this.Controls.DesignTime=true;
#line 146
      	this.components = new System.ComponentModel.Container();
      	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceptionApproval));
      	this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
      	this.cmdApprove = new Mobilize.Web.Button();
      	this.cmdInfo = new Mobilize.Web.Button();
      	this.fgOrders = new Mobilize.Web.VBUC.FlexGrid(this.components);
      	this.sbStatusBar = new Mobilize.Web.StatusStrip();
      	this.sbStatusBar_Panels_Panel1 = new Mobilize.Web.ToolStripStatusLabel();
      	this.cmdCancel = new Mobilize.Web.Button();
      	this.cmdClose = new Mobilize.Web.Button();
      	this.Frame1 = new Mobilize.Web.GroupBox();
      	this.cmbStatus = new Mobilize.Web.ComboBox();
      	this.chkTo = new Mobilize.Web.CheckBox();
      	this.chkFrom = new Mobilize.Web.CheckBox();
      	this.txtProductID = new Mobilize.Web.TextBox();
      	this.txtOrderID = new Mobilize.Web.TextBox();
      	this.txtContactLastName = new Mobilize.Web.TextBox();
      	this.txtContactName = new Mobilize.Web.TextBox();
      	this.cmdProviders = new Mobilize.Web.Button();
      	this.txtProviderName = new Mobilize.Web.TextBox();
      	this.dtFrom = new Mobilize.Web.DateTimePicker();
      	this.dtTo = new Mobilize.Web.DateTimePicker();
      	this.Label5 = new Mobilize.Web.Label();
      	this.Label8 = new Mobilize.Web.Label();
      	this.Label1 = new Mobilize.Web.Label();
      	this.Label6 = new Mobilize.Web.Label();
      	this.Label3 = new Mobilize.Web.Label();
      	this.Label4 = new Mobilize.Web.Label();
      	this.Label2 = new Mobilize.Web.Label();
      	this.sbStatusBar.SuspendLayout();
      	this.Frame1.SuspendLayout();
      	this.SuspendLayout();
      	this.listBoxComboBoxHelper1 = new Stub._UpgradeHelpers.Gui.ListControlHelper(this.components);
      	// 
      	// cmdApprove
      	// 
      	this.cmdApprove.AllowDrop = true;
      	this.cmdApprove.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdApprove.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdApprove.Location = new System.Drawing.Point(232, 440);
         this.cmdApprove.Name = "cmdApprove";
         this.cmdApprove.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdApprove.Size = new System.Drawing.Size(89, 25);
         this.cmdApprove.TabIndex = 10;
         this.cmdApprove.Text = "&Approve";
         this.cmdApprove.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdApprove.UseVisualStyleBackColor = false;
         this.cmdApprove.Click += new System.EventHandler(this.cmdApprove_Click);
         // 
         // cmdInfo
         // 
         this.cmdInfo.AllowDrop = true;
         this.cmdInfo.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdInfo.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdInfo.Location = new System.Drawing.Point(136, 440);
         this.cmdInfo.Name = "cmdInfo";
         this.cmdInfo.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdInfo.Size = new System.Drawing.Size(89, 25);
         this.cmdInfo.TabIndex = 9;
         this.cmdInfo.Text = "&Info";
         this.cmdInfo.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdInfo.UseVisualStyleBackColor = false;
         this.cmdInfo.Click += new System.EventHandler(this.cmdInfo_Click);
         // 
         // fgOrders
         // 
         this.fgOrders.Properties().AllowBigSelection = false;
         this.fgOrders.AllowDrop = true;
         this.fgOrders.AllowUserToAddRows = false;
         this.fgOrders.AllowUserToDeleteRows = false;
         this.fgOrders.Properties().AllowUserToResizeColumns = false;
         this.fgOrders.Properties().AllowUserToResizeRows = false;
         this.fgOrders.Properties().BorderStyle = Mobilize.Web.BorderStyle.None;
         this.fgOrders.Properties().ColumnHeadersHeightSizeMode = Mobilize.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.fgOrders.ColumnsCount = 1;
         this.fgOrders.FixedColumns = 0;
         this.fgOrders.FixedRows = 0;
         this.fgOrders.Location = new System.Drawing.Point(8, 168);
         this.fgOrders.Name = "fgOrders";
         this.fgOrders.Properties().ReadOnly = true;
         this.fgOrders.RowsCount = 1;
         this.fgOrders.Properties().SelectionMode = Mobilize.Web.DataGridViewSelectionMode.FullRowSelect;
         this.fgOrders.Size = new System.Drawing.Size(505, 265);
         this.fgOrders.Properties().StandardTab = true;
         this.fgOrders.TabIndex = 8;
         this.fgOrders.DoubleClick += new System.EventHandler(this.fgOrders_DoubleClick);
         // 
         // sbStatusBar
         // 
         this.sbStatusBar.AllowDrop = true;
         this.sbStatusBar.Properties().BackColor = Mobilize.Web.SystemColors.Control;
         this.sbStatusBar.Dock = Mobilize.Web.DockStyle.Bottom;
         this.sbStatusBar.Location = new System.Drawing.Point(0, 471);
         this.sbStatusBar.Name = "sbStatusBar";
         this.sbStatusBar.Properties().ShowItemToolTips = true;
         this.sbStatusBar.Size = new System.Drawing.Size(523, 25);
         this.sbStatusBar.TabIndex = 18;
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
         this.cmdCancel.Location = new System.Drawing.Point(328, 440);
         this.cmdCancel.Name = "cmdCancel";
         this.cmdCancel.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdCancel.Size = new System.Drawing.Size(89, 25);
         this.cmdCancel.TabIndex = 11;
         this.cmdCancel.Text = "&Cancel ";
         this.cmdCancel.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdCancel.UseVisualStyleBackColor = false;
         this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
         // 
         // cmdClose
         // 
         this.cmdClose.AllowDrop = true;
         this.cmdClose.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdClose.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdClose.Location = new System.Drawing.Point(424, 440);
         this.cmdClose.Name = "cmdClose";
         this.cmdClose.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdClose.Size = new System.Drawing.Size(89, 25);
         this.cmdClose.TabIndex = 12;
         this.cmdClose.Text = "&Close";
         this.cmdClose.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdClose.UseVisualStyleBackColor = false;
         this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
         // 
         // Frame1
         // 
         this.Frame1.AllowDrop = true;
         this.Frame1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Frame1.Controls.Add(this.cmbStatus);
         this.Frame1.Controls.Add(this.chkTo);
         this.Frame1.Controls.Add(this.chkFrom);
         this.Frame1.Controls.Add(this.txtProductID);
         this.Frame1.Controls.Add(this.txtOrderID);
         this.Frame1.Controls.Add(this.txtContactLastName);
         this.Frame1.Controls.Add(this.txtContactName);
         this.Frame1.Controls.Add(this.cmdProviders);
         this.Frame1.Controls.Add(this.txtProviderName);
         this.Frame1.Controls.Add(this.dtFrom);
         this.Frame1.Controls.Add(this.dtTo);
         this.Frame1.Controls.Add(this.Label5);
         this.Frame1.Controls.Add(this.Label8);
         this.Frame1.Controls.Add(this.Label1);
         this.Frame1.Controls.Add(this.Label6);
         this.Frame1.Controls.Add(this.Label3);
         this.Frame1.Controls.Add(this.Label4);
         this.Frame1.Controls.Add(this.Label2);
         this.Frame1.Enabled = true;
         this.Frame1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Frame1.Location = new System.Drawing.Point(8, 8);
         this.Frame1.Name = "Frame1";
         this.Frame1.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Frame1.Size = new System.Drawing.Size(505, 153);
         this.Frame1.TabIndex = 13;
         this.Frame1.Text = "Search supplier";
         this.Frame1.Visible = true;
         // 
         // cmbStatus
         // 
         this.cmbStatus.AllowDrop = true;
         this.cmbStatus.BackColor = Mobilize.Web.SystemColors.Window;
         this.cmbStatus.CausesValidation = true;
         this.cmbStatus.DropDownStyle = Mobilize.Web.ComboBoxStyle.DropDownList;
         this.cmbStatus.Enabled = true;
         this.cmbStatus.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.cmbStatus.IntegralHeight = true;
         this.cmbStatus.Location = new System.Drawing.Point(336, 16);
         this.cmbStatus.Name = "cmbStatus";
         this.cmbStatus.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmbStatus.Size = new System.Drawing.Size(145, 21);
         this.cmbStatus.Sorted = false;
         this.cmbStatus.TabIndex = 1;
         this.cmbStatus.TabStop = true;
         this.cmbStatus.Visible = true;
         this.cmbStatus.Items.AddRange(new object[]{"All", "Received", "Cancelled", "Approved"});
         this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
         // 
         // chkTo
         // 
         this.chkTo.AllowDrop = true;
         this.chkTo.Appearance = Mobilize.Web.Appearance.Normal;
         this.chkTo.BackColor = Mobilize.Web.SystemColors.Control;
         this.chkTo.CausesValidation = true;
         this.chkTo.CheckAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.chkTo.CheckState = Mobilize.Web.CheckState.Unchecked;
         this.chkTo.Enabled = true;
         this.chkTo.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.chkTo.Location = new System.Drawing.Point(336, 80);
         this.chkTo.Name = "chkTo";
         this.chkTo.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.chkTo.Size = new System.Drawing.Size(41, 17);
         this.chkTo.TabIndex = 23;
         this.chkTo.TabStop = false;
         this.chkTo.Text = "To:";
         this.chkTo.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.chkTo.Visible = true;
         // 
         // chkFrom
         // 
         this.chkFrom.AllowDrop = true;
         this.chkFrom.Appearance = Mobilize.Web.Appearance.Normal;
         this.chkFrom.BackColor = Mobilize.Web.SystemColors.Control;
         this.chkFrom.CausesValidation = true;
         this.chkFrom.CheckAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.chkFrom.CheckState = Mobilize.Web.CheckState.Unchecked;
         this.chkFrom.Enabled = true;
         this.chkFrom.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.chkFrom.Location = new System.Drawing.Point(88, 80);
         this.chkFrom.Name = "chkFrom";
         this.chkFrom.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.chkFrom.Size = new System.Drawing.Size(47, 17);
         this.chkFrom.TabIndex = 22;
         this.chkFrom.TabStop = false;
         this.chkFrom.Text = "From:";
         this.chkFrom.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.chkFrom.Visible = true;
         // 
         // txtProductID
         // 
         this.txtProductID.AcceptsReturn = true;
         this.txtProductID.AllowDrop = true;
         this.txtProductID.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtProductID.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtProductID.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtProductID.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtProductID.Location = new System.Drawing.Point(336, 112);
         this.txtProductID.MaxLength = 0;
         this.txtProductID.Name = "txtProductID";
         this.txtProductID.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtProductID.Size = new System.Drawing.Size(145, 20);
         this.txtProductID.TabIndex = 7;
         this.txtProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
         // 
         // txtOrderID
         // 
         this.txtOrderID.AcceptsReturn = true;
         this.txtOrderID.AllowDrop = true;
         this.txtOrderID.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtOrderID.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtOrderID.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtOrderID.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtOrderID.Location = new System.Drawing.Point(88, 112);
         this.txtOrderID.MaxLength = 0;
         this.txtOrderID.Name = "txtOrderID";
         this.txtOrderID.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtOrderID.Size = new System.Drawing.Size(145, 20);
         this.txtOrderID.TabIndex = 6;
         this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
         // 
         // txtContactLastName
         // 
         this.txtContactLastName.AcceptsReturn = true;
         this.txtContactLastName.AllowDrop = true;
         this.txtContactLastName.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtContactLastName.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtContactLastName.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtContactLastName.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtContactLastName.Location = new System.Drawing.Point(336, 48);
         this.txtContactLastName.MaxLength = 0;
         this.txtContactLastName.Name = "txtContactLastName";
         this.txtContactLastName.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtContactLastName.Size = new System.Drawing.Size(145, 20);
         this.txtContactLastName.TabIndex = 3;
         this.txtContactLastName.TextChanged += new System.EventHandler(this.txtContactLastName_TextChanged);
         // 
         // txtContactName
         // 
         this.txtContactName.AcceptsReturn = true;
         this.txtContactName.AllowDrop = true;
         this.txtContactName.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtContactName.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtContactName.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtContactName.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtContactName.Location = new System.Drawing.Point(88, 48);
         this.txtContactName.MaxLength = 0;
         this.txtContactName.Name = "txtContactName";
         this.txtContactName.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtContactName.Size = new System.Drawing.Size(145, 20);
         this.txtContactName.TabIndex = 2;
         this.txtContactName.TextChanged += new System.EventHandler(this.txtContactName_TextChanged);
         // 
         // cmdProviders
         // 
         this.cmdProviders.AllowDrop = true;
         this.cmdProviders.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdProviders.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdProviders.Location = new System.Drawing.Point(240, 16);
         this.cmdProviders.Name = "cmdProviders";
         this.cmdProviders.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdProviders.Size = new System.Drawing.Size(25, 21);
         this.cmdProviders.TabIndex = 14;
         this.cmdProviders.TabStop = false;
         this.cmdProviders.Text = "...";
         this.cmdProviders.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdProviders.UseVisualStyleBackColor = false;
         this.cmdProviders.Click += new System.EventHandler(this.cmdProviders_Click);
         // 
         // txtProviderName
         // 
         this.txtProviderName.AcceptsReturn = true;
         this.txtProviderName.AllowDrop = true;
         this.txtProviderName.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtProviderName.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtProviderName.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtProviderName.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtProviderName.Location = new System.Drawing.Point(88, 16);
         this.txtProviderName.MaxLength = 0;
         this.txtProviderName.Name = "txtProviderName";
         this.txtProviderName.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtProviderName.Size = new System.Drawing.Size(145, 20);
         this.txtProviderName.TabIndex = 0;
         this.txtProviderName.TextChanged += new System.EventHandler(this.txtProviderName_TextChanged);
         // 
         // dtFrom
         // 
         this.dtFrom.AllowDrop = true;
         this.dtFrom.Checked = false;
         this.dtFrom.Format = Mobilize.Web.DateTimePickerFormat.Short;
         this.dtFrom.Location = new System.Drawing.Point(136, 80);
         this.dtFrom.Name = "dtFrom";
         this.dtFrom.Size = new System.Drawing.Size(97, 20);
         this.dtFrom.TabIndex = 4;
         this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
         // 
         // dtTo
         // 
         this.dtTo.AllowDrop = true;
         this.dtTo.Checked = false;
         this.dtTo.Format = Mobilize.Web.DateTimePickerFormat.Short;
         this.dtTo.Location = new System.Drawing.Point(384, 80);
         this.dtTo.Name = "dtTo";
         this.dtTo.Size = new System.Drawing.Size(97, 20);
         this.dtTo.TabIndex = 5;
         this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
         // 
         // Label5
         // 
         this.Label5.AllowDrop = true;
         this.Label5.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label5.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label5.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label5.Location = new System.Drawing.Point(288, 20);
         this.Label5.Name = "Label5";
         this.Label5.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label5.Size = new System.Drawing.Size(41, 17);
         this.Label5.TabIndex = 24;
         this.Label5.Text = "Status";
         // 
         // Label8
         // 
         this.Label8.AllowDrop = true;
         this.Label8.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label8.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label8.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label8.Location = new System.Drawing.Point(264, 112);
         this.Label8.Name = "Label8";
         this.Label8.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label8.Size = new System.Drawing.Size(65, 17);
         this.Label8.TabIndex = 21;
         this.Label8.Text = "Product";
         // 
         // Label1
         // 
         this.Label1.AllowDrop = true;
         this.Label1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label1.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label1.Location = new System.Drawing.Point(8, 112);
         this.Label1.Name = "Label1";
         this.Label1.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label1.Size = new System.Drawing.Size(89, 17);
         this.Label1.TabIndex = 20;
         this.Label1.Text = "Order";
         // 
         // Label6
         // 
         this.Label6.AllowDrop = true;
         this.Label6.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label6.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label6.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label6.Location = new System.Drawing.Point(8, 80);
         this.Label6.Name = "Label6";
         this.Label6.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label6.Size = new System.Drawing.Size(65, 17);
         this.Label6.TabIndex = 19;
         this.Label6.Text = "Dates";
         // 
         // Label3
         // 
         this.Label3.AllowDrop = true;
         this.Label3.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label3.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label3.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label3.Location = new System.Drawing.Point(264, 48);
         this.Label3.Name = "Label3";
         this.Label3.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label3.Size = new System.Drawing.Size(57, 17);
         this.Label3.TabIndex = 17;
         this.Label3.Text = "Last Name";
         // 
         // Label4
         // 
         this.Label4.AllowDrop = true;
         this.Label4.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label4.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label4.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label4.Location = new System.Drawing.Point(8, 16);
         this.Label4.Name = "Label4";
         this.Label4.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label4.Size = new System.Drawing.Size(89, 17);
         this.Label4.TabIndex = 16;
         this.Label4.Text = "Supplier";
         // 
         // Label2
         // 
         this.Label2.AllowDrop = true;
         this.Label2.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label2.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label2.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label2.Location = new System.Drawing.Point(8, 48);
         this.Label2.Name = "Label2";
         this.Label2.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label2.Size = new System.Drawing.Size(89, 17);
         this.Label2.TabIndex = 15;
         this.Label2.Text = "First Name";
         // 
         // frmReceptionApproval
         // 
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.AutoScroll = true;
         this.BackColor = Mobilize.Web.SystemColors.Control;
         this.Properties().ClientSize = new System.Drawing.Size(523, 496);
         this.Controls.Add(this.cmdApprove);
         this.Controls.Add(this.cmdInfo);
         this.Controls.Add(this.fgOrders);
         this.Controls.Add(this.sbStatusBar);
         this.Controls.Add(this.cmdCancel);
         this.Controls.Add(this.cmdClose);
         this.Controls.Add(this.Frame1);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedSingle;
         this.Properties().Location = new System.Drawing.Point(3, 25);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmReceptionApproval";
         this.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.Manual;
         this.Text = "Add Stock to Inventory";
         this.listBoxComboBoxHelper1.SetItemData(this.cmbStatus, new int[]{0, 0, 0, 0});
         this.Closed += new System.EventHandler(this.Form_Closed);
         this.sbStatusBar.ResumeLayout(false);
         this.Frame1.ResumeLayout(false);
         this.ResumeLayout(false);

#line hidden
this.Controls.DesignTime=false;
#line 615
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
