#pragma warning disable
#line 1 "frmProducts.Designer.cs"
#pragma warning disable
#line 1 "frmProducts.Designer.cs"
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmProducts
   {

      [Intercepted]

      #region "Upgrade Support "
      private static frmProducts m_vb6FormDefInstance 
#line 13
                                                      { 
#line 13
                                                        get                                                           
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (SKS.frmProducts)catalog.frmProducts.m_vb6FormDefInstance;} 
#line 13

#line 13
                                                             set                                                                
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmProducts.m_vb6FormDefInstance = value;} 
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
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (bool)catalog.frmProducts.m_InitializingDefInstance;} 
#line 16

#line 16
                                                           set                                                              
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmProducts.m_InitializingDefInstance = value;} 
#line 16
                                                                }

#line 17

      [Intercepted]
      public static frmProducts DefInstance
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

      public static frmProducts CreateInstance()
      {
      	frmProducts theInstance = new frmProducts();
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
private Mobilize.Web.TextBox _txtField_6_k__BackingField;
#line 59


      [Intercepted]
      private Mobilize.Web.TextBox _txtField_6 
#line 59
                                               { 
#line 59
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__txtField_6)<=0){this._txtField_6_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,3);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_6;;} return this._txtField_6_k__BackingField; } 
#line 59

#line 59
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,3,this._txtField_6_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__txtField_6;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_6;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._txtField_6_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 59
                                                           }

#line 60

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox _txtField_0_k__BackingField;
#line 62


      [Intercepted]
      private Mobilize.Web.TextBox _txtField_0 
#line 62
                                               { 
#line 62
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__txtField_0)<=0){this._txtField_0_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,4);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_0;;} return this._txtField_0_k__BackingField; } 
#line 62

#line 62
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,4,this._txtField_0_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__txtField_0;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_0;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._txtField_0_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 62
                                                           }

#line 63

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox _txtField_5_k__BackingField;
#line 65


      [Intercepted]
      private Mobilize.Web.TextBox _txtField_5 
#line 65
                                               { 
#line 65
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__txtField_5)<=0){this._txtField_5_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,5);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_5;;} return this._txtField_5_k__BackingField; } 
#line 65

#line 65
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,5,this._txtField_5_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__txtField_5;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_5;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._txtField_5_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 65
                                                           }

#line 66

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ComboBox cmbCategory_k__BackingField;
#line 68


      [Intercepted]
      public Mobilize.Web.ComboBox cmbCategory 
#line 68
                                               { 
#line 68
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmbCategory)<=0){this.cmbCategory_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ComboBox>(this,_Mobilize_References,6);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmbCategory;;} return this.cmbCategory_k__BackingField; } 
#line 68

#line 68
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ComboBox>(this,_Mobilize_References,6,this.cmbCategory_k__BackingField,(Mobilize.Web.ComboBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmbCategory;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmbCategory;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmbCategory_k__BackingField=(Mobilize.Web.ComboBox)value;} 
#line 68
                                                           }

#line 69

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox _txtField_4_k__BackingField;
#line 71


      [Intercepted]
      private Mobilize.Web.TextBox _txtField_4 
#line 71
                                               { 
#line 71
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__txtField_4)<=0){this._txtField_4_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,7);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_4;;} return this._txtField_4_k__BackingField; } 
#line 71

#line 71
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,7,this._txtField_4_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__txtField_4;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_4;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._txtField_4_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 71
                                                           }

#line 72

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox _txtField_3_k__BackingField;
#line 74


      [Intercepted]
      private Mobilize.Web.TextBox _txtField_3 
#line 74
                                               { 
#line 74
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__txtField_3)<=0){this._txtField_3_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,8);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_3;;} return this._txtField_3_k__BackingField; } 
#line 74

#line 74
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,8,this._txtField_3_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__txtField_3;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_3;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._txtField_3_k__BackingField=(Mobilize.Web.TextBox)value;} 
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
private Mobilize.Web.TextBox _txtField_1_k__BackingField;
#line 80


      [Intercepted]
      private Mobilize.Web.TextBox _txtField_1 
#line 80
                                               { 
#line 80
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__txtField_1)<=0){this._txtField_1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,10);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_1;;} return this._txtField_1_k__BackingField; } 
#line 80

#line 80
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,10,this._txtField_1_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__txtField_1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtField_1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._txtField_1_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 80
                                                           }

#line 81

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.CheckBox Check1_k__BackingField;
#line 83


      [Intercepted]
      public Mobilize.Web.CheckBox Check1 
#line 83
                                          { 
#line 83
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Check1)<=0){this.Check1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.CheckBox>(this,_Mobilize_References,11);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Check1;;} return this.Check1_k__BackingField; } 
#line 83

#line 83
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.CheckBox>(this,_Mobilize_References,11,this.Check1_k__BackingField,(Mobilize.Web.CheckBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Check1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Check1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Check1_k__BackingField=(Mobilize.Web.CheckBox)value;} 
#line 83
                                                      }

#line 84

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtCategory_k__BackingField;
#line 86


      [Intercepted]
      public Mobilize.Web.TextBox txtCategory 
#line 86
                                              { 
#line 86
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtCategory)<=0){this.txtCategory_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,12);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtCategory;;} return this.txtCategory_k__BackingField; } 
#line 86

#line 86
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,12,this.txtCategory_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtCategory;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtCategory;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtCategory_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 86
                                                          }

#line 87

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label7_k__BackingField;
#line 89


      [Intercepted]
      public Mobilize.Web.Label Label7 
#line 89
                                       { 
#line 89
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label7)<=0){this.Label7_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,13);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label7;;} return this.Label7_k__BackingField; } 
#line 89

#line 89
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,13,this.Label7_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label7;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label7;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label7_k__BackingField=(Mobilize.Web.Label)value;} 
#line 89
                                                   }

#line 90

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label3_k__BackingField;
#line 92


      [Intercepted]
      public Mobilize.Web.Label Label3 
#line 92
                                       { 
#line 92
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label3)<=0){this.Label3_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,14);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label3;;} return this.Label3_k__BackingField; } 
#line 92

#line 92
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,14,this.Label3_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label3;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label3;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label3_k__BackingField=(Mobilize.Web.Label)value;} 
#line 92
                                                   }

#line 93

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label2_k__BackingField;
#line 95


      [Intercepted]
      public Mobilize.Web.Label Label2 
#line 95
                                       { 
#line 95
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label2)<=0){this.Label2_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,15);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label2;;} return this.Label2_k__BackingField; } 
#line 95

#line 95
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,15,this.Label2_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label2;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label2;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label2_k__BackingField=(Mobilize.Web.Label)value;} 
#line 95
                                                   }

#line 96

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label1_k__BackingField;
#line 98


      [Intercepted]
      public Mobilize.Web.Label Label1 
#line 98
                                       { 
#line 98
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label1)<=0){this.Label1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,16);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label1;;} return this.Label1_k__BackingField; } 
#line 98

#line 98
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,16,this.Label1_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label1_k__BackingField=(Mobilize.Web.Label)value;} 
#line 98
                                                   }

#line 99

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label4_k__BackingField;
#line 101


      [Intercepted]
      public Mobilize.Web.Label Label4 
#line 101
                                       { 
#line 101
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label4)<=0){this.Label4_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,17);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label4;;} return this.Label4_k__BackingField; } 
#line 101

#line 101
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,17,this.Label4_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label4;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label4;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label4_k__BackingField=(Mobilize.Web.Label)value;} 
#line 101
                                                   }

#line 102

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label5_k__BackingField;
#line 104


      [Intercepted]
      public Mobilize.Web.Label Label5 
#line 104
                                       { 
#line 104
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label5)<=0){this.Label5_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,18);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label5;;} return this.Label5_k__BackingField; } 
#line 104

#line 104
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,18,this.Label5_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label5;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label5;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label5_k__BackingField=(Mobilize.Web.Label)value;} 
#line 104
                                                   }

#line 105

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label6_k__BackingField;
#line 107


      [Intercepted]
      public Mobilize.Web.Label Label6 
#line 107
                                       { 
#line 107
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label6)<=0){this.Label6_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,19);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label6;;} return this.Label6_k__BackingField; } 
#line 107

#line 107
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,19,this.Label6_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label6;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label6;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label6_k__BackingField=(Mobilize.Web.Label)value;} 
#line 107
                                                   }

#line 108

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label11_k__BackingField;
#line 110


      [Intercepted]
      public Mobilize.Web.Label Label11 
#line 110
                                        { 
#line 110
                                          get                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label11)<=0){this.Label11_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,20);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label11;;} return this.Label11_k__BackingField; } 
#line 110

#line 110
                                               set                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,20,this.Label11_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label11;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label11;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label11_k__BackingField=(Mobilize.Web.Label)value;} 
#line 110
                                                    }

#line 111

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label15_k__BackingField;
#line 113


      [Intercepted]
      public Mobilize.Web.Label Label15 
#line 113
                                        { 
#line 113
                                          get                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label15)<=0){this.Label15_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,21);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label15;;} return this.Label15_k__BackingField; } 
#line 113

#line 113
                                               set                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,21,this.Label15_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label15;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label15;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label15_k__BackingField=(Mobilize.Web.Label)value;} 
#line 113
                                                    }

#line 114

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.GroupBox Frame1_k__BackingField;
#line 116


      [Intercepted]
      public Mobilize.Web.GroupBox Frame1 
#line 116
                                          { 
#line 116
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Frame1)<=0){this.Frame1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.GroupBox>(this,_Mobilize_References,22);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Frame1;;} return this.Frame1_k__BackingField; } 
#line 116

#line 116
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.GroupBox>(this,_Mobilize_References,22,this.Frame1_k__BackingField,(Mobilize.Web.GroupBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Frame1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Frame1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Frame1_k__BackingField=(Mobilize.Web.GroupBox)value;} 
#line 116
                                                      }

#line 117

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.VBUC.ADODataControlHelper dcProducts_k__BackingField;
#line 119


      [Intercepted]
      public Mobilize.Web.VBUC.ADODataControlHelper dcProducts 
#line 119
                                                               { 
#line 119
                                                                 get                                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_dcProducts)<=0){this.dcProducts_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.VBUC.ADODataControlHelper>(this,_Mobilize_References,23);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_dcProducts;;} return this.dcProducts_k__BackingField; } 
#line 119

#line 119
                                                                      set                                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.VBUC.ADODataControlHelper>(this,_Mobilize_References,23,this.dcProducts_k__BackingField,(Mobilize.Web.VBUC.ADODataControlHelper)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_dcProducts;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_dcProducts;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.dcProducts_k__BackingField=(Mobilize.Web.VBUC.ADODataControlHelper)value;} 
#line 119
                                                                           }

#line 120

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ImageList ImageList1_k__BackingField;
#line 122


      [Intercepted]
      public Mobilize.Web.ImageList ImageList1 
#line 122
                                               { 
#line 122
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_ImageList1)<=0){this.ImageList1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ImageList>(this,_Mobilize_References,24);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_ImageList1;;} return this.ImageList1_k__BackingField; } 
#line 122

#line 122
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ImageList>(this,_Mobilize_References,24,this.ImageList1_k__BackingField,(Mobilize.Web.ImageList)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_ImageList1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_ImageList1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.ImageList1_k__BackingField=(Mobilize.Web.ImageList)value;} 
#line 122
                                                           }

#line 123

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button1_k__BackingField;
#line 125


      [Intercepted]
      public Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button1 
#line 125
                                                                   { 
#line 125
                                                                     get                                                                        
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Toolbar1_Buttons_Button1)<=0){this.Toolbar1_Buttons_Button1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripButton>(this,_Mobilize_References,25);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Toolbar1_Buttons_Button1;;} return this.Toolbar1_Buttons_Button1_k__BackingField; } 
#line 125

#line 125
                                                                          set                                                                             
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripButton>(this,_Mobilize_References,25,this.Toolbar1_Buttons_Button1_k__BackingField,(Mobilize.Web.ToolStripButton)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Toolbar1_Buttons_Button1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Toolbar1_Buttons_Button1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Toolbar1_Buttons_Button1_k__BackingField=(Mobilize.Web.ToolStripButton)value;} 
#line 125
                                                                               }

#line 126

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button2_k__BackingField;
#line 128


      [Intercepted]
      public Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button2 
#line 128
                                                                   { 
#line 128
                                                                     get                                                                        
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Toolbar1_Buttons_Button2)<=0){this.Toolbar1_Buttons_Button2_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripButton>(this,_Mobilize_References,26);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Toolbar1_Buttons_Button2;;} return this.Toolbar1_Buttons_Button2_k__BackingField; } 
#line 128

#line 128
                                                                          set                                                                             
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripButton>(this,_Mobilize_References,26,this.Toolbar1_Buttons_Button2_k__BackingField,(Mobilize.Web.ToolStripButton)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Toolbar1_Buttons_Button2;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Toolbar1_Buttons_Button2;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Toolbar1_Buttons_Button2_k__BackingField=(Mobilize.Web.ToolStripButton)value;} 
#line 128
                                                                               }

#line 129

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button3_k__BackingField;
#line 131


      [Intercepted]
      public Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button3 
#line 131
                                                                   { 
#line 131
                                                                     get                                                                        
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Toolbar1_Buttons_Button3)<=0){this.Toolbar1_Buttons_Button3_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripButton>(this,_Mobilize_References,27);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Toolbar1_Buttons_Button3;;} return this.Toolbar1_Buttons_Button3_k__BackingField; } 
#line 131

#line 131
                                                                          set                                                                             
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripButton>(this,_Mobilize_References,27,this.Toolbar1_Buttons_Button3_k__BackingField,(Mobilize.Web.ToolStripButton)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Toolbar1_Buttons_Button3;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Toolbar1_Buttons_Button3;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Toolbar1_Buttons_Button3_k__BackingField=(Mobilize.Web.ToolStripButton)value;} 
#line 131
                                                                               }

#line 132

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button4_k__BackingField;
#line 134


      [Intercepted]
      public Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button4 
#line 134
                                                                   { 
#line 134
                                                                     get                                                                        
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Toolbar1_Buttons_Button4)<=0){this.Toolbar1_Buttons_Button4_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripButton>(this,_Mobilize_References,28);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Toolbar1_Buttons_Button4;;} return this.Toolbar1_Buttons_Button4_k__BackingField; } 
#line 134

#line 134
                                                                          set                                                                             
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripButton>(this,_Mobilize_References,28,this.Toolbar1_Buttons_Button4_k__BackingField,(Mobilize.Web.ToolStripButton)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Toolbar1_Buttons_Button4;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Toolbar1_Buttons_Button4;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Toolbar1_Buttons_Button4_k__BackingField=(Mobilize.Web.ToolStripButton)value;} 
#line 134
                                                                               }

#line 135

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button5_k__BackingField;
#line 137


      [Intercepted]
      public Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button5 
#line 137
                                                                   { 
#line 137
                                                                     get                                                                        
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Toolbar1_Buttons_Button5)<=0){this.Toolbar1_Buttons_Button5_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripButton>(this,_Mobilize_References,29);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Toolbar1_Buttons_Button5;;} return this.Toolbar1_Buttons_Button5_k__BackingField; } 
#line 137

#line 137
                                                                          set                                                                             
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripButton>(this,_Mobilize_References,29,this.Toolbar1_Buttons_Button5_k__BackingField,(Mobilize.Web.ToolStripButton)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Toolbar1_Buttons_Button5;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Toolbar1_Buttons_Button5;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Toolbar1_Buttons_Button5_k__BackingField=(Mobilize.Web.ToolStripButton)value;} 
#line 137
                                                                               }

#line 138

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button6_k__BackingField;
#line 140


      [Intercepted]
      public Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button6 
#line 140
                                                                   { 
#line 140
                                                                     get                                                                        
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Toolbar1_Buttons_Button6)<=0){this.Toolbar1_Buttons_Button6_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripButton>(this,_Mobilize_References,30);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Toolbar1_Buttons_Button6;;} return this.Toolbar1_Buttons_Button6_k__BackingField; } 
#line 140

#line 140
                                                                          set                                                                             
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripButton>(this,_Mobilize_References,30,this.Toolbar1_Buttons_Button6_k__BackingField,(Mobilize.Web.ToolStripButton)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Toolbar1_Buttons_Button6;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Toolbar1_Buttons_Button6;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Toolbar1_Buttons_Button6_k__BackingField=(Mobilize.Web.ToolStripButton)value;} 
#line 140
                                                                               }

#line 141

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ToolStrip Toolbar1_k__BackingField;
#line 143


      [Intercepted]
      public Mobilize.Web.ToolStrip Toolbar1 
#line 143
                                             { 
#line 143
                                               get                                                  
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Toolbar1)<=0){this.Toolbar1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStrip>(this,_Mobilize_References,31);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Toolbar1;;} return this.Toolbar1_k__BackingField; } 
#line 143

#line 143
                                                    set                                                       
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStrip>(this,_Mobilize_References,31,this.Toolbar1_k__BackingField,(Mobilize.Web.ToolStrip)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Toolbar1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Toolbar1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Toolbar1_k__BackingField=(Mobilize.Web.ToolStrip)value;} 
#line 143
                                                         }

#line 144

#line hidden
                                                           
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox[] txtField_k__BackingField;
#line 146
                                                           

      [Intercepted]
      public Mobilize.Web.TextBox[] txtField 
#line 146
                                             { 
#line 146
                                               get                                                  
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_txtField)<=0){this.txtField_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<Mobilize.Web.TextBox[]>(this,_Mobilize_References,32);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_txtField;}return this.txtField_k__BackingField;} 
#line 146

#line 146
                                                    set                                                       
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Mobilize.Web.TextBox[] >(this,_Mobilize_References,32,this.txtField_k__BackingField,(Mobilize.Web.TextBox[])value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_txtField;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_txtField;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtField_k__BackingField=(Mobilize.Web.TextBox[])value;} 
#line 146
                                                         } 
#line 147
      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.

      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {

#line hidden
this.Controls.DesignTime=true;
#line 155
      	this.components = new System.ComponentModel.Container();
      	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
      	this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
      	this.Frame1 = new Mobilize.Web.GroupBox();
      	this._txtField_6 = new Mobilize.Web.TextBox();
      	this._txtField_0 = new Mobilize.Web.TextBox();
      	this._txtField_5 = new Mobilize.Web.TextBox();
      	this.cmbCategory = new Mobilize.Web.ComboBox();
      	this._txtField_4 = new Mobilize.Web.TextBox();
      	this._txtField_3 = new Mobilize.Web.TextBox();
      	this._txtField_2 = new Mobilize.Web.TextBox();
      	this._txtField_1 = new Mobilize.Web.TextBox();
      	this.Check1 = new Mobilize.Web.CheckBox();
      	this.txtCategory = new Mobilize.Web.TextBox();
      	this.Label7 = new Mobilize.Web.Label();
      	this.Label3 = new Mobilize.Web.Label();
      	this.Label2 = new Mobilize.Web.Label();
      	this.Label1 = new Mobilize.Web.Label();
      	this.Label4 = new Mobilize.Web.Label();
      	this.Label5 = new Mobilize.Web.Label();
      	this.Label6 = new Mobilize.Web.Label();
      	this.Label11 = new Mobilize.Web.Label();
      	this.Label15 = new Mobilize.Web.Label();
      	this.dcProducts = new Mobilize.Web.VBUC.ADODataControlHelper();
      	this.ImageList1 = new Mobilize.Web.ImageList();
      	this.Toolbar1 = new Mobilize.Web.ToolStrip();
      	this.Toolbar1_Buttons_Button1 = new Mobilize.Web.ToolStripButton();
      	this.Toolbar1_Buttons_Button2 = new Mobilize.Web.ToolStripButton();
      	this.Toolbar1_Buttons_Button3 = new Mobilize.Web.ToolStripButton();
      	this.Toolbar1_Buttons_Button4 = new Mobilize.Web.ToolStripButton();
      	this.Toolbar1_Buttons_Button5 = new Mobilize.Web.ToolStripButton();
      	this.Toolbar1_Buttons_Button6 = new Mobilize.Web.ToolStripButton();
      	this.Frame1.SuspendLayout();
      	this.Toolbar1.SuspendLayout();
      	this.SuspendLayout();
      	// 
      	// Frame1
      	// 
      	this.Frame1.AllowDrop = true;
      	this.Frame1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Frame1.Controls.Add(this._txtField_6);
         this.Frame1.Controls.Add(this._txtField_0);
         this.Frame1.Controls.Add(this._txtField_5);
         this.Frame1.Controls.Add(this.cmbCategory);
         this.Frame1.Controls.Add(this._txtField_4);
         this.Frame1.Controls.Add(this._txtField_3);
         this.Frame1.Controls.Add(this._txtField_2);
         this.Frame1.Controls.Add(this._txtField_1);
         this.Frame1.Controls.Add(this.Check1);
         this.Frame1.Controls.Add(this.txtCategory);
         this.Frame1.Controls.Add(this.Label7);
         this.Frame1.Controls.Add(this.Label3);
         this.Frame1.Controls.Add(this.Label2);
         this.Frame1.Controls.Add(this.Label1);
         this.Frame1.Controls.Add(this.Label4);
         this.Frame1.Controls.Add(this.Label5);
         this.Frame1.Controls.Add(this.Label6);
         this.Frame1.Controls.Add(this.Label11);
         this.Frame1.Controls.Add(this.Label15);
         this.Frame1.Enabled = true;
         this.Frame1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Frame1.Location = new System.Drawing.Point(8, 48);
         this.Frame1.Name = "Frame1";
         this.Frame1.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Frame1.Size = new System.Drawing.Size(433, 281);
         this.Frame1.TabIndex = 9;
         this.Frame1.Text = "Product information";
         this.Frame1.Visible = true;
         // 
         // _txtField_6
         // 
         this._txtField_6.AcceptsReturn = true;
         this._txtField_6.AllowDrop = true;
         this._txtField_6.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_6.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_6.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this._txtField_6.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_6.Location = new System.Drawing.Point(256, 240);
         this._txtField_6.MaxLength = 0;
         this._txtField_6.Name = "_txtField_6";
         this._txtField_6.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtField_6.Size = new System.Drawing.Size(105, 20);
         this._txtField_6.TabIndex = 20;
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
         this._txtField_0.MaxLength = 20;
         this._txtField_0.Name = "_txtField_0";
         this._txtField_0.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtField_0.Size = new System.Drawing.Size(113, 20);
         this._txtField_0.TabIndex = 0;
         // 
         // _txtField_5
         // 
         this._txtField_5.AcceptsReturn = true;
         this._txtField_5.AllowDrop = true;
         this._txtField_5.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_5.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_5.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this._txtField_5.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_5.Location = new System.Drawing.Point(104, 240);
         this._txtField_5.MaxLength = 0;
         this._txtField_5.Name = "_txtField_5";
         this._txtField_5.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtField_5.Size = new System.Drawing.Size(105, 20);
         this._txtField_5.TabIndex = 7;
         // 
         // cmbCategory
         // 
         this.cmbCategory.AllowDrop = true;
         this.cmbCategory.BackColor = Mobilize.Web.SystemColors.Window;
         this.cmbCategory.CausesValidation = true;
         this.cmbCategory.DropDownStyle = Mobilize.Web.ComboBoxStyle.DropDownList;
         this.cmbCategory.Enabled = true;
         this.cmbCategory.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.cmbCategory.IntegralHeight = true;
         this.cmbCategory.Location = new System.Drawing.Point(104, 117);
         this.cmbCategory.Name = "cmbCategory";
         this.cmbCategory.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmbCategory.Size = new System.Drawing.Size(121, 21);
         this.cmbCategory.Sorted = false;
         this.cmbCategory.TabIndex = 3;
         this.cmbCategory.TabStop = true;
         this.cmbCategory.Visible = true;
         this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
         // 
         // _txtField_4
         // 
         this._txtField_4.AcceptsReturn = true;
         this._txtField_4.AllowDrop = true;
         this._txtField_4.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_4.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_4.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this._txtField_4.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_4.Location = new System.Drawing.Point(104, 210);
         this._txtField_4.MaxLength = 0;
         this._txtField_4.Name = "_txtField_4";
         this._txtField_4.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtField_4.Size = new System.Drawing.Size(105, 20);
         this._txtField_4.TabIndex = 6;
         // 
         // _txtField_3
         // 
         this._txtField_3.AcceptsReturn = true;
         this._txtField_3.AllowDrop = true;
         this._txtField_3.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_3.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_3.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this._txtField_3.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_3.Location = new System.Drawing.Point(104, 148);
         this._txtField_3.MaxLength = 0;
         this._txtField_3.Name = "_txtField_3";
         this._txtField_3.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtField_3.Size = new System.Drawing.Size(121, 20);
         this._txtField_3.TabIndex = 4;
         // 
         // _txtField_2
         // 
         this._txtField_2.AcceptsReturn = true;
         this._txtField_2.AllowDrop = true;
         this._txtField_2.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_2.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_2.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this._txtField_2.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_2.Location = new System.Drawing.Point(104, 88);
         this._txtField_2.MaxLength = 255;
         this._txtField_2.Name = "_txtField_2";
         this._txtField_2.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtField_2.Size = new System.Drawing.Size(305, 20);
         this._txtField_2.TabIndex = 2;
         // 
         // _txtField_1
         // 
         this._txtField_1.AcceptsReturn = true;
         this._txtField_1.AllowDrop = true;
         this._txtField_1.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_1.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_1.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this._txtField_1.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_1.Location = new System.Drawing.Point(104, 56);
         this._txtField_1.MaxLength = 50;
         this._txtField_1.Name = "_txtField_1";
         this._txtField_1.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtField_1.Size = new System.Drawing.Size(193, 20);
         this._txtField_1.TabIndex = 1;
         // 
         // Check1
         // 
         this.Check1.AllowDrop = true;
         this.Check1.Appearance = Mobilize.Web.Appearance.Normal;
         this.Check1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Check1.CausesValidation = true;
         this.Check1.CheckAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.Check1.CheckState = Mobilize.Web.CheckState.Unchecked;
         this.Check1.Enabled = true;
         this.Check1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Check1.Location = new System.Drawing.Point(104, 181);
         this.Check1.Name = "Check1";
         this.Check1.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Check1.Size = new System.Drawing.Size(25, 17);
         this.Check1.TabIndex = 5;
         this.Check1.TabStop = true;
         this.Check1.Text = "";
         this.Check1.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.Check1.Visible = true;
         // 
         // txtCategory
         // 
         this.txtCategory.AcceptsReturn = true;
         this.txtCategory.AllowDrop = true;
         this.txtCategory.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtCategory.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtCategory.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtCategory.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtCategory.Location = new System.Drawing.Point(200, 120);
         this.txtCategory.MaxLength = 0;
         this.txtCategory.Name = "txtCategory";
         this.txtCategory.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtCategory.Size = new System.Drawing.Size(10, 13);
         this.txtCategory.TabIndex = 16;
         this.txtCategory.TabStop = false;
         this.txtCategory.TextChanged += new System.EventHandler(this.txtCategory_TextChanged);
         // 
         // Label7
         // 
         this.Label7.AllowDrop = true;
         this.Label7.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label7.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label7.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label7.Location = new System.Drawing.Point(216, 244);
         this.Label7.Name = "Label7";
         this.Label7.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label7.Size = new System.Drawing.Size(57, 17);
         this.Label7.TabIndex = 19;
         this.Label7.Text = "Unit";
         // 
         // Label3
         // 
         this.Label3.AllowDrop = true;
         this.Label3.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label3.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label3.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label3.Location = new System.Drawing.Point(16, 24);
         this.Label3.Name = "Label3";
         this.Label3.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label3.Size = new System.Drawing.Size(89, 17);
         this.Label3.TabIndex = 18;
         this.Label3.Text = "Product ";
         // 
         // Label2
         // 
         this.Label2.AllowDrop = true;
         this.Label2.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label2.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label2.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label2.Location = new System.Drawing.Point(16, 244);
         this.Label2.Name = "Label2";
         this.Label2.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label2.Size = new System.Drawing.Size(81, 17);
         this.Label2.TabIndex = 17;
         this.Label2.Text = "Qty per unit";
         // 
         // Label1
         // 
         this.Label1.AllowDrop = true;
         this.Label1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label1.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label1.Location = new System.Drawing.Point(16, 56);
         this.Label1.Name = "Label1";
         this.Label1.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label1.Size = new System.Drawing.Size(89, 17);
         this.Label1.TabIndex = 15;
         this.Label1.Text = "Name";
         // 
         // Label4
         // 
         this.Label4.AllowDrop = true;
         this.Label4.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label4.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label4.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label4.Location = new System.Drawing.Point(16, 87);
         this.Label4.Name = "Label4";
         this.Label4.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label4.Size = new System.Drawing.Size(89, 17);
         this.Label4.TabIndex = 14;
         this.Label4.Text = "Desc";
         // 
         // Label5
         // 
         this.Label5.AllowDrop = true;
         this.Label5.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label5.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label5.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label5.Location = new System.Drawing.Point(16, 148);
         this.Label5.Name = "Label5";
         this.Label5.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label5.Size = new System.Drawing.Size(89, 17);
         this.Label5.TabIndex = 13;
         this.Label5.Text = "Serial number";
         // 
         // Label6
         // 
         this.Label6.AllowDrop = true;
         this.Label6.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label6.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label6.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label6.Location = new System.Drawing.Point(16, 210);
         this.Label6.Name = "Label6";
         this.Label6.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label6.Size = new System.Drawing.Size(81, 17);
         this.Label6.TabIndex = 12;
         this.Label6.Text = "Unit price";
         // 
         // Label11
         // 
         this.Label11.AllowDrop = true;
         this.Label11.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label11.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label11.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label11.Location = new System.Drawing.Point(16, 118);
         this.Label11.Name = "Label11";
         this.Label11.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label11.Size = new System.Drawing.Size(89, 17);
         this.Label11.TabIndex = 11;
         this.Label11.Text = "Category";
         // 
         // Label15
         // 
         this.Label15.AllowDrop = true;
         this.Label15.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label15.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label15.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label15.Location = new System.Drawing.Point(16, 179);
         this.Label15.Name = "Label15";
         this.Label15.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label15.Size = new System.Drawing.Size(89, 17);
         this.Label15.TabIndex = 10;
         this.Label15.Text = "Discontinued";
         // 
         // dcProducts
         // 
         this.dcProducts.AllowDrop = true;
         this.dcProducts.Properties().BackColor = Mobilize.Web.SystemColors.Window;
         this.dcProducts.Properties().BOFAction = Stub._UpgradeHelpers.DB.Controls.BOFActionEnum.MoveFirst;
         this.dcProducts.ConnectionString = "Driver=SQLite3 ODBC Driver; Database=Orders.db";
         this.dcProducts.CursorLocation = UpgradeHelpers.DB.ADO.CursorLocationEnum.adUseClient;
         this.dcProducts.Enabled = true;
         this.dcProducts.Properties().EOFAction = Stub._UpgradeHelpers.DB.Controls.EOFActionEnum.MoveLast;
         this.dcProducts.FactoryName = "Access";
         this.dcProducts.Properties().Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.dcProducts.Properties().ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.dcProducts.Location = new System.Drawing.Point(8, 336);
         this.dcProducts.LockType = UpgradeHelpers.DB.LockTypeEnum.LockOptimistic;
         this.dcProducts.Name = "dcProducts";
         this.dcProducts.Password = "";
         this.dcProducts.QueryTimeout = 30;
         this.dcProducts.QueryType = System.Data.CommandType.Text;
         this.dcProducts.RecordSource = "Select * from Products";
         this.dcProducts.Text = "Products";
         this.dcProducts.UserName = "";
         this.dcProducts.Width = 177;
         // 
         // ImageList1
         // 
         this.ImageList1.ImageSize = new System.Drawing.Size(16, 16);
         this.ImageList1.ImageStream = "SKS.frmProducts.ImageList1.ImageStream";
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
         this.Toolbar1.Size = new System.Drawing.Size(448, 44);
         this.Toolbar1.TabIndex = 8;
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
         // frmProducts
         // 
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = Mobilize.Web.SystemColors.Control;
         this.Properties().ClientSize = new System.Drawing.Size(448, 379);
         this.Controls.Add(this.Frame1);
         this.Controls.Add(this.dcProducts);
         this.Controls.Add(this.Toolbar1);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedSingle;
         this.Properties().Location = new System.Drawing.Point(3, 25);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmProducts";
         this.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Properties().ShowInTaskbar = false;
         this.Text = "Products";
         this.Closed += new System.EventHandler(this.Form_Closed);
         this.Frame1.ResumeLayout(false);
         this.Toolbar1.ResumeLayout(false);
         this.ResumeLayout(false);

#line hidden
this.Controls.DesignTime=false;
#line 642
      }

      void ReLoadForm(bool addEvents)
      {
      	InitializetxtField();
      	VB6_AddADODataBinding();
      }

      void InitializetxtField()
      {
      	this.txtField = new Mobilize.Web.TextBox[7];
      	this.txtField[6] = _txtField_6;
      	this.txtField[0] = _txtField_0;
      	this.txtField[5] = _txtField_5;
      	this.txtField[4] = _txtField_4;
      	this.txtField[3] = _txtField_3;
      	this.txtField[2] = _txtField_2;
      	this.txtField[1] = _txtField_1;
      }
      #endregion
      #region "Upgrade Support"

      public void VB6_AddADODataBinding()
      {
      	dcProducts.Refresh();
      	txtCategory.DataBindings.Add("Text", dcProducts, "CategoryID", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
      Check1.DataBindings.Add("Checked", dcProducts, "Discontinued", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
      _txtField_1.DataBindings.Add("Text", dcProducts, "ProductName", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
      _txtField_2.DataBindings.Add("Text", dcProducts, "ProductDescription", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
      _txtField_3.DataBindings.Add("Text", dcProducts, "SerialNumber", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
      _txtField_4.DataBindings.Add("Text", dcProducts, "UnitPrice", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
      _txtField_5.DataBindings.Add("Text", dcProducts, "QuantityPerUnit", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
      _txtField_0.DataBindings.Add("Text", dcProducts, "ProductID", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
      _txtField_6.DataBindings.Add("Text", dcProducts, "Unit", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
   }
   #endregion

   }
}
#pragma warning restore
