#pragma warning disable
#line 1 "frmOrderReception.Designer.cs"
#pragma warning disable
#line 1 "frmOrderReception.Designer.cs"
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmOrderReception
   {

      [Intercepted]

      #region "Upgrade Support "
      private static frmOrderReception m_vb6FormDefInstance 
#line 13
                                                            { 
#line 13
                                                              get                                                                 
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (SKS.frmOrderReception)catalog.frmOrderReception.m_vb6FormDefInstance;} 
#line 13

#line 13
                                                                   set                                                                      
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmOrderReception.m_vb6FormDefInstance = value;} 
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
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (bool)catalog.frmOrderReception.m_InitializingDefInstance;} 
#line 16

#line 16
                                                           set                                                              
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmOrderReception.m_InitializingDefInstance = value;} 
#line 16
                                                                }

#line 17

      [Intercepted]
      public static frmOrderReception DefInstance
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

      public static frmOrderReception CreateInstance()
      {
      	frmOrderReception theInstance = new frmOrderReception();
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
private Mobilize.Web.TextBox txtNotes_k__BackingField;
#line 59


      [Intercepted]
      public Mobilize.Web.TextBox txtNotes 
#line 59
                                           { 
#line 59
                                             get                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtNotes)<=0){this.txtNotes_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,3);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtNotes;;} return this.txtNotes_k__BackingField; } 
#line 59

#line 59
                                                  set                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,3,this.txtNotes_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtNotes;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtNotes;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtNotes_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 59
                                                       }

#line 60

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtSubTotal_k__BackingField;
#line 62


      [Intercepted]
      public Mobilize.Web.TextBox txtSubTotal 
#line 62
                                              { 
#line 62
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtSubTotal)<=0){this.txtSubTotal_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,4);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtSubTotal;;} return this.txtSubTotal_k__BackingField; } 
#line 62

#line 62
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,4,this.txtSubTotal_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtSubTotal;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtSubTotal;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtSubTotal_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 62
                                                          }

#line 63

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtTotal_k__BackingField;
#line 65


      [Intercepted]
      public Mobilize.Web.TextBox txtTotal 
#line 65
                                           { 
#line 65
                                             get                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtTotal)<=0){this.txtTotal_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,5);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtTotal;;} return this.txtTotal_k__BackingField; } 
#line 65

#line 65
                                                  set                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,5,this.txtTotal_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtTotal;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtTotal;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtTotal_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 65
                                                       }

#line 66

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtTotalTax_k__BackingField;
#line 68


      [Intercepted]
      public Mobilize.Web.TextBox txtTotalTax 
#line 68
                                              { 
#line 68
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtTotalTax)<=0){this.txtTotalTax_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,6);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtTotalTax;;} return this.txtTotalTax_k__BackingField; } 
#line 68

#line 68
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,6,this.txtTotalTax_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtTotalTax;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtTotalTax;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtTotalTax_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 68
                                                          }

#line 69

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtFreightCharge_k__BackingField;
#line 71


      [Intercepted]
      public Mobilize.Web.TextBox txtFreightCharge 
#line 71
                                                   { 
#line 71
                                                     get                                                        
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtFreightCharge)<=0){this.txtFreightCharge_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,7);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtFreightCharge;;} return this.txtFreightCharge_k__BackingField; } 
#line 71

#line 71
                                                          set                                                             
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,7,this.txtFreightCharge_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtFreightCharge;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtFreightCharge;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtFreightCharge_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 71
                                                               }

#line 72

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtSalesTax_k__BackingField;
#line 74


      [Intercepted]
      public Mobilize.Web.TextBox txtSalesTax 
#line 74
                                              { 
#line 74
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtSalesTax)<=0){this.txtSalesTax_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,8);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtSalesTax;;} return this.txtSalesTax_k__BackingField; } 
#line 74

#line 74
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,8,this.txtSalesTax_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtSalesTax;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtSalesTax;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtSalesTax_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 74
                                                          }

#line 75

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtEntry_k__BackingField;
#line 77


      [Intercepted]
      public Mobilize.Web.TextBox txtEntry 
#line 77
                                           { 
#line 77
                                             get                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtEntry)<=0){this.txtEntry_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,9);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtEntry;;} return this.txtEntry_k__BackingField; } 
#line 77

#line 77
                                                  set                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,9,this.txtEntry_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtEntry;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtEntry;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtEntry_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 77
                                                       }

#line 78

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.VBUC.FlexGrid fgProducts_k__BackingField;
#line 80


      [Intercepted]
      public Mobilize.Web.VBUC.FlexGrid fgProducts 
#line 80
                                                   { 
#line 80
                                                     get                                                        
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_fgProducts)<=0){this.fgProducts_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.VBUC.FlexGrid>(this,_Mobilize_References,10);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_fgProducts;;} return this.fgProducts_k__BackingField; } 
#line 80

#line 80
                                                          set                                                             
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.VBUC.FlexGrid>(this,_Mobilize_References,10,this.fgProducts_k__BackingField,(Mobilize.Web.VBUC.FlexGrid)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_fgProducts;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_fgProducts;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.fgProducts_k__BackingField=(Mobilize.Web.VBUC.FlexGrid)value;} 
#line 80
                                                               }

#line 81

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel1_k__BackingField;
#line 83


      [Intercepted]
      public Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel1 
#line 83
                                                                         { 
#line 83
                                                                           get                                                                              
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_sbStatusBar_Panels_Panel1)<=0){this.sbStatusBar_Panels_Panel1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripStatusLabel>(this,_Mobilize_References,11);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar_Panels_Panel1;;} return this.sbStatusBar_Panels_Panel1_k__BackingField; } 
#line 83

#line 83
                                                                                set                                                                                   
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripStatusLabel>(this,_Mobilize_References,11,this.sbStatusBar_Panels_Panel1_k__BackingField,(Mobilize.Web.ToolStripStatusLabel)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_sbStatusBar_Panels_Panel1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar_Panels_Panel1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.sbStatusBar_Panels_Panel1_k__BackingField=(Mobilize.Web.ToolStripStatusLabel)value;} 
#line 83
                                                                                     }

#line 84

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.StatusStrip sbStatusBar_k__BackingField;
#line 86


      [Intercepted]
      public Mobilize.Web.StatusStrip sbStatusBar 
#line 86
                                                  { 
#line 86
                                                    get                                                       
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_sbStatusBar)<=0){this.sbStatusBar_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.StatusStrip>(this,_Mobilize_References,12);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar;;} return this.sbStatusBar_k__BackingField; } 
#line 86

#line 86
                                                         set                                                            
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.StatusStrip>(this,_Mobilize_References,12,this.sbStatusBar_k__BackingField,(Mobilize.Web.StatusStrip)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_sbStatusBar;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.sbStatusBar_k__BackingField=(Mobilize.Web.StatusStrip)value;} 
#line 86
                                                              }

#line 87

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdSave_k__BackingField;
#line 89


      [Intercepted]
      public Mobilize.Web.Button cmdSave 
#line 89
                                         { 
#line 89
                                           get                                              
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdSave)<=0){this.cmdSave_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,13);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdSave;;} return this.cmdSave_k__BackingField; } 
#line 89

#line 89
                                                set                                                   
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,13,this.cmdSave_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdSave;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdSave;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdSave_k__BackingField=(Mobilize.Web.Button)value;} 
#line 89
                                                     }

#line 90

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdClose_k__BackingField;
#line 92


      [Intercepted]
      public Mobilize.Web.Button cmdClose 
#line 92
                                          { 
#line 92
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdClose)<=0){this.cmdClose_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,14);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdClose;;} return this.cmdClose_k__BackingField; } 
#line 92

#line 92
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,14,this.cmdClose_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdClose;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdClose;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdClose_k__BackingField=(Mobilize.Web.Button)value;} 
#line 92
                                                      }

#line 93

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdAddProducts_k__BackingField;
#line 95


      [Intercepted]
      public Mobilize.Web.Button cmdAddProducts 
#line 95
                                                { 
#line 95
                                                  get                                                     
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdAddProducts)<=0){this.cmdAddProducts_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,15);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdAddProducts;;} return this.cmdAddProducts_k__BackingField; } 
#line 95

#line 95
                                                       set                                                          
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,15,this.cmdAddProducts_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdAddProducts;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdAddProducts;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdAddProducts_k__BackingField=(Mobilize.Web.Button)value;} 
#line 95
                                                            }

#line 96

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtProviderName_k__BackingField;
#line 98


      [Intercepted]
      public Mobilize.Web.TextBox txtProviderName 
#line 98
                                                  { 
#line 98
                                                    get                                                       
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtProviderName)<=0){this.txtProviderName_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,16);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtProviderName;;} return this.txtProviderName_k__BackingField; } 
#line 98

#line 98
                                                         set                                                            
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,16,this.txtProviderName_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtProviderName;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtProviderName;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtProviderName_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 98
                                                              }

#line 99

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtContactLastName_k__BackingField;
#line 101


      [Intercepted]
      public Mobilize.Web.TextBox txtContactLastName 
#line 101
                                                     { 
#line 101
                                                       get                                                          
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtContactLastName)<=0){this.txtContactLastName_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,17);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtContactLastName;;} return this.txtContactLastName_k__BackingField; } 
#line 101

#line 101
                                                            set                                                               
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,17,this.txtContactLastName_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtContactLastName;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtContactLastName;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtContactLastName_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 101
                                                                 }

#line 102

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtContactName_k__BackingField;
#line 104


      [Intercepted]
      public Mobilize.Web.TextBox txtContactName 
#line 104
                                                 { 
#line 104
                                                   get                                                      
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtContactName)<=0){this.txtContactName_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,18);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtContactName;;} return this.txtContactName_k__BackingField; } 
#line 104

#line 104
                                                        set                                                           
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,18,this.txtContactName_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtContactName;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtContactName;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtContactName_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 104
                                                             }

#line 105

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdProviders_k__BackingField;
#line 107


      [Intercepted]
      public Mobilize.Web.Button cmdProviders 
#line 107
                                              { 
#line 107
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdProviders)<=0){this.cmdProviders_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,19);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdProviders;;} return this.cmdProviders_k__BackingField; } 
#line 107

#line 107
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,19,this.cmdProviders_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdProviders;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdProviders;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdProviders_k__BackingField=(Mobilize.Web.Button)value;} 
#line 107
                                                          }

#line 108

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProviders_ColumnHeader_1__k__BackingField;
#line 110


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProviders_ColumnHeader_1_ 
#line 110
                                                                           { 
#line 110
                                                                             get                                                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProviders_ColumnHeader_1_)<=0){this.lvProviders_ColumnHeader_1__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,20);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProviders_ColumnHeader_1_;;} return this.lvProviders_ColumnHeader_1__k__BackingField; } 
#line 110

#line 110
                                                                                  set                                                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,20,this.lvProviders_ColumnHeader_1__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lvProviders_ColumnHeader_1_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProviders_ColumnHeader_1_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProviders_ColumnHeader_1__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 110
                                                                                       }

#line 111

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProviders_ColumnHeader_2__k__BackingField;
#line 113


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProviders_ColumnHeader_2_ 
#line 113
                                                                           { 
#line 113
                                                                             get                                                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProviders_ColumnHeader_2_)<=0){this.lvProviders_ColumnHeader_2__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,21);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProviders_ColumnHeader_2_;;} return this.lvProviders_ColumnHeader_2__k__BackingField; } 
#line 113

#line 113
                                                                                  set                                                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,21,this.lvProviders_ColumnHeader_2__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lvProviders_ColumnHeader_2_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProviders_ColumnHeader_2_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProviders_ColumnHeader_2__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 113
                                                                                       }

#line 114

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProviders_ColumnHeader_3__k__BackingField;
#line 116


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProviders_ColumnHeader_3_ 
#line 116
                                                                           { 
#line 116
                                                                             get                                                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProviders_ColumnHeader_3_)<=0){this.lvProviders_ColumnHeader_3__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,22);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProviders_ColumnHeader_3_;;} return this.lvProviders_ColumnHeader_3__k__BackingField; } 
#line 116

#line 116
                                                                                  set                                                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,22,this.lvProviders_ColumnHeader_3__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lvProviders_ColumnHeader_3_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProviders_ColumnHeader_3_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProviders_ColumnHeader_3__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 116
                                                                                       }

#line 117

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProviders_ColumnHeader_4__k__BackingField;
#line 119


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProviders_ColumnHeader_4_ 
#line 119
                                                                           { 
#line 119
                                                                             get                                                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProviders_ColumnHeader_4_)<=0){this.lvProviders_ColumnHeader_4__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,23);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProviders_ColumnHeader_4_;;} return this.lvProviders_ColumnHeader_4__k__BackingField; } 
#line 119

#line 119
                                                                                  set                                                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,23,this.lvProviders_ColumnHeader_4__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvProviders_ColumnHeader_4_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProviders_ColumnHeader_4_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProviders_ColumnHeader_4__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 119
                                                                                       }

#line 120

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProviders_ColumnHeader_5__k__BackingField;
#line 122


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProviders_ColumnHeader_5_ 
#line 122
                                                                           { 
#line 122
                                                                             get                                                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProviders_ColumnHeader_5_)<=0){this.lvProviders_ColumnHeader_5__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,24);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProviders_ColumnHeader_5_;;} return this.lvProviders_ColumnHeader_5__k__BackingField; } 
#line 122

#line 122
                                                                                  set                                                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,24,this.lvProviders_ColumnHeader_5__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvProviders_ColumnHeader_5_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProviders_ColumnHeader_5_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProviders_ColumnHeader_5__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 122
                                                                                       }

#line 123

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProviders_ColumnHeader_6__k__BackingField;
#line 125


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProviders_ColumnHeader_6_ 
#line 125
                                                                           { 
#line 125
                                                                             get                                                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProviders_ColumnHeader_6_)<=0){this.lvProviders_ColumnHeader_6__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,25);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProviders_ColumnHeader_6_;;} return this.lvProviders_ColumnHeader_6__k__BackingField; } 
#line 125

#line 125
                                                                                  set                                                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,25,this.lvProviders_ColumnHeader_6__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvProviders_ColumnHeader_6_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProviders_ColumnHeader_6_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProviders_ColumnHeader_6__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 125
                                                                                       }

#line 126

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProviders_ColumnHeader_7__k__BackingField;
#line 128


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProviders_ColumnHeader_7_ 
#line 128
                                                                           { 
#line 128
                                                                             get                                                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProviders_ColumnHeader_7_)<=0){this.lvProviders_ColumnHeader_7__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,26);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProviders_ColumnHeader_7_;;} return this.lvProviders_ColumnHeader_7__k__BackingField; } 
#line 128

#line 128
                                                                                  set                                                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,26,this.lvProviders_ColumnHeader_7__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvProviders_ColumnHeader_7_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProviders_ColumnHeader_7_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProviders_ColumnHeader_7__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 128
                                                                                       }

#line 129

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListView lvProviders_k__BackingField;
#line 131


      [Intercepted]
      public Mobilize.Web.ListView lvProviders 
#line 131
                                               { 
#line 131
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProviders)<=0){this.lvProviders_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListView>(this,_Mobilize_References,27);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProviders;;} return this.lvProviders_k__BackingField; } 
#line 131

#line 131
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListView>(this,_Mobilize_References,27,this.lvProviders_k__BackingField,(Mobilize.Web.ListView)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvProviders;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProviders;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProviders_k__BackingField=(Mobilize.Web.ListView)value;} 
#line 131
                                                           }

#line 132

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label3_k__BackingField;
#line 134


      [Intercepted]
      public Mobilize.Web.Label Label3 
#line 134
                                       { 
#line 134
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label3)<=0){this.Label3_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,28);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label3;;} return this.Label3_k__BackingField; } 
#line 134

#line 134
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,28,this.Label3_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label3;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label3;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label3_k__BackingField=(Mobilize.Web.Label)value;} 
#line 134
                                                   }

#line 135

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label4_k__BackingField;
#line 137


      [Intercepted]
      public Mobilize.Web.Label Label4 
#line 137
                                       { 
#line 137
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label4)<=0){this.Label4_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,29);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label4;;} return this.Label4_k__BackingField; } 
#line 137

#line 137
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,29,this.Label4_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label4;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label4;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label4_k__BackingField=(Mobilize.Web.Label)value;} 
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
private Mobilize.Web.GroupBox Frame1_k__BackingField;
#line 143


      [Intercepted]
      public Mobilize.Web.GroupBox Frame1 
#line 143
                                          { 
#line 143
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Frame1)<=0){this.Frame1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.GroupBox>(this,_Mobilize_References,31);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Frame1;;} return this.Frame1_k__BackingField; } 
#line 143

#line 143
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.GroupBox>(this,_Mobilize_References,31,this.Frame1_k__BackingField,(Mobilize.Web.GroupBox)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Frame1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Frame1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Frame1_k__BackingField=(Mobilize.Web.GroupBox)value;} 
#line 143
                                                      }

#line 144

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtProviderContact_k__BackingField;
#line 146


      [Intercepted]
      public Mobilize.Web.TextBox txtProviderContact 
#line 146
                                                     { 
#line 146
                                                       get                                                          
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_txtProviderContact)<=0){this.txtProviderContact_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,32);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_txtProviderContact;;} return this.txtProviderContact_k__BackingField; } 
#line 146

#line 146
                                                            set                                                               
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,32,this.txtProviderContact_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_txtProviderContact;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_txtProviderContact;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtProviderContact_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 146
                                                                 }

#line 147

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtProviderCompany_k__BackingField;
#line 149


      [Intercepted]
      public Mobilize.Web.TextBox txtProviderCompany 
#line 149
                                                     { 
#line 149
                                                       get                                                          
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_txtProviderCompany)<=0){this.txtProviderCompany_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,33);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_txtProviderCompany;;} return this.txtProviderCompany_k__BackingField; } 
#line 149

#line 149
                                                            set                                                               
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,33,this.txtProviderCompany_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_txtProviderCompany;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_txtProviderCompany;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtProviderCompany_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 149
                                                                 }

#line 150

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label5_k__BackingField;
#line 152


      [Intercepted]
      public Mobilize.Web.Label Label5 
#line 152
                                       { 
#line 152
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label5)<=0){this.Label5_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,34);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label5;;} return this.Label5_k__BackingField; } 
#line 152

#line 152
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,34,this.Label5_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label5;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label5;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label5_k__BackingField=(Mobilize.Web.Label)value;} 
#line 152
                                                   }

#line 153

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label1_k__BackingField;
#line 155


      [Intercepted]
      public Mobilize.Web.Label Label1 
#line 155
                                       { 
#line 155
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label1)<=0){this.Label1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,35);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label1;;} return this.Label1_k__BackingField; } 
#line 155

#line 155
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,35,this.Label1_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label1;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label1_k__BackingField=(Mobilize.Web.Label)value;} 
#line 155
                                                   }

#line 156

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.GroupBox Frame2_k__BackingField;
#line 158


      [Intercepted]
      public Mobilize.Web.GroupBox Frame2 
#line 158
                                          { 
#line 158
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Frame2)<=0){this.Frame2_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.GroupBox>(this,_Mobilize_References,36);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Frame2;;} return this.Frame2_k__BackingField; } 
#line 158

#line 158
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.GroupBox>(this,_Mobilize_References,36,this.Frame2_k__BackingField,(Mobilize.Web.GroupBox)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Frame2;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Frame2;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Frame2_k__BackingField=(Mobilize.Web.GroupBox)value;} 
#line 158
                                                      }

#line 159

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label7_k__BackingField;
#line 161


      [Intercepted]
      public Mobilize.Web.Label Label7 
#line 161
                                       { 
#line 161
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label7)<=0){this.Label7_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,37);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label7;;} return this.Label7_k__BackingField; } 
#line 161

#line 161
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,37,this.Label7_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label7;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label7;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label7_k__BackingField=(Mobilize.Web.Label)value;} 
#line 161
                                                   }

#line 162

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label12_k__BackingField;
#line 164


      [Intercepted]
      public Mobilize.Web.Label Label12 
#line 164
                                        { 
#line 164
                                          get                                             
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label12)<=0){this.Label12_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,38);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label12;;} return this.Label12_k__BackingField; } 
#line 164

#line 164
                                               set                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,38,this.Label12_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label12;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label12;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label12_k__BackingField=(Mobilize.Web.Label)value;} 
#line 164
                                                    }

#line 165

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label11_k__BackingField;
#line 167


      [Intercepted]
      public Mobilize.Web.Label Label11 
#line 167
                                        { 
#line 167
                                          get                                             
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label11)<=0){this.Label11_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,39);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label11;;} return this.Label11_k__BackingField; } 
#line 167

#line 167
                                               set                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,39,this.Label11_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label11;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label11;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label11_k__BackingField=(Mobilize.Web.Label)value;} 
#line 167
                                                    }

#line 168

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label10_k__BackingField;
#line 170


      [Intercepted]
      public Mobilize.Web.Label Label10 
#line 170
                                        { 
#line 170
                                          get                                             
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label10)<=0){this.Label10_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,40);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label10;;} return this.Label10_k__BackingField; } 
#line 170

#line 170
                                               set                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,40,this.Label10_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label10;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label10;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label10_k__BackingField=(Mobilize.Web.Label)value;} 
#line 170
                                                    }

#line 171

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label9_k__BackingField;
#line 173


      [Intercepted]
      public Mobilize.Web.Label Label9 
#line 173
                                       { 
#line 173
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label9)<=0){this.Label9_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,41);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label9;;} return this.Label9_k__BackingField; } 
#line 173

#line 173
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,41,this.Label9_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label9;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label9;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label9_k__BackingField=(Mobilize.Web.Label)value;} 
#line 173
                                                   }

#line 174

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label8_k__BackingField;
#line 176


      [Intercepted]
      public Mobilize.Web.Label Label8 
#line 176
                                       { 
#line 176
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label8)<=0){this.Label8_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,42);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label8;;} return this.Label8_k__BackingField; } 
#line 176

#line 176
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,42,this.Label8_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label8;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label8;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label8_k__BackingField=(Mobilize.Web.Label)value;} 
#line 176
                                                   }

#line 177

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label6_k__BackingField;
#line 179


      [Intercepted]
      public Mobilize.Web.Label Label6 
#line 179
                                       { 
#line 179
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label6)<=0){this.Label6_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,43);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label6;;} return this.Label6_k__BackingField; } 
#line 179

#line 179
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,43,this.Label6_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label6;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label6;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label6_k__BackingField=(Mobilize.Web.Label)value;} 
#line 179
                                                   }

#line 180

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListView listViewHelper1_k__BackingField;
#line 182


      [Intercepted]
      private Mobilize.Web.ListView listViewHelper1 
#line 182
                                                    { 
#line 182
                                                      get                                                         
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_listViewHelper1)<=0){this.listViewHelper1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListView>(this,_Mobilize_References,44);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_listViewHelper1;;} return this.listViewHelper1_k__BackingField; } 
#line 182

#line 182
                                                           set                                                              
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListView>(this,_Mobilize_References,44,this.listViewHelper1_k__BackingField,(Mobilize.Web.ListView)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_listViewHelper1;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_listViewHelper1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.listViewHelper1_k__BackingField=(Mobilize.Web.ListView)value;} 
#line 182
                                                                }

#line 183
      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.

      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {

#line hidden
this.Controls.DesignTime=true;
#line 191
      	this.components = new System.ComponentModel.Container();
      	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderReception));
      	this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
      	this.txtNotes = new Mobilize.Web.TextBox();
      	this.txtSubTotal = new Mobilize.Web.TextBox();
      	this.txtTotal = new Mobilize.Web.TextBox();
      	this.txtTotalTax = new Mobilize.Web.TextBox();
      	this.txtFreightCharge = new Mobilize.Web.TextBox();
      	this.txtSalesTax = new Mobilize.Web.TextBox();
      	this.txtEntry = new Mobilize.Web.TextBox();
      	this.fgProducts = new Mobilize.Web.VBUC.FlexGrid(this.components);
      	this.sbStatusBar = new Mobilize.Web.StatusStrip();
      	this.sbStatusBar_Panels_Panel1 = new Mobilize.Web.ToolStripStatusLabel();
      	this.cmdSave = new Mobilize.Web.Button();
      	this.cmdClose = new Mobilize.Web.Button();
      	this.cmdAddProducts = new Mobilize.Web.Button();
      	this.Frame1 = new Mobilize.Web.GroupBox();
      	this.txtProviderName = new Mobilize.Web.TextBox();
      	this.txtContactLastName = new Mobilize.Web.TextBox();
      	this.txtContactName = new Mobilize.Web.TextBox();
      	this.cmdProviders = new Mobilize.Web.Button();
      	this.lvProviders = new Mobilize.Web.ListView();
      	this.lvProviders_ColumnHeader_1_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProviders_ColumnHeader_2_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProviders_ColumnHeader_3_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProviders_ColumnHeader_4_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProviders_ColumnHeader_5_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProviders_ColumnHeader_6_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProviders_ColumnHeader_7_ = new Mobilize.Web.ListViewColumnHeader();
      	this.Label3 = new Mobilize.Web.Label();
      	this.Label4 = new Mobilize.Web.Label();
      	this.Label2 = new Mobilize.Web.Label();
      	this.Frame2 = new Mobilize.Web.GroupBox();
      	this.txtProviderContact = new Mobilize.Web.TextBox();
      	this.txtProviderCompany = new Mobilize.Web.TextBox();
      	this.Label5 = new Mobilize.Web.Label();
      	this.Label1 = new Mobilize.Web.Label();
      	this.Label7 = new Mobilize.Web.Label();
      	this.Label12 = new Mobilize.Web.Label();
      	this.Label11 = new Mobilize.Web.Label();
      	this.Label10 = new Mobilize.Web.Label();
      	this.Label9 = new Mobilize.Web.Label();
      	this.Label8 = new Mobilize.Web.Label();
      	this.Label6 = new Mobilize.Web.Label();
      	this.sbStatusBar.SuspendLayout();
      	this.Frame1.SuspendLayout();
      	this.lvProviders.SuspendLayout();
      	this.Frame2.SuspendLayout();
      	this.SuspendLayout();
      	this.listViewHelper1 = new Mobilize.Web.ListView(this.components);
      	// 
      	// txtNotes
      	// 
      	this.txtNotes.AcceptsReturn = true;
      	this.txtNotes.AllowDrop = true;
      	this.txtNotes.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtNotes.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtNotes.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtNotes.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtNotes.Location = new System.Drawing.Point(56, 240);
         this.txtNotes.MaxLength = 0;
         this.txtNotes.Multiline = true;
         this.txtNotes.Name = "txtNotes";
         this.txtNotes.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtNotes.Size = new System.Drawing.Size(425, 44);
         this.txtNotes.TabIndex = 4;
         this.txtNotes.TextChanged += new System.EventHandler(this.txtNotes_TextChanged);
         // 
         // txtSubTotal
         // 
         this.txtSubTotal.AcceptsReturn = true;
         this.txtSubTotal.AllowDrop = true;
         this.txtSubTotal.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtSubTotal.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtSubTotal.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtSubTotal.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtSubTotal.Location = new System.Drawing.Point(352, 536);
         this.txtSubTotal.MaxLength = 0;
         this.txtSubTotal.Name = "txtSubTotal";
         this.txtSubTotal.ReadOnly = true;
         this.txtSubTotal.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtSubTotal.Size = new System.Drawing.Size(145, 20);
         this.txtSubTotal.TabIndex = 31;
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
         this.txtTotal.Location = new System.Drawing.Point(88, 560);
         this.txtTotal.MaxLength = 0;
         this.txtTotal.Name = "txtTotal";
         this.txtTotal.ReadOnly = true;
         this.txtTotal.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtTotal.Size = new System.Drawing.Size(145, 20);
         this.txtTotal.TabIndex = 29;
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
         this.txtTotalTax.Location = new System.Drawing.Point(352, 512);
         this.txtTotalTax.MaxLength = 0;
         this.txtTotalTax.Name = "txtTotalTax";
         this.txtTotalTax.ReadOnly = true;
         this.txtTotalTax.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtTotalTax.Size = new System.Drawing.Size(145, 20);
         this.txtTotalTax.TabIndex = 27;
         this.txtTotalTax.TabStop = false;
         this.txtTotalTax.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         // 
         // txtFreightCharge
         // 
         this.txtFreightCharge.AcceptsReturn = true;
         this.txtFreightCharge.AllowDrop = true;
         this.txtFreightCharge.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtFreightCharge.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtFreightCharge.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtFreightCharge.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtFreightCharge.Location = new System.Drawing.Point(88, 536);
         this.txtFreightCharge.MaxLength = 0;
         this.txtFreightCharge.Name = "txtFreightCharge";
         this.txtFreightCharge.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtFreightCharge.Size = new System.Drawing.Size(145, 20);
         this.txtFreightCharge.TabIndex = 7;
         this.txtFreightCharge.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this.txtFreightCharge.KeyPress += new Mobilize.Web.KeyPressEventHandler(this.txtFreightCharge_KeyPress);
         this.txtFreightCharge.TextChanged += new System.EventHandler(this.txtFreightCharge_TextChanged);
         // 
         // txtSalesTax
         // 
         this.txtSalesTax.AcceptsReturn = true;
         this.txtSalesTax.AllowDrop = true;
         this.txtSalesTax.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtSalesTax.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtSalesTax.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtSalesTax.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtSalesTax.Location = new System.Drawing.Point(88, 512);
         this.txtSalesTax.MaxLength = 0;
         this.txtSalesTax.Name = "txtSalesTax";
         this.txtSalesTax.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtSalesTax.Size = new System.Drawing.Size(145, 20);
         this.txtSalesTax.TabIndex = 6;
         this.txtSalesTax.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this.txtSalesTax.KeyPress += new Mobilize.Web.KeyPressEventHandler(this.txtSalesTax_KeyPress);
         this.txtSalesTax.TextChanged += new System.EventHandler(this.txtSalesTax_TextChanged);
         // 
         // txtEntry
         // 
         this.txtEntry.AcceptsReturn = true;
         this.txtEntry.AllowDrop = true;
         this.txtEntry.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtEntry.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtEntry.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtEntry.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtEntry.Location = new System.Drawing.Point(88, 488);
         this.txtEntry.MaxLength = 0;
         this.txtEntry.Name = "txtEntry";
         this.txtEntry.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtEntry.Size = new System.Drawing.Size(145, 19);
         this.txtEntry.TabIndex = 24;
         this.txtEntry.Visible = false;
         this.txtEntry.KeyDown += new Mobilize.Web.KeyEventHandler(this.txtEntry_KeyDown);
         this.txtEntry.KeyPress += new Mobilize.Web.KeyPressEventHandler(this.txtEntry_KeyPress);
         this.txtEntry.Leave += new System.EventHandler(this.txtEntry_Leave);
         // 
         // fgProducts
         // 
         this.fgProducts.AllowDrop = true;
         this.fgProducts.AllowUserToAddRows = false;
         this.fgProducts.AllowUserToDeleteRows = false;
         this.fgProducts.Properties().AllowUserToResizeColumns = false;
         this.fgProducts.Properties().AllowUserToResizeRows = false;
         this.fgProducts.Properties().BorderStyle = Mobilize.Web.BorderStyle.None;
         this.fgProducts.Properties().ColumnHeadersHeightSizeMode = Mobilize.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.fgProducts.ColumnsCount = 0;
         this.fgProducts.FixedColumns = 0;
         this.fgProducts.FixedRows = 0;
         this.fgProducts.Location = new System.Drawing.Point(8, 288);
         this.fgProducts.Name = "fgProducts";
         this.fgProducts.Properties().ReadOnly = true;
         this.fgProducts.Size = new System.Drawing.Size(505, 177);
         this.fgProducts.Properties().StandardTab = true;
         this.fgProducts.TabIndex = 5;
         this.fgProducts.CellLeave += new Mobilize.Web.DataGridViewCellEventHandler(this.fgProducts_CellLeave);
         this.fgProducts.Click += new System.EventHandler(this.fgProducts_Click);
         this.fgProducts.KeyPress += new Mobilize.Web.KeyPressEventHandler(this.fgProducts_KeyPress);
         // 
         // sbStatusBar
         // 
         this.sbStatusBar.AllowDrop = true;
         this.sbStatusBar.Properties().BackColor = Mobilize.Web.SystemColors.Control;
         this.sbStatusBar.Dock = Mobilize.Web.DockStyle.Bottom;
         this.sbStatusBar.Location = new System.Drawing.Point(0, 623);
         this.sbStatusBar.Name = "sbStatusBar";
         this.sbStatusBar.Properties().ShowItemToolTips = true;
         this.sbStatusBar.Size = new System.Drawing.Size(521, 25);
         this.sbStatusBar.TabIndex = 23;
         this.sbStatusBar.Items.AddRange(new Mobilize.Web.ToolStripItem[]{this.sbStatusBar_Panels_Panel1});
         // 
         // sbStatusBar_Panels_Panel1
         // 
         this.sbStatusBar_Panels_Panel1.Properties().BorderSides = (Mobilize.Web.ToolStripStatusLabelBorderSides) (Mobilize.Web.ToolStripStatusLabelBorderSides.Left | Mobilize.Web.ToolStripStatusLabelBorderSides.Top | Mobilize.Web.ToolStripStatusLabelBorderSides.Right | Mobilize.Web.ToolStripStatusLabelBorderSides.Bottom);
         this.sbStatusBar_Panels_Panel1.Properties().BorderStyle = Mobilize.Web.Border3DStyle.SunkenOuter;
         this.sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
         this.sbStatusBar_Panels_Panel1.Margin = new Mobilize.Web.Padding(0);
         this.sbStatusBar_Panels_Panel1.Properties().Size = new System.Drawing.Size(521, 25);
         this.sbStatusBar_Panels_Panel1.Properties().Spring = true;
         this.sbStatusBar_Panels_Panel1.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.sbStatusBar_Panels_Panel1.TextImageRelation = Mobilize.Web.TextImageRelation.ImageBeforeText;
         // 
         // cmdSave
         // 
         this.cmdSave.AllowDrop = true;
         this.cmdSave.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdSave.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdSave.Location = new System.Drawing.Point(320, 584);
         this.cmdSave.Name = "cmdSave";
         this.cmdSave.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdSave.Size = new System.Drawing.Size(89, 25);
         this.cmdSave.TabIndex = 8;
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
         this.cmdClose.Location = new System.Drawing.Point(424, 584);
         this.cmdClose.Name = "cmdClose";
         this.cmdClose.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdClose.Size = new System.Drawing.Size(89, 25);
         this.cmdClose.TabIndex = 9;
         this.cmdClose.Text = "&Close";
         this.cmdClose.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdClose.UseVisualStyleBackColor = false;
         this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
         // 
         // cmdAddProducts
         // 
         this.cmdAddProducts.AllowDrop = true;
         this.cmdAddProducts.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdAddProducts.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdAddProducts.Location = new System.Drawing.Point(488, 264);
         this.cmdAddProducts.Name = "cmdAddProducts";
         this.cmdAddProducts.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdAddProducts.Size = new System.Drawing.Size(25, 21);
         this.cmdAddProducts.TabIndex = 21;
         this.cmdAddProducts.TabStop = false;
         this.cmdAddProducts.Text = "...";
         this.cmdAddProducts.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdAddProducts.UseVisualStyleBackColor = false;
         this.cmdAddProducts.Click += new System.EventHandler(this.cmdAddProducts_Click);
         // 
         // Frame1
         // 
         this.Frame1.AllowDrop = true;
         this.Frame1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Frame1.Controls.Add(this.txtProviderName);
         this.Frame1.Controls.Add(this.txtContactLastName);
         this.Frame1.Controls.Add(this.txtContactName);
         this.Frame1.Controls.Add(this.cmdProviders);
         this.Frame1.Controls.Add(this.lvProviders);
         this.Frame1.Controls.Add(this.Label3);
         this.Frame1.Controls.Add(this.Label4);
         this.Frame1.Controls.Add(this.Label2);
         this.Frame1.Enabled = true;
         this.Frame1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Frame1.Location = new System.Drawing.Point(8, 8);
         this.Frame1.Name = "Frame1";
         this.Frame1.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Frame1.Size = new System.Drawing.Size(505, 169);
         this.Frame1.TabIndex = 12;
         this.Frame1.Text = "Search supplier";
         this.Frame1.Visible = true;
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
         this.txtContactLastName.TabIndex = 2;
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
         this.txtContactName.TabIndex = 1;
         this.txtContactName.TextChanged += new System.EventHandler(this.txtContactName_TextChanged);
         // 
         // cmdProviders
         // 
         this.cmdProviders.AllowDrop = true;
         this.cmdProviders.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdProviders.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdProviders.Location = new System.Drawing.Point(456, 16);
         this.cmdProviders.Name = "cmdProviders";
         this.cmdProviders.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdProviders.Size = new System.Drawing.Size(25, 21);
         this.cmdProviders.TabIndex = 13;
         this.cmdProviders.TabStop = false;
         this.cmdProviders.Text = "...";
         this.cmdProviders.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdProviders.UseVisualStyleBackColor = false;
         this.cmdProviders.Click += new System.EventHandler(this.cmdProviders_Click);
         // 
         // lvProviders
         // 
         this.lvProviders.AllowDrop = true;
         this.lvProviders.BackColor = Mobilize.Web.SystemColors.Window;
         this.lvProviders.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.lvProviders.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.lvProviders.FullRowSelect = true;
         this.lvProviders.GridLines = true;
         this.lvProviders.HideSelection = false;
         this.lvProviders.Properties().HotTracking = true;
         this.lvProviders.LabelEdit = false;
         this.lvProviders.Location = new System.Drawing.Point(8, 80);
         this.lvProviders.MultiSelect = false;
         this.lvProviders.Name = "lvProviders";
         this.lvProviders.Size = new System.Drawing.Size(489, 81);
         this.lvProviders.TabIndex = 3;
         this.lvProviders.View = Mobilize.Web.ListViewMode.Details;
         this.lvProviders.Columns.Add(this.lvProviders_ColumnHeader_1_);
         this.lvProviders.Columns.Add(this.lvProviders_ColumnHeader_2_);
         this.lvProviders.Columns.Add(this.lvProviders_ColumnHeader_3_);
         this.lvProviders.Columns.Add(this.lvProviders_ColumnHeader_4_);
         this.lvProviders.Columns.Add(this.lvProviders_ColumnHeader_5_);
         this.lvProviders.Columns.Add(this.lvProviders_ColumnHeader_6_);
         this.lvProviders.Columns.Add(this.lvProviders_ColumnHeader_7_);
         // 
         // lvProviders_ColumnHeader_1_
         // 
         this.lvProviders_ColumnHeader_1_.Text = "Supplier ID";
         this.lvProviders_ColumnHeader_1_.Width = 97;
         // 
         // lvProviders_ColumnHeader_2_
         // 
         this.lvProviders_ColumnHeader_2_.Text = "Supplier Name";
         this.lvProviders_ColumnHeader_2_.Width = 97;
         // 
         // lvProviders_ColumnHeader_3_
         // 
         this.lvProviders_ColumnHeader_3_.Text = "Contact Name";
         this.lvProviders_ColumnHeader_3_.Width = 97;
         // 
         // lvProviders_ColumnHeader_4_
         // 
         this.lvProviders_ColumnHeader_4_.Text = "Contact Last Name";
         this.lvProviders_ColumnHeader_4_.Width = 97;
         // 
         // lvProviders_ColumnHeader_5_
         // 
         this.lvProviders_ColumnHeader_5_.Text = "City";
         this.lvProviders_ColumnHeader_5_.Width = 97;
         // 
         // lvProviders_ColumnHeader_6_
         // 
         this.lvProviders_ColumnHeader_6_.Text = "State";
         this.lvProviders_ColumnHeader_6_.Width = 97;
         // 
         // lvProviders_ColumnHeader_7_
         // 
         this.lvProviders_ColumnHeader_7_.Text = "Country";
         this.lvProviders_ColumnHeader_7_.Width = 97;
         // 
         // Label3
         // 
         this.Label3.AllowDrop = true;
         this.Label3.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label3.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label3.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label3.Location = new System.Drawing.Point(240, 48);
         this.Label3.Name = "Label3";
         this.Label3.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label3.Size = new System.Drawing.Size(97, 17);
         this.Label3.TabIndex = 16;
         this.Label3.Text = "Last name";
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
         this.Label4.TabIndex = 15;
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
         this.Label2.TabIndex = 14;
         this.Label2.Text = "First Name";
         // 
         // Frame2
         // 
         this.Frame2.AllowDrop = true;
         this.Frame2.BackColor = Mobilize.Web.SystemColors.Control;
         this.Frame2.Controls.Add(this.txtProviderContact);
         this.Frame2.Controls.Add(this.txtProviderCompany);
         this.Frame2.Controls.Add(this.Label5);
         this.Frame2.Controls.Add(this.Label1);
         this.Frame2.Enabled = true;
         this.Frame2.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Frame2.Location = new System.Drawing.Point(8, 184);
         this.Frame2.Name = "Frame2";
         this.Frame2.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Frame2.Size = new System.Drawing.Size(505, 49);
         this.Frame2.TabIndex = 11;
         this.Frame2.Text = "Supplier";
         this.Frame2.Visible = true;
         // 
         // txtProviderContact
         // 
         this.txtProviderContact.AcceptsReturn = true;
         this.txtProviderContact.AllowDrop = true;
         this.txtProviderContact.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtProviderContact.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtProviderContact.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtProviderContact.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtProviderContact.Location = new System.Drawing.Point(288, 16);
         this.txtProviderContact.MaxLength = 0;
         this.txtProviderContact.Name = "txtProviderContact";
         this.txtProviderContact.ReadOnly = true;
         this.txtProviderContact.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtProviderContact.Size = new System.Drawing.Size(209, 20);
         this.txtProviderContact.TabIndex = 20;
         this.txtProviderContact.TabStop = false;
         // 
         // txtProviderCompany
         // 
         this.txtProviderCompany.AcceptsReturn = true;
         this.txtProviderCompany.AllowDrop = true;
         this.txtProviderCompany.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtProviderCompany.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtProviderCompany.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtProviderCompany.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtProviderCompany.Location = new System.Drawing.Point(72, 16);
         this.txtProviderCompany.MaxLength = 0;
         this.txtProviderCompany.Name = "txtProviderCompany";
         this.txtProviderCompany.ReadOnly = true;
         this.txtProviderCompany.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtProviderCompany.Size = new System.Drawing.Size(145, 20);
         this.txtProviderCompany.TabIndex = 19;
         this.txtProviderCompany.TabStop = false;
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
         this.Label5.TabIndex = 18;
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
         this.Label1.TabIndex = 17;
         this.Label1.Text = "Contact:";
         // 
         // Label7
         // 
         this.Label7.AllowDrop = true;
         this.Label7.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label7.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label7.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label7.Location = new System.Drawing.Point(8, 488);
         this.Label7.Name = "Label7";
         this.Label7.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label7.Size = new System.Drawing.Size(81, 17);
         this.Label7.TabIndex = 10;
         this.Label7.Text = "Quantity";
         // 
         // Label12
         // 
         this.Label12.AllowDrop = true;
         this.Label12.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label12.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label12.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label12.Location = new System.Drawing.Point(8, 536);
         this.Label12.Name = "Label12";
         this.Label12.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label12.Size = new System.Drawing.Size(89, 17);
         this.Label12.TabIndex = 32;
         this.Label12.Text = "Freight";
         // 
         // Label11
         // 
         this.Label11.AllowDrop = true;
         this.Label11.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label11.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label11.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label11.Location = new System.Drawing.Point(8, 560);
         this.Label11.Name = "Label11";
         this.Label11.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label11.Size = new System.Drawing.Size(89, 17);
         this.Label11.TabIndex = 30;
         this.Label11.Text = "Total";
         // 
         // Label10
         // 
         this.Label10.AllowDrop = true;
         this.Label10.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label10.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label10.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label10.Location = new System.Drawing.Point(272, 512);
         this.Label10.Name = "Label10";
         this.Label10.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label10.Size = new System.Drawing.Size(89, 17);
         this.Label10.TabIndex = 28;
         this.Label10.Text = "Total Tax";
         // 
         // Label9
         // 
         this.Label9.AllowDrop = true;
         this.Label9.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label9.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label9.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label9.Location = new System.Drawing.Point(272, 536);
         this.Label9.Name = "Label9";
         this.Label9.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label9.Size = new System.Drawing.Size(89, 17);
         this.Label9.TabIndex = 26;
         this.Label9.Text = "Sub Total";
         // 
         // Label8
         // 
         this.Label8.AllowDrop = true;
         this.Label8.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label8.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label8.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label8.Location = new System.Drawing.Point(8, 512);
         this.Label8.Name = "Label8";
         this.Label8.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label8.Size = new System.Drawing.Size(89, 17);
         this.Label8.TabIndex = 25;
         this.Label8.Text = "Sales Tax";
         // 
         // Label6
         // 
         this.Label6.AllowDrop = true;
         this.Label6.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label6.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label6.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label6.Location = new System.Drawing.Point(8, 248);
         this.Label6.Name = "Label6";
         this.Label6.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label6.Size = new System.Drawing.Size(33, 17);
         this.Label6.TabIndex = 22;
         this.Label6.Text = "Notes:";
         // 
         // frmOrderReception
         // 
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.AutoScroll = true;
         this.BackColor = Mobilize.Web.SystemColors.Control;
         this.Properties().ClientSize = new System.Drawing.Size(521, 648);
         this.Controls.Add(this.txtNotes);
         this.Controls.Add(this.txtSubTotal);
         this.Controls.Add(this.txtTotal);
         this.Controls.Add(this.txtTotalTax);
         this.Controls.Add(this.txtFreightCharge);
         this.Controls.Add(this.txtSalesTax);
         this.Controls.Add(this.txtEntry);
         this.Controls.Add(this.fgProducts);
         this.Controls.Add(this.sbStatusBar);
         this.Controls.Add(this.cmdSave);
         this.Controls.Add(this.cmdClose);
         this.Controls.Add(this.cmdAddProducts);
         this.Controls.Add(this.Frame1);
         this.Controls.Add(this.Frame2);
         this.Controls.Add(this.Label7);
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
         this.Name = "frmOrderReception";
         this.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.Manual;
         this.Text = "Add Stock Order";
         this.Closed += new System.EventHandler(this.Form_Closed);
         this.FormClosing += new Mobilize.Web.FormClosingEventHandler(this.Form_FormClosing);this.lvProviders.ItemClick += new Mobilize.Web.ListViewItemClickEventHandler(this.lvProviders_ItemClick);
         this.listViewHelper1.SetCorrectEventsBehavior(this.lvProviders, true);
         this.sbStatusBar.ResumeLayout(false);
         this.Frame1.ResumeLayout(false);
         this.lvProviders.ResumeLayout(false);
         this.Frame2.ResumeLayout(false);
         this.ResumeLayout(false);

#line hidden
this.Controls.DesignTime=false;
#line 858
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
