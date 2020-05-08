#pragma warning disable
#line 1 "frmProviders.Designer.cs"
#pragma warning disable
#line 1 "frmProviders.Designer.cs"
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmProviders
   {

      [Intercepted]

      #region "Upgrade Support "
      private static frmProviders m_vb6FormDefInstance 
#line 13
                                                       { 
#line 13
                                                         get                                                            
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (SKS.frmProviders)catalog.frmProviders.m_vb6FormDefInstance;} 
#line 13

#line 13
                                                              set                                                                 
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmProviders.m_vb6FormDefInstance = value;} 
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
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (bool)catalog.frmProviders.m_InitializingDefInstance;} 
#line 16

#line 16
                                                           set                                                              
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmProviders.m_InitializingDefInstance = value;} 
#line 16
                                                                }

#line 17

      [Intercepted]
      public static frmProviders DefInstance
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

      public static frmProviders CreateInstance()
      {
      	frmProviders theInstance = new frmProviders();
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
private Mobilize.Web.VBUC.ADODataControlHelper dcProviders_k__BackingField;
#line 59


      [Intercepted]
      public Mobilize.Web.VBUC.ADODataControlHelper dcProviders 
#line 59
                                                                { 
#line 59
                                                                  get                                                                     
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_dcProviders)<=0){this.dcProviders_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.VBUC.ADODataControlHelper>(this,_Mobilize_References,3);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_dcProviders;;} return this.dcProviders_k__BackingField; } 
#line 59

#line 59
                                                                       set                                                                          
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.VBUC.ADODataControlHelper>(this,_Mobilize_References,3,this.dcProviders_k__BackingField,(Mobilize.Web.VBUC.ADODataControlHelper)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_dcProviders;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_dcProviders;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.dcProviders_k__BackingField=(Mobilize.Web.VBUC.ADODataControlHelper)value;} 
#line 59
                                                                            }

#line 60

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox _txtField_1_k__BackingField;
#line 62


      [Intercepted]
      private Mobilize.Web.TextBox _txtField_1 
#line 62
                                               { 
#line 62
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__txtField_1)<=0){this._txtField_1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,4);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_1;;} return this._txtField_1_k__BackingField; } 
#line 62

#line 62
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,4,this._txtField_1_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__txtField_1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._txtField_1_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 62
                                                           }

#line 63

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox _txtField_4_k__BackingField;
#line 65


      [Intercepted]
      private Mobilize.Web.TextBox _txtField_4 
#line 65
                                               { 
#line 65
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__txtField_4)<=0){this._txtField_4_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,5);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_4;;} return this._txtField_4_k__BackingField; } 
#line 65

#line 65
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,5,this._txtField_4_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__txtField_4;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_4;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._txtField_4_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 65
                                                           }

#line 66

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox _txtField_0_k__BackingField;
#line 68


      [Intercepted]
      private Mobilize.Web.TextBox _txtField_0 
#line 68
                                               { 
#line 68
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__txtField_0)<=0){this._txtField_0_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,6);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_0;;} return this._txtField_0_k__BackingField; } 
#line 68

#line 68
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,6,this._txtField_0_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__txtField_0;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_0;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._txtField_0_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 68
                                                           }

#line 69

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox _txtField_6_k__BackingField;
#line 71


      [Intercepted]
      private Mobilize.Web.TextBox _txtField_6 
#line 71
                                               { 
#line 71
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__txtField_6)<=0){this._txtField_6_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,7);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_6;;} return this._txtField_6_k__BackingField; } 
#line 71

#line 71
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,7,this._txtField_6_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__txtField_6;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_6;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._txtField_6_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 71
                                                           }

#line 72

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox _txtField_7_k__BackingField;
#line 74


      [Intercepted]
      private Mobilize.Web.TextBox _txtField_7 
#line 74
                                               { 
#line 74
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__txtField_7)<=0){this._txtField_7_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,8);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_7;;} return this._txtField_7_k__BackingField; } 
#line 74

#line 74
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,8,this._txtField_7_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__txtField_7;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_7;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._txtField_7_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 74
                                                           }

#line 75

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox _txtField_2_k__BackingField;
#line 77


      [Intercepted]
      private Mobilize.Web.TextBox _txtField_2 
#line 77
                                               { 
#line 77
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__txtField_2)<=0){this._txtField_2_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,9);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_2;;} return this._txtField_2_k__BackingField; } 
#line 77

#line 77
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,9,this._txtField_2_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__txtField_2;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_2;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._txtField_2_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 77
                                                           }

#line 78

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox _txtField_5_k__BackingField;
#line 80


      [Intercepted]
      private Mobilize.Web.TextBox _txtField_5 
#line 80
                                               { 
#line 80
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__txtField_5)<=0){this._txtField_5_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,10);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_5;;} return this._txtField_5_k__BackingField; } 
#line 80

#line 80
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,10,this._txtField_5_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__txtField_5;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_5;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._txtField_5_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 80
                                                           }

#line 81

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox _txtField_11_k__BackingField;
#line 83


      [Intercepted]
      private Mobilize.Web.TextBox _txtField_11 
#line 83
                                                { 
#line 83
                                                  get                                                     
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__txtField_11)<=0){this._txtField_11_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,11);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_11;;} return this._txtField_11_k__BackingField; } 
#line 83

#line 83
                                                       set                                                          
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,11,this._txtField_11_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__txtField_11;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_11;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._txtField_11_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 83
                                                            }

#line 84

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox _txtField_13_k__BackingField;
#line 86


      [Intercepted]
      private Mobilize.Web.TextBox _txtField_13 
#line 86
                                                { 
#line 86
                                                  get                                                     
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__txtField_13)<=0){this._txtField_13_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,12);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_13;;} return this._txtField_13_k__BackingField; } 
#line 86

#line 86
                                                       set                                                          
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,12,this._txtField_13_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__txtField_13;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_13;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._txtField_13_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 86
                                                            }

#line 87

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox _txtField_12_k__BackingField;
#line 89


      [Intercepted]
      private Mobilize.Web.TextBox _txtField_12 
#line 89
                                                { 
#line 89
                                                  get                                                     
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__txtField_12)<=0){this._txtField_12_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,13);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_12;;} return this._txtField_12_k__BackingField; } 
#line 89

#line 89
                                                       set                                                          
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,13,this._txtField_12_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__txtField_12;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_12;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._txtField_12_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 89
                                                            }

#line 90

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label7_k__BackingField;
#line 92


      [Intercepted]
      public Mobilize.Web.Label Label7 
#line 92
                                       { 
#line 92
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label7)<=0){this.Label7_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,14);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label7;;} return this.Label7_k__BackingField; } 
#line 92

#line 92
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,14,this.Label7_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label7;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label7;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label7_k__BackingField=(Mobilize.Web.Label)value;} 
#line 92
                                                   }

#line 93

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label3_k__BackingField;
#line 95


      [Intercepted]
      public Mobilize.Web.Label Label3 
#line 95
                                       { 
#line 95
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label3)<=0){this.Label3_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,15);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label3;;} return this.Label3_k__BackingField; } 
#line 95

#line 95
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,15,this.Label3_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label3;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label3;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label3_k__BackingField=(Mobilize.Web.Label)value;} 
#line 95
                                                   }

#line 96

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label2_k__BackingField;
#line 98


      [Intercepted]
      public Mobilize.Web.Label Label2 
#line 98
                                       { 
#line 98
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label2)<=0){this.Label2_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,16);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label2;;} return this.Label2_k__BackingField; } 
#line 98

#line 98
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,16,this.Label2_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label2;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label2;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label2_k__BackingField=(Mobilize.Web.Label)value;} 
#line 98
                                                   }

#line 99

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.GroupBox Frame2_k__BackingField;
#line 101


      [Intercepted]
      public Mobilize.Web.GroupBox Frame2 
#line 101
                                          { 
#line 101
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Frame2)<=0){this.Frame2_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.GroupBox>(this,_Mobilize_References,17);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Frame2;;} return this.Frame2_k__BackingField; } 
#line 101

#line 101
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.GroupBox>(this,_Mobilize_References,17,this.Frame2_k__BackingField,(Mobilize.Web.GroupBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Frame2;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Frame2;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Frame2_k__BackingField=(Mobilize.Web.GroupBox)value;} 
#line 101
                                                      }

#line 102

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox _txtField_8_k__BackingField;
#line 104


      [Intercepted]
      private Mobilize.Web.TextBox _txtField_8 
#line 104
                                               { 
#line 104
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__txtField_8)<=0){this._txtField_8_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,18);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_8;;} return this._txtField_8_k__BackingField; } 
#line 104

#line 104
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,18,this._txtField_8_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__txtField_8;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_8;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._txtField_8_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 104
                                                           }

#line 105

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox _txtField_10_k__BackingField;
#line 107


      [Intercepted]
      private Mobilize.Web.TextBox _txtField_10 
#line 107
                                                { 
#line 107
                                                  get                                                     
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__txtField_10)<=0){this._txtField_10_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,19);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_10;;} return this._txtField_10_k__BackingField; } 
#line 107

#line 107
                                                       set                                                          
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,19,this._txtField_10_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__txtField_10;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_10;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._txtField_10_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 107
                                                            }

#line 108

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox _txtField_14_k__BackingField;
#line 110


      [Intercepted]
      private Mobilize.Web.TextBox _txtField_14 
#line 110
                                                { 
#line 110
                                                  get                                                     
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__txtField_14)<=0){this._txtField_14_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,20);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_14;;} return this._txtField_14_k__BackingField; } 
#line 110

#line 110
                                                       set                                                          
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,20,this._txtField_14_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__txtField_14;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_14;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._txtField_14_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 110
                                                            }

#line 111

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox _txtField_9_k__BackingField;
#line 113


      [Intercepted]
      private Mobilize.Web.TextBox _txtField_9 
#line 113
                                               { 
#line 113
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__txtField_9)<=0){this._txtField_9_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,21);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_9;;} return this._txtField_9_k__BackingField; } 
#line 113

#line 113
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,21,this._txtField_9_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__txtField_9;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_9;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._txtField_9_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 113
                                                           }

#line 114

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label4_k__BackingField;
#line 116


      [Intercepted]
      public Mobilize.Web.Label Label4 
#line 116
                                       { 
#line 116
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label4)<=0){this.Label4_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,22);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label4;;} return this.Label4_k__BackingField; } 
#line 116

#line 116
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,22,this.Label4_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label4;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label4;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label4_k__BackingField=(Mobilize.Web.Label)value;} 
#line 116
                                                   }

#line 117

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label15_k__BackingField;
#line 119


      [Intercepted]
      public Mobilize.Web.Label Label15 
#line 119
                                        { 
#line 119
                                          get                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label15)<=0){this.Label15_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,23);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label15;;} return this.Label15_k__BackingField; } 
#line 119

#line 119
                                               set                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,23,this.Label15_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label15;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label15;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label15_k__BackingField=(Mobilize.Web.Label)value;} 
#line 119
                                                    }

#line 120

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label14_k__BackingField;
#line 122


      [Intercepted]
      public Mobilize.Web.Label Label14 
#line 122
                                        { 
#line 122
                                          get                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label14)<=0){this.Label14_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,24);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label14;;} return this.Label14_k__BackingField; } 
#line 122

#line 122
                                               set                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,24,this.Label14_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label14;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label14;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label14_k__BackingField=(Mobilize.Web.Label)value;} 
#line 122
                                                    }

#line 123

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label13_k__BackingField;
#line 125


      [Intercepted]
      public Mobilize.Web.Label Label13 
#line 125
                                        { 
#line 125
                                          get                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label13)<=0){this.Label13_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,25);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label13;;} return this.Label13_k__BackingField; } 
#line 125

#line 125
                                               set                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,25,this.Label13_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label13;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label13;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label13_k__BackingField=(Mobilize.Web.Label)value;} 
#line 125
                                                    }

#line 126

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label12_k__BackingField;
#line 128


      [Intercepted]
      public Mobilize.Web.Label Label12 
#line 128
                                        { 
#line 128
                                          get                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label12)<=0){this.Label12_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,26);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label12;;} return this.Label12_k__BackingField; } 
#line 128

#line 128
                                               set                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,26,this.Label12_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label12;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label12;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label12_k__BackingField=(Mobilize.Web.Label)value;} 
#line 128
                                                    }

#line 129

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label11_k__BackingField;
#line 131


      [Intercepted]
      public Mobilize.Web.Label Label11 
#line 131
                                        { 
#line 131
                                          get                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label11)<=0){this.Label11_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,27);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label11;;} return this.Label11_k__BackingField; } 
#line 131

#line 131
                                               set                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,27,this.Label11_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label11;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label11;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label11_k__BackingField=(Mobilize.Web.Label)value;} 
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
private Mobilize.Web.Label Label6_k__BackingField;
#line 143


      [Intercepted]
      public Mobilize.Web.Label Label6 
#line 143
                                       { 
#line 143
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label6)<=0){this.Label6_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,31);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label6;;} return this.Label6_k__BackingField; } 
#line 143

#line 143
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,31,this.Label6_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label6;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label6;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label6_k__BackingField=(Mobilize.Web.Label)value;} 
#line 143
                                                   }

#line 144

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label1_k__BackingField;
#line 146


      [Intercepted]
      public Mobilize.Web.Label Label1 
#line 146
                                       { 
#line 146
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label1)<=0){this.Label1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,32);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label1;;} return this.Label1_k__BackingField; } 
#line 146

#line 146
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,32,this.Label1_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label1;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label1_k__BackingField=(Mobilize.Web.Label)value;} 
#line 146
                                                   }

#line 147

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.GroupBox Frame1_k__BackingField;
#line 149


      [Intercepted]
      public Mobilize.Web.GroupBox Frame1 
#line 149
                                          { 
#line 149
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Frame1)<=0){this.Frame1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.GroupBox>(this,_Mobilize_References,33);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Frame1;;} return this.Frame1_k__BackingField; } 
#line 149

#line 149
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.GroupBox>(this,_Mobilize_References,33,this.Frame1_k__BackingField,(Mobilize.Web.GroupBox)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Frame1;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Frame1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Frame1_k__BackingField=(Mobilize.Web.GroupBox)value;} 
#line 149
                                                      }

#line 150

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ImageList ImageList1_k__BackingField;
#line 152


      [Intercepted]
      public Mobilize.Web.ImageList ImageList1 
#line 152
                                               { 
#line 152
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_ImageList1)<=0){this.ImageList1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ImageList>(this,_Mobilize_References,34);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_ImageList1;;} return this.ImageList1_k__BackingField; } 
#line 152

#line 152
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ImageList>(this,_Mobilize_References,34,this.ImageList1_k__BackingField,(Mobilize.Web.ImageList)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_ImageList1;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_ImageList1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.ImageList1_k__BackingField=(Mobilize.Web.ImageList)value;} 
#line 152
                                                           }

#line 153

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button1_k__BackingField;
#line 155


      [Intercepted]
      public Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button1 
#line 155
                                                                   { 
#line 155
                                                                     get                                                                        
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Toolbar1_Buttons_Button1)<=0){this.Toolbar1_Buttons_Button1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripButton>(this,_Mobilize_References,35);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Toolbar1_Buttons_Button1;;} return this.Toolbar1_Buttons_Button1_k__BackingField; } 
#line 155

#line 155
                                                                          set                                                                             
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripButton>(this,_Mobilize_References,35,this.Toolbar1_Buttons_Button1_k__BackingField,(Mobilize.Web.ToolStripButton)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Toolbar1_Buttons_Button1;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Toolbar1_Buttons_Button1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Toolbar1_Buttons_Button1_k__BackingField=(Mobilize.Web.ToolStripButton)value;} 
#line 155
                                                                               }

#line 156

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button2_k__BackingField;
#line 158


      [Intercepted]
      public Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button2 
#line 158
                                                                   { 
#line 158
                                                                     get                                                                        
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Toolbar1_Buttons_Button2)<=0){this.Toolbar1_Buttons_Button2_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripButton>(this,_Mobilize_References,36);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Toolbar1_Buttons_Button2;;} return this.Toolbar1_Buttons_Button2_k__BackingField; } 
#line 158

#line 158
                                                                          set                                                                             
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripButton>(this,_Mobilize_References,36,this.Toolbar1_Buttons_Button2_k__BackingField,(Mobilize.Web.ToolStripButton)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Toolbar1_Buttons_Button2;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Toolbar1_Buttons_Button2;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Toolbar1_Buttons_Button2_k__BackingField=(Mobilize.Web.ToolStripButton)value;} 
#line 158
                                                                               }

#line 159

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button3_k__BackingField;
#line 161


      [Intercepted]
      public Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button3 
#line 161
                                                                   { 
#line 161
                                                                     get                                                                        
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Toolbar1_Buttons_Button3)<=0){this.Toolbar1_Buttons_Button3_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripButton>(this,_Mobilize_References,37);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Toolbar1_Buttons_Button3;;} return this.Toolbar1_Buttons_Button3_k__BackingField; } 
#line 161

#line 161
                                                                          set                                                                             
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripButton>(this,_Mobilize_References,37,this.Toolbar1_Buttons_Button3_k__BackingField,(Mobilize.Web.ToolStripButton)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Toolbar1_Buttons_Button3;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Toolbar1_Buttons_Button3;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Toolbar1_Buttons_Button3_k__BackingField=(Mobilize.Web.ToolStripButton)value;} 
#line 161
                                                                               }

#line 162

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button4_k__BackingField;
#line 164


      [Intercepted]
      public Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button4 
#line 164
                                                                   { 
#line 164
                                                                     get                                                                        
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Toolbar1_Buttons_Button4)<=0){this.Toolbar1_Buttons_Button4_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripButton>(this,_Mobilize_References,38);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Toolbar1_Buttons_Button4;;} return this.Toolbar1_Buttons_Button4_k__BackingField; } 
#line 164

#line 164
                                                                          set                                                                             
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripButton>(this,_Mobilize_References,38,this.Toolbar1_Buttons_Button4_k__BackingField,(Mobilize.Web.ToolStripButton)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Toolbar1_Buttons_Button4;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Toolbar1_Buttons_Button4;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Toolbar1_Buttons_Button4_k__BackingField=(Mobilize.Web.ToolStripButton)value;} 
#line 164
                                                                               }

#line 165

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button5_k__BackingField;
#line 167


      [Intercepted]
      public Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button5 
#line 167
                                                                   { 
#line 167
                                                                     get                                                                        
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Toolbar1_Buttons_Button5)<=0){this.Toolbar1_Buttons_Button5_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripButton>(this,_Mobilize_References,39);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Toolbar1_Buttons_Button5;;} return this.Toolbar1_Buttons_Button5_k__BackingField; } 
#line 167

#line 167
                                                                          set                                                                             
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripButton>(this,_Mobilize_References,39,this.Toolbar1_Buttons_Button5_k__BackingField,(Mobilize.Web.ToolStripButton)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Toolbar1_Buttons_Button5;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Toolbar1_Buttons_Button5;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Toolbar1_Buttons_Button5_k__BackingField=(Mobilize.Web.ToolStripButton)value;} 
#line 167
                                                                               }

#line 168

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button6_k__BackingField;
#line 170


      [Intercepted]
      public Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button6 
#line 170
                                                                   { 
#line 170
                                                                     get                                                                        
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Toolbar1_Buttons_Button6)<=0){this.Toolbar1_Buttons_Button6_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripButton>(this,_Mobilize_References,40);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Toolbar1_Buttons_Button6;;} return this.Toolbar1_Buttons_Button6_k__BackingField; } 
#line 170

#line 170
                                                                          set                                                                             
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripButton>(this,_Mobilize_References,40,this.Toolbar1_Buttons_Button6_k__BackingField,(Mobilize.Web.ToolStripButton)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Toolbar1_Buttons_Button6;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Toolbar1_Buttons_Button6;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Toolbar1_Buttons_Button6_k__BackingField=(Mobilize.Web.ToolStripButton)value;} 
#line 170
                                                                               }

#line 171

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStrip Toolbar1_k__BackingField;
#line 173


      [Intercepted]
      public Mobilize.Web.ToolStrip Toolbar1 
#line 173
                                             { 
#line 173
                                               get                                                  
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Toolbar1)<=0){this.Toolbar1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStrip>(this,_Mobilize_References,41);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Toolbar1;;} return this.Toolbar1_k__BackingField; } 
#line 173

#line 173
                                                    set                                                       
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStrip>(this,_Mobilize_References,41,this.Toolbar1_k__BackingField,(Mobilize.Web.ToolStrip)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Toolbar1;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Toolbar1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Toolbar1_k__BackingField=(Mobilize.Web.ToolStrip)value;} 
#line 173
                                                         }

#line 174

#line hidden
                                                           
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox[] txtField_k__BackingField;
#line 176
                                                           

      [Intercepted]
      public Mobilize.Web.TextBox[] txtField 
#line 176
                                             { 
#line 176
                                               get                                                  
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_txtField)<=0){this.txtField_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<Mobilize.Web.TextBox[]>(this,_Mobilize_References,42);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_txtField;}return this.txtField_k__BackingField;} 
#line 176

#line 176
                                                    set                                                       
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Mobilize.Web.TextBox[] >(this,_Mobilize_References,42,this.txtField_k__BackingField,(Mobilize.Web.TextBox[])value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_txtField;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_txtField;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtField_k__BackingField=(Mobilize.Web.TextBox[])value;} 
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
      	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProviders));
      	this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
      	this.dcProviders = new Mobilize.Web.VBUC.ADODataControlHelper();
      	this.Frame1 = new Mobilize.Web.GroupBox();
      	this._txtField_1 = new Mobilize.Web.TextBox();
      	this._txtField_4 = new Mobilize.Web.TextBox();
      	this._txtField_0 = new Mobilize.Web.TextBox();
      	this._txtField_6 = new Mobilize.Web.TextBox();
      	this._txtField_7 = new Mobilize.Web.TextBox();
      	this._txtField_2 = new Mobilize.Web.TextBox();
      	this._txtField_5 = new Mobilize.Web.TextBox();
      	this.Frame2 = new Mobilize.Web.GroupBox();
      	this._txtField_11 = new Mobilize.Web.TextBox();
      	this._txtField_13 = new Mobilize.Web.TextBox();
      	this._txtField_12 = new Mobilize.Web.TextBox();
      	this.Label7 = new Mobilize.Web.Label();
      	this.Label3 = new Mobilize.Web.Label();
      	this.Label2 = new Mobilize.Web.Label();
      	this._txtField_8 = new Mobilize.Web.TextBox();
      	this._txtField_10 = new Mobilize.Web.TextBox();
      	this._txtField_14 = new Mobilize.Web.TextBox();
      	this._txtField_9 = new Mobilize.Web.TextBox();
      	this.Label4 = new Mobilize.Web.Label();
      	this.Label15 = new Mobilize.Web.Label();
      	this.Label14 = new Mobilize.Web.Label();
      	this.Label13 = new Mobilize.Web.Label();
      	this.Label12 = new Mobilize.Web.Label();
      	this.Label11 = new Mobilize.Web.Label();
      	this.Label10 = new Mobilize.Web.Label();
      	this.Label9 = new Mobilize.Web.Label();
      	this.Label8 = new Mobilize.Web.Label();
      	this.Label6 = new Mobilize.Web.Label();
      	this.Label1 = new Mobilize.Web.Label();
      	this.ImageList1 = new Mobilize.Web.ImageList();
      	this.Toolbar1 = new Mobilize.Web.ToolStrip();
      	this.Toolbar1_Buttons_Button1 = new Mobilize.Web.ToolStripButton();
      	this.Toolbar1_Buttons_Button2 = new Mobilize.Web.ToolStripButton();
      	this.Toolbar1_Buttons_Button3 = new Mobilize.Web.ToolStripButton();
      	this.Toolbar1_Buttons_Button4 = new Mobilize.Web.ToolStripButton();
      	this.Toolbar1_Buttons_Button5 = new Mobilize.Web.ToolStripButton();
      	this.Toolbar1_Buttons_Button6 = new Mobilize.Web.ToolStripButton();
      	this.Frame1.SuspendLayout();
      	this.Frame2.SuspendLayout();
      	this.Toolbar1.SuspendLayout();
      	this.SuspendLayout();
      	// 
      	// dcProviders
      	// 
      	this.dcProviders.AllowDrop = true;
      	this.dcProviders.Properties().BackColor = Mobilize.Web.SystemColors.Window;
         this.dcProviders.Properties().BOFAction = Stub._UpgradeHelpers.DB.Controls.BOFActionEnum.MoveFirst;
         this.dcProviders.ConnectionString = "Driver=SQLite3 ODBC Driver; Database=Orders.db;";
         this.dcProviders.CursorLocation = UpgradeHelpers.DB.ADO.CursorLocationEnum.adUseClient;
         this.dcProviders.Enabled = true;
         this.dcProviders.Properties().EOFAction = Stub._UpgradeHelpers.DB.Controls.EOFActionEnum.MoveLast;
         this.dcProviders.FactoryName = "Access";
         this.dcProviders.Properties().Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.dcProviders.Properties().ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.dcProviders.Location = new System.Drawing.Point(8, 408);
         this.dcProviders.LockType = UpgradeHelpers.DB.LockTypeEnum.LockOptimistic;
         this.dcProviders.Name = "dcProviders";
         this.dcProviders.Password = "";
         this.dcProviders.QueryTimeout = 30;
         this.dcProviders.QueryType = System.Data.CommandType.Text;
         this.dcProviders.RecordSource = "Select * from Providers";
         this.dcProviders.Text = "Suppliers";
         this.dcProviders.UserName = "";
         this.dcProviders.Width = 177;
         // 
         // Frame1
         // 
         this.Frame1.AllowDrop = true;
         this.Frame1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Frame1.Controls.Add(this._txtField_1);
         this.Frame1.Controls.Add(this._txtField_4);
         this.Frame1.Controls.Add(this._txtField_0);
         this.Frame1.Controls.Add(this._txtField_6);
         this.Frame1.Controls.Add(this._txtField_7);
         this.Frame1.Controls.Add(this._txtField_2);
         this.Frame1.Controls.Add(this._txtField_5);
         this.Frame1.Controls.Add(this.Frame2);
         this.Frame1.Controls.Add(this._txtField_8);
         this.Frame1.Controls.Add(this._txtField_10);
         this.Frame1.Controls.Add(this._txtField_14);
         this.Frame1.Controls.Add(this._txtField_9);
         this.Frame1.Controls.Add(this.Label4);
         this.Frame1.Controls.Add(this.Label15);
         this.Frame1.Controls.Add(this.Label14);
         this.Frame1.Controls.Add(this.Label13);
         this.Frame1.Controls.Add(this.Label12);
         this.Frame1.Controls.Add(this.Label11);
         this.Frame1.Controls.Add(this.Label10);
         this.Frame1.Controls.Add(this.Label9);
         this.Frame1.Controls.Add(this.Label8);
         this.Frame1.Controls.Add(this.Label6);
         this.Frame1.Controls.Add(this.Label1);
         this.Frame1.Enabled = true;
         this.Frame1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Frame1.Location = new System.Drawing.Point(8, 48);
         this.Frame1.Name = "Frame1";
         this.Frame1.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Frame1.Size = new System.Drawing.Size(433, 353);
         this.Frame1.TabIndex = 14;
         this.Frame1.Text = "Supplier information";
         this.Frame1.Visible = true;
         // 
         // _txtField_1
         // 
         this._txtField_1.AcceptsReturn = true;
         this._txtField_1.AllowDrop = true;
         this._txtField_1.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_1.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_1.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this._txtField_1.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_1.Location = new System.Drawing.Point(16, 288);
         this._txtField_1.MaxLength = 0;
         this._txtField_1.Multiline = true;
         this._txtField_1.Name = "_txtField_1";
         this._txtField_1.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtField_1.Size = new System.Drawing.Size(401, 52);
         this._txtField_1.TabIndex = 29;
         this._txtField_1.TextChanged += new System.EventHandler(this.txtField_TextChanged);
         // 
         // _txtField_4
         // 
         this._txtField_4.AcceptsReturn = true;
         this._txtField_4.AllowDrop = true;
         this._txtField_4.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_4.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_4.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this._txtField_4.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_4.Location = new System.Drawing.Point(104, 83);
         this._txtField_4.MaxLength = 0;
         this._txtField_4.Name = "_txtField_4";
         this._txtField_4.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtField_4.Size = new System.Drawing.Size(105, 20);
         this._txtField_4.TabIndex = 5;
         this._txtField_4.TextChanged += new System.EventHandler(this.txtField_TextChanged);
         // 
         // _txtField_0
         // 
         this._txtField_0.AcceptsReturn = true;
         this._txtField_0.AllowDrop = true;
         this._txtField_0.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_0.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_0.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this._txtField_0.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_0.Location = new System.Drawing.Point(104, 24);
         this._txtField_0.MaxLength = 0;
         this._txtField_0.Name = "_txtField_0";
         this._txtField_0.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtField_0.Size = new System.Drawing.Size(105, 20);
         this._txtField_0.TabIndex = 0;
         this._txtField_0.TextChanged += new System.EventHandler(this.txtField_TextChanged);
         // 
         // _txtField_6
         // 
         this._txtField_6.AcceptsReturn = true;
         this._txtField_6.AllowDrop = true;
         this._txtField_6.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_6.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_6.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this._txtField_6.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_6.Location = new System.Drawing.Point(104, 145);
         this._txtField_6.MaxLength = 0;
         this._txtField_6.Name = "_txtField_6";
         this._txtField_6.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtField_6.Size = new System.Drawing.Size(105, 20);
         this._txtField_6.TabIndex = 7;
         this._txtField_6.TextChanged += new System.EventHandler(this.txtField_TextChanged);
         // 
         // _txtField_7
         // 
         this._txtField_7.AcceptsReturn = true;
         this._txtField_7.AllowDrop = true;
         this._txtField_7.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_7.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_7.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this._txtField_7.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_7.Location = new System.Drawing.Point(104, 176);
         this._txtField_7.MaxLength = 0;
         this._txtField_7.Name = "_txtField_7";
         this._txtField_7.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtField_7.Size = new System.Drawing.Size(105, 20);
         this._txtField_7.TabIndex = 8;
         this._txtField_7.TextChanged += new System.EventHandler(this.txtField_TextChanged);
         // 
         // _txtField_2
         // 
         this._txtField_2.AcceptsReturn = true;
         this._txtField_2.AllowDrop = true;
         this._txtField_2.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_2.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_2.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this._txtField_2.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_2.Location = new System.Drawing.Point(104, 54);
         this._txtField_2.MaxLength = 0;
         this._txtField_2.Name = "_txtField_2";
         this._txtField_2.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtField_2.Size = new System.Drawing.Size(105, 20);
         this._txtField_2.TabIndex = 1;
         this._txtField_2.TextChanged += new System.EventHandler(this.txtField_TextChanged);
         // 
         // _txtField_5
         // 
         this._txtField_5.AcceptsReturn = true;
         this._txtField_5.AllowDrop = true;
         this._txtField_5.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_5.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_5.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this._txtField_5.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_5.Location = new System.Drawing.Point(104, 114);
         this._txtField_5.MaxLength = 0;
         this._txtField_5.Name = "_txtField_5";
         this._txtField_5.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtField_5.Size = new System.Drawing.Size(105, 20);
         this._txtField_5.TabIndex = 6;
         this._txtField_5.TextChanged += new System.EventHandler(this.txtField_TextChanged);
         // 
         // Frame2
         // 
         this.Frame2.AllowDrop = true;
         this.Frame2.BackColor = Mobilize.Web.SystemColors.Control;
         this.Frame2.Controls.Add(this._txtField_11);
         this.Frame2.Controls.Add(this._txtField_13);
         this.Frame2.Controls.Add(this._txtField_12);
         this.Frame2.Controls.Add(this.Label7);
         this.Frame2.Controls.Add(this.Label3);
         this.Frame2.Controls.Add(this.Label2);
         this.Frame2.Enabled = true;
         this.Frame2.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Frame2.Location = new System.Drawing.Point(224, 14);
         this.Frame2.Name = "Frame2";
         this.Frame2.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Frame2.Size = new System.Drawing.Size(194, 97);
         this.Frame2.TabIndex = 24;
         this.Frame2.Text = "Contact";
         this.Frame2.Visible = true;
         // 
         // _txtField_11
         // 
         this._txtField_11.AcceptsReturn = true;
         this._txtField_11.AllowDrop = true;
         this._txtField_11.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_11.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_11.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this._txtField_11.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_11.Location = new System.Drawing.Point(64, 16);
         this._txtField_11.MaxLength = 0;
         this._txtField_11.Name = "_txtField_11";
         this._txtField_11.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtField_11.Size = new System.Drawing.Size(121, 20);
         this._txtField_11.TabIndex = 2;
         this._txtField_11.TextChanged += new System.EventHandler(this.txtField_TextChanged);
         // 
         // _txtField_13
         // 
         this._txtField_13.AcceptsReturn = true;
         this._txtField_13.AllowDrop = true;
         this._txtField_13.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_13.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_13.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this._txtField_13.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_13.Location = new System.Drawing.Point(64, 64);
         this._txtField_13.MaxLength = 0;
         this._txtField_13.Name = "_txtField_13";
         this._txtField_13.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtField_13.Size = new System.Drawing.Size(121, 20);
         this._txtField_13.TabIndex = 4;
         this._txtField_13.TextChanged += new System.EventHandler(this.txtField_TextChanged);
         // 
         // _txtField_12
         // 
         this._txtField_12.AcceptsReturn = true;
         this._txtField_12.AllowDrop = true;
         this._txtField_12.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_12.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_12.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this._txtField_12.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_12.Location = new System.Drawing.Point(64, 40);
         this._txtField_12.MaxLength = 0;
         this._txtField_12.Name = "_txtField_12";
         this._txtField_12.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtField_12.Size = new System.Drawing.Size(121, 20);
         this._txtField_12.TabIndex = 3;
         this._txtField_12.TextChanged += new System.EventHandler(this.txtField_TextChanged);
         // 
         // Label7
         // 
         this.Label7.AllowDrop = true;
         this.Label7.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label7.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label7.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label7.Location = new System.Drawing.Point(8, 16);
         this.Label7.Name = "Label7";
         this.Label7.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label7.Size = new System.Drawing.Size(49, 17);
         this.Label7.TabIndex = 27;
         this.Label7.Text = "Title:";
         // 
         // Label3
         // 
         this.Label3.AllowDrop = true;
         this.Label3.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label3.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label3.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label3.Location = new System.Drawing.Point(8, 69);
         this.Label3.Name = "Label3";
         this.Label3.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label3.Size = new System.Drawing.Size(57, 17);
         this.Label3.TabIndex = 26;
         this.Label3.Text = "Last name:";
         // 
         // Label2
         // 
         this.Label2.AllowDrop = true;
         this.Label2.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label2.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label2.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label2.Location = new System.Drawing.Point(8, 43);
         this.Label2.Name = "Label2";
         this.Label2.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label2.Size = new System.Drawing.Size(57, 17);
         this.Label2.TabIndex = 25;
         this.Label2.Text = "First name:";
         // 
         // _txtField_8
         // 
         this._txtField_8.AcceptsReturn = true;
         this._txtField_8.AllowDrop = true;
         this._txtField_8.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_8.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_8.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this._txtField_8.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_8.Location = new System.Drawing.Point(312, 115);
         this._txtField_8.MaxLength = 0;
         this._txtField_8.Name = "_txtField_8";
         this._txtField_8.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtField_8.Size = new System.Drawing.Size(105, 20);
         this._txtField_8.TabIndex = 9;
         this._txtField_8.TextChanged += new System.EventHandler(this.txtField_TextChanged);
         // 
         // _txtField_10
         // 
         this._txtField_10.AcceptsReturn = true;
         this._txtField_10.AllowDrop = true;
         this._txtField_10.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_10.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_10.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this._txtField_10.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_10.Location = new System.Drawing.Point(312, 176);
         this._txtField_10.MaxLength = 0;
         this._txtField_10.Name = "_txtField_10";
         this._txtField_10.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtField_10.Size = new System.Drawing.Size(105, 20);
         this._txtField_10.TabIndex = 11;
         this._txtField_10.TextChanged += new System.EventHandler(this.txtField_TextChanged);
         // 
         // _txtField_14
         // 
         this._txtField_14.AcceptsReturn = true;
         this._txtField_14.AllowDrop = true;
         this._txtField_14.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_14.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_14.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this._txtField_14.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_14.Location = new System.Drawing.Point(16, 216);
         this._txtField_14.MaxLength = 0;
         this._txtField_14.Multiline = true;
         this._txtField_14.Name = "_txtField_14";
         this._txtField_14.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtField_14.Size = new System.Drawing.Size(401, 52);
         this._txtField_14.TabIndex = 12;
         this._txtField_14.TextChanged += new System.EventHandler(this.txtField_TextChanged);
         // 
         // _txtField_9
         // 
         this._txtField_9.AcceptsReturn = true;
         this._txtField_9.AllowDrop = true;
         this._txtField_9.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_9.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_9.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this._txtField_9.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_9.Location = new System.Drawing.Point(312, 145);
         this._txtField_9.MaxLength = 0;
         this._txtField_9.Name = "_txtField_9";
         this._txtField_9.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtField_9.Size = new System.Drawing.Size(105, 20);
         this._txtField_9.TabIndex = 10;
         this._txtField_9.TextChanged += new System.EventHandler(this.txtField_TextChanged);
         // 
         // Label4
         // 
         this.Label4.AllowDrop = true;
         this.Label4.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label4.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label4.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label4.Location = new System.Drawing.Point(16, 272);
         this.Label4.Name = "Label4";
         this.Label4.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label4.Size = new System.Drawing.Size(89, 17);
         this.Label4.TabIndex = 30;
         this.Label4.Text = "Payment Terms:";
         // 
         // Label15
         // 
         this.Label15.AllowDrop = true;
         this.Label15.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label15.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label15.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label15.Location = new System.Drawing.Point(16, 83);
         this.Label15.Name = "Label15";
         this.Label15.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label15.Size = new System.Drawing.Size(89, 17);
         this.Label15.TabIndex = 28;
         this.Label15.Text = "Zip code:";
         // 
         // Label14
         // 
         this.Label14.AllowDrop = true;
         this.Label14.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label14.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label14.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label14.Location = new System.Drawing.Point(16, 176);
         this.Label14.Name = "Label14";
         this.Label14.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label14.Size = new System.Drawing.Size(89, 17);
         this.Label14.TabIndex = 23;
         this.Label14.Text = "Country";
         // 
         // Label13
         // 
         this.Label13.AllowDrop = true;
         this.Label13.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label13.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label13.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label13.Location = new System.Drawing.Point(16, 145);
         this.Label13.Name = "Label13";
         this.Label13.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label13.Size = new System.Drawing.Size(89, 17);
         this.Label13.TabIndex = 22;
         this.Label13.Text = "State/Prov";
         // 
         // Label12
         // 
         this.Label12.AllowDrop = true;
         this.Label12.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label12.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label12.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label12.Location = new System.Drawing.Point(16, 200);
         this.Label12.Name = "Label12";
         this.Label12.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label12.Size = new System.Drawing.Size(89, 17);
         this.Label12.TabIndex = 21;
         this.Label12.Text = "Notes:";
         // 
         // Label11
         // 
         this.Label11.AllowDrop = true;
         this.Label11.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label11.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label11.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label11.Location = new System.Drawing.Point(16, 54);
         this.Label11.Name = "Label11";
         this.Label11.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label11.Size = new System.Drawing.Size(89, 17);
         this.Label11.TabIndex = 20;
         this.Label11.Text = "Email:";
         // 
         // Label10
         // 
         this.Label10.AllowDrop = true;
         this.Label10.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label10.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label10.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label10.Location = new System.Drawing.Point(232, 176);
         this.Label10.Name = "Label10";
         this.Label10.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label10.Size = new System.Drawing.Size(89, 17);
         this.Label10.TabIndex = 19;
         this.Label10.Text = "Fax";
         // 
         // Label9
         // 
         this.Label9.AllowDrop = true;
         this.Label9.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label9.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label9.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label9.Location = new System.Drawing.Point(232, 145);
         this.Label9.Name = "Label9";
         this.Label9.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label9.Size = new System.Drawing.Size(89, 17);
         this.Label9.TabIndex = 18;
         this.Label9.Text = "Ext";
         // 
         // Label8
         // 
         this.Label8.AllowDrop = true;
         this.Label8.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label8.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label8.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label8.Location = new System.Drawing.Point(232, 115);
         this.Label8.Name = "Label8";
         this.Label8.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label8.Size = new System.Drawing.Size(89, 17);
         this.Label8.TabIndex = 17;
         this.Label8.Text = "Phone";
         // 
         // Label6
         // 
         this.Label6.AllowDrop = true;
         this.Label6.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label6.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label6.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label6.Location = new System.Drawing.Point(16, 114);
         this.Label6.Name = "Label6";
         this.Label6.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label6.Size = new System.Drawing.Size(89, 17);
         this.Label6.TabIndex = 16;
         this.Label6.Text = "City:";
         // 
         // Label1
         // 
         this.Label1.AllowDrop = true;
         this.Label1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label1.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label1.Location = new System.Drawing.Point(16, 24);
         this.Label1.Name = "Label1";
         this.Label1.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label1.Size = new System.Drawing.Size(89, 17);
         this.Label1.TabIndex = 15;
         this.Label1.Text = "Name";
         // 
         // ImageList1
         // 
         this.ImageList1.ImageSize = new System.Drawing.Size(16, 16);
         this.ImageList1.ImageStream = "SKS.frmProviders.ImageList1.ImageStream";
         this.ImageList1.TransparentColor = System.Drawing.Color.White;
         this.ImageList1.Images.SetKeyName(0, "");
         this.ImageList1.Images.SetKeyName(1, "");
         this.ImageList1.Images.SetKeyName(2, "");
         this.ImageList1.Images.SetKeyName(3, "");
         this.ImageList1.Images.SetKeyName(4, "");
         this.ImageList1.Images.SetKeyName(5, "");
         // 
         // Toolbar1
         // 
         this.Toolbar1.AllowDrop = true;
         this.Toolbar1.Dock = Mobilize.Web.DockStyle.Top;
         this.Toolbar1.ImageList = ImageList1;
         this.Toolbar1.Location = new System.Drawing.Point(0, 0);
         this.Toolbar1.Name = "Toolbar1";
         this.Toolbar1.ShowItemToolTips = true;
         this.Toolbar1.Size = new System.Drawing.Size(454, 44);
         this.Toolbar1.TabIndex = 13;
         this.Toolbar1.Items.Add(this.Toolbar1_Buttons_Button1);
         this.Toolbar1.Items.Add(this.Toolbar1_Buttons_Button2);
         this.Toolbar1.Items.Add(this.Toolbar1_Buttons_Button3);
         this.Toolbar1.Items.Add(this.Toolbar1_Buttons_Button4);
         this.Toolbar1.Items.Add(this.Toolbar1_Buttons_Button5);
         this.Toolbar1.Items.Add(this.Toolbar1_Buttons_Button6);
         // 
         // Toolbar1_Buttons_Button1
         // 
         this.Toolbar1_Buttons_Button1.Properties().DisplayStyle = Mobilize.Web.ToolStripItemDisplayStyle.ImageAndText;
         this.Toolbar1_Buttons_Button1.ImageIndex = 0;
         this.Toolbar1_Buttons_Button1.Properties().ImageScaling = Mobilize.Web.ToolStripItemImageScaling.None;
         this.Toolbar1_Buttons_Button1.Properties().Size = new System.Drawing.Size(44, 39);
         this.Toolbar1_Buttons_Button1.Text = "Add";
         this.Toolbar1_Buttons_Button1.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.Toolbar1_Buttons_Button1.Properties().ToolTipText = "Create a new record";
         this.Toolbar1_Buttons_Button1.Click += new System.EventHandler(this.Toolbar1_ButtonClick);
         // 
         // Toolbar1_Buttons_Button2
         // 
         this.Toolbar1_Buttons_Button2.Properties().DisplayStyle = Mobilize.Web.ToolStripItemDisplayStyle.ImageAndText;
         this.Toolbar1_Buttons_Button2.ImageIndex = 1;
         this.Toolbar1_Buttons_Button2.Properties().ImageScaling = Mobilize.Web.ToolStripItemImageScaling.None;
         this.Toolbar1_Buttons_Button2.Properties().Size = new System.Drawing.Size(44, 39);
         this.Toolbar1_Buttons_Button2.Text = "Edit";
         this.Toolbar1_Buttons_Button2.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.Toolbar1_Buttons_Button2.Properties().ToolTipText = "Edit this record";
         this.Toolbar1_Buttons_Button2.Click += new System.EventHandler(this.Toolbar1_ButtonClick);
         // 
         // Toolbar1_Buttons_Button3
         // 
         this.Toolbar1_Buttons_Button3.Properties().DisplayStyle = Mobilize.Web.ToolStripItemDisplayStyle.ImageAndText;
         this.Toolbar1_Buttons_Button3.ImageIndex = 2;
         this.Toolbar1_Buttons_Button3.Properties().ImageScaling = Mobilize.Web.ToolStripItemImageScaling.None;
         this.Toolbar1_Buttons_Button3.Properties().Size = new System.Drawing.Size(44, 39);
         this.Toolbar1_Buttons_Button3.Text = "Save";
         this.Toolbar1_Buttons_Button3.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.Toolbar1_Buttons_Button3.Properties().ToolTipText = "Save the current changes";
         this.Toolbar1_Buttons_Button3.Click += new System.EventHandler(this.Toolbar1_ButtonClick);
         // 
         // Toolbar1_Buttons_Button4
         // 
         this.Toolbar1_Buttons_Button4.Properties().DisplayStyle = Mobilize.Web.ToolStripItemDisplayStyle.ImageAndText;
         this.Toolbar1_Buttons_Button4.ImageIndex = 3;
         this.Toolbar1_Buttons_Button4.Properties().ImageScaling = Mobilize.Web.ToolStripItemImageScaling.None;
         this.Toolbar1_Buttons_Button4.Properties().Size = new System.Drawing.Size(44, 39);
         this.Toolbar1_Buttons_Button4.Text = "Delete";
         this.Toolbar1_Buttons_Button4.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.Toolbar1_Buttons_Button4.Properties().ToolTipText = "Delete the current record";
         this.Toolbar1_Buttons_Button4.Click += new System.EventHandler(this.Toolbar1_ButtonClick);
         // 
         // Toolbar1_Buttons_Button5
         // 
         this.Toolbar1_Buttons_Button5.Properties().DisplayStyle = Mobilize.Web.ToolStripItemDisplayStyle.ImageAndText;
         this.Toolbar1_Buttons_Button5.ImageIndex = 4;
         this.Toolbar1_Buttons_Button5.Properties().ImageScaling = Mobilize.Web.ToolStripItemImageScaling.None;
         this.Toolbar1_Buttons_Button5.Properties().Size = new System.Drawing.Size(44, 39);
         this.Toolbar1_Buttons_Button5.Text = "Search";
         this.Toolbar1_Buttons_Button5.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.Toolbar1_Buttons_Button5.Properties().ToolTipText = "Search for a record";
         this.Toolbar1_Buttons_Button5.Click += new System.EventHandler(this.Toolbar1_ButtonClick);
         // 
         // Toolbar1_Buttons_Button6
         // 
         this.Toolbar1_Buttons_Button6.Properties().DisplayStyle = Mobilize.Web.ToolStripItemDisplayStyle.ImageAndText;
         this.Toolbar1_Buttons_Button6.ImageIndex = 5;
         this.Toolbar1_Buttons_Button6.Properties().ImageScaling = Mobilize.Web.ToolStripItemImageScaling.None;
         this.Toolbar1_Buttons_Button6.Properties().Size = new System.Drawing.Size(44, 39);
         this.Toolbar1_Buttons_Button6.Text = "Cancel";
         this.Toolbar1_Buttons_Button6.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.Toolbar1_Buttons_Button6.Properties().ToolTipText = "Cancel edited changes";
         this.Toolbar1_Buttons_Button6.Click += new System.EventHandler(this.Toolbar1_ButtonClick);
         // 
         // frmProviders
         // 
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = Mobilize.Web.SystemColors.Control;
         this.Properties().ClientSize = new System.Drawing.Size(454, 447);
         this.Controls.Add(this.dcProviders);
         this.Controls.Add(this.Frame1);
         this.Controls.Add(this.Toolbar1);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedSingle;
         this.Properties().Location = new System.Drawing.Point(3, 25);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmProviders";
         this.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Text = "Suppliers";
         this.Closed += new System.EventHandler(this.Form_Closed);
         this.Frame1.ResumeLayout(false);
         this.Frame2.ResumeLayout(false);
         this.Toolbar1.ResumeLayout(false);
         this.ResumeLayout(false);

#line hidden
this.Controls.DesignTime=false;
#line 837
      }

      void ReLoadForm(bool addEvents)
      {
      	InitializetxtField();
      	VB6_AddADODataBinding();
      }

      void InitializetxtField()
      {
      	this.txtField = new Mobilize.Web.TextBox[15];
      	this.txtField[1] = _txtField_1;
      	this.txtField[4] = _txtField_4;
      	this.txtField[0] = _txtField_0;
      	this.txtField[6] = _txtField_6;
      	this.txtField[7] = _txtField_7;
      	this.txtField[2] = _txtField_2;
      	this.txtField[5] = _txtField_5;
      	this.txtField[11] = _txtField_11;
      	this.txtField[13] = _txtField_13;
      	this.txtField[12] = _txtField_12;
      	this.txtField[8] = _txtField_8;
      	this.txtField[10] = _txtField_10;
      	this.txtField[14] = _txtField_14;
      	this.txtField[9] = _txtField_9;
      }
      #endregion
      #region "Upgrade Support"

      public void VB6_AddADODataBinding()
      {
      	dcProviders.Refresh();
      	_txtField_9.DataBindings.Add("Text", dcProviders, "Extension", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
      _txtField_14.DataBindings.Add("Text", dcProviders, "Notes", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
      _txtField_10.DataBindings.Add("Text", dcProviders, "FaxNumber", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
      _txtField_8.DataBindings.Add("Text", dcProviders, "PhoneNumber", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
      _txtField_12.DataBindings.Add("Text", dcProviders, "ContactFirstName", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
      _txtField_13.DataBindings.Add("Text", dcProviders, "ContactLastName", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
      _txtField_11.DataBindings.Add("Text", dcProviders, "ContactTitle", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
      _txtField_5.DataBindings.Add("Text", dcProviders, "City", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
      _txtField_2.DataBindings.Add("Text", dcProviders, "EmailAddress", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
      _txtField_7.DataBindings.Add("Text", dcProviders, "Country/Region", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
      _txtField_6.DataBindings.Add("Text", dcProviders, "StateOrProvince", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
      _txtField_0.DataBindings.Add("Text", dcProviders, "ProviderName", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
      _txtField_4.DataBindings.Add("Text", dcProviders, "PostalCode", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
      _txtField_1.DataBindings.Add("Text", dcProviders, "PaymentTerms", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
   }
   #endregion

   }
}
#pragma warning restore
