#pragma warning disable
#line 1 "frmAdjustStockManual.Designer.cs"
#pragma warning disable
#line 1 "frmAdjustStockManual.Designer.cs"
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmAdjustStockManual
   {

      [Intercepted]

      #region "Upgrade Support "
      private static frmAdjustStockManual m_vb6FormDefInstance 
#line 13
                                                               { 
#line 13
                                                                 get                                                                    
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (SKS.frmAdjustStockManual)catalog.frmAdjustStockManual.m_vb6FormDefInstance;} 
#line 13

#line 13
                                                                      set                                                                         
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmAdjustStockManual.m_vb6FormDefInstance = value;} 
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
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (bool)catalog.frmAdjustStockManual.m_InitializingDefInstance;} 
#line 16

#line 16
                                                           set                                                              
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmAdjustStockManual.m_InitializingDefInstance = value;} 
#line 16
                                                                }

#line 17

      [Intercepted]
      public static frmAdjustStockManual DefInstance
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

      public static frmAdjustStockManual CreateInstance()
      {
      	frmAdjustStockManual theInstance = new frmAdjustStockManual();
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
private Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel1_k__BackingField;
#line 58


      [Intercepted]
      public Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel1 
#line 58
                                                                         { 
#line 58
                                                                           get                                                                              
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_sbStatusBar_Panels_Panel1)<=0){this.sbStatusBar_Panels_Panel1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ToolStripStatusLabel>(this,_Mobilize_References,3);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar_Panels_Panel1;;} return this.sbStatusBar_Panels_Panel1_k__BackingField; } 
#line 58

#line 58
                                                                                set                                                                                   
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ToolStripStatusLabel>(this,_Mobilize_References,3,this.sbStatusBar_Panels_Panel1_k__BackingField,(Mobilize.Web.ToolStripStatusLabel)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_sbStatusBar_Panels_Panel1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar_Panels_Panel1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.sbStatusBar_Panels_Panel1_k__BackingField=(Mobilize.Web.ToolStripStatusLabel)value;} 
#line 58
                                                                                     }

#line 59

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.StatusStrip sbStatusBar_k__BackingField;
#line 61


      [Intercepted]
      public Mobilize.Web.StatusStrip sbStatusBar 
#line 61
                                                  { 
#line 61
                                                    get                                                       
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_sbStatusBar)<=0){this.sbStatusBar_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.StatusStrip>(this,_Mobilize_References,4);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar;;} return this.sbStatusBar_k__BackingField; } 
#line 61

#line 61
                                                         set                                                            
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.StatusStrip>(this,_Mobilize_References,4,this.sbStatusBar_k__BackingField,(Mobilize.Web.StatusStrip)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_sbStatusBar;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sbStatusBar;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.sbStatusBar_k__BackingField=(Mobilize.Web.StatusStrip)value;} 
#line 61
                                                              }

#line 62

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtStockID_k__BackingField;
#line 64


      [Intercepted]
      public Mobilize.Web.TextBox txtStockID 
#line 64
                                             { 
#line 64
                                               get                                                  
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtStockID)<=0){this.txtStockID_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,5);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtStockID;;} return this.txtStockID_k__BackingField; } 
#line 64

#line 64
                                                    set                                                       
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,5,this.txtStockID_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtStockID;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtStockID;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtStockID_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 64
                                                         }

#line 65

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtOriginalPrice_k__BackingField;
#line 67


      [Intercepted]
      public Mobilize.Web.TextBox txtOriginalPrice 
#line 67
                                                   { 
#line 67
                                                     get                                                        
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtOriginalPrice)<=0){this.txtOriginalPrice_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,6);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtOriginalPrice;;} return this.txtOriginalPrice_k__BackingField; } 
#line 67

#line 67
                                                          set                                                             
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,6,this.txtOriginalPrice_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtOriginalPrice;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtOriginalPrice;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtOriginalPrice_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 67
                                                               }

#line 68

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox _txtValues_0_k__BackingField;
#line 70


      [Intercepted]
      private Mobilize.Web.TextBox _txtValues_0 
#line 70
                                                { 
#line 70
                                                  get                                                     
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__txtValues_0)<=0){this._txtValues_0_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,7);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtValues_0;;} return this._txtValues_0_k__BackingField; } 
#line 70

#line 70
                                                       set                                                          
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,7,this._txtValues_0_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__txtValues_0;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtValues_0;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._txtValues_0_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 70
                                                            }

#line 71

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtQuantityPerUnit_k__BackingField;
#line 73


      [Intercepted]
      public Mobilize.Web.TextBox txtQuantityPerUnit 
#line 73
                                                     { 
#line 73
                                                       get                                                          
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtQuantityPerUnit)<=0){this.txtQuantityPerUnit_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,8);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtQuantityPerUnit;;} return this.txtQuantityPerUnit_k__BackingField; } 
#line 73

#line 73
                                                            set                                                               
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,8,this.txtQuantityPerUnit_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtQuantityPerUnit;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtQuantityPerUnit;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtQuantityPerUnit_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 73
                                                                 }

#line 74

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtProductName_k__BackingField;
#line 76


      [Intercepted]
      public Mobilize.Web.TextBox txtProductName 
#line 76
                                                 { 
#line 76
                                                   get                                                      
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtProductName)<=0){this.txtProductName_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,9);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtProductName;;} return this.txtProductName_k__BackingField; } 
#line 76

#line 76
                                                        set                                                           
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,9,this.txtProductName_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtProductName;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtProductName;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtProductName_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 76
                                                             }

#line 77

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtUnit_k__BackingField;
#line 79


      [Intercepted]
      public Mobilize.Web.TextBox txtUnit 
#line 79
                                          { 
#line 79
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtUnit)<=0){this.txtUnit_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,10);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtUnit;;} return this.txtUnit_k__BackingField; } 
#line 79

#line 79
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,10,this.txtUnit_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtUnit;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtUnit;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtUnit_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 79
                                                      }

#line 80

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox _txtValues_1_k__BackingField;
#line 82


      [Intercepted]
      private Mobilize.Web.TextBox _txtValues_1 
#line 82
                                                { 
#line 82
                                                  get                                                     
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__txtValues_1)<=0){this._txtValues_1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,11);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtValues_1;;} return this._txtValues_1_k__BackingField; } 
#line 82

#line 82
                                                       set                                                          
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,11,this._txtValues_1_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__txtValues_1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__txtValues_1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._txtValues_1_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 82
                                                            }

#line 83

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtOriginalQuantity_k__BackingField;
#line 85


      [Intercepted]
      public Mobilize.Web.TextBox txtOriginalQuantity 
#line 85
                                                      { 
#line 85
                                                        get                                                           
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtOriginalQuantity)<=0){this.txtOriginalQuantity_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,12);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtOriginalQuantity;;} return this.txtOriginalQuantity_k__BackingField; } 
#line 85

#line 85
                                                             set                                                                
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,12,this.txtOriginalQuantity_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtOriginalQuantity;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtOriginalQuantity;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtOriginalQuantity_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 85
                                                                  }

#line 86

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvStocks_ColumnHeader_1__k__BackingField;
#line 88


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvStocks_ColumnHeader_1_ 
#line 88
                                                                        { 
#line 88
                                                                          get                                                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvStocks_ColumnHeader_1_)<=0){this.lvStocks_ColumnHeader_1__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,13);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvStocks_ColumnHeader_1_;;} return this.lvStocks_ColumnHeader_1__k__BackingField; } 
#line 88

#line 88
                                                                               set                                                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,13,this.lvStocks_ColumnHeader_1__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lvStocks_ColumnHeader_1_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvStocks_ColumnHeader_1_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvStocks_ColumnHeader_1__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 88
                                                                                    }

#line 89

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvStocks_ColumnHeader_2__k__BackingField;
#line 91


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvStocks_ColumnHeader_2_ 
#line 91
                                                                        { 
#line 91
                                                                          get                                                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvStocks_ColumnHeader_2_)<=0){this.lvStocks_ColumnHeader_2__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,14);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvStocks_ColumnHeader_2_;;} return this.lvStocks_ColumnHeader_2__k__BackingField; } 
#line 91

#line 91
                                                                               set                                                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,14,this.lvStocks_ColumnHeader_2__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lvStocks_ColumnHeader_2_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvStocks_ColumnHeader_2_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvStocks_ColumnHeader_2__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 91
                                                                                    }

#line 92

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvStocks_ColumnHeader_3__k__BackingField;
#line 94


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvStocks_ColumnHeader_3_ 
#line 94
                                                                        { 
#line 94
                                                                          get                                                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvStocks_ColumnHeader_3_)<=0){this.lvStocks_ColumnHeader_3__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,15);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvStocks_ColumnHeader_3_;;} return this.lvStocks_ColumnHeader_3__k__BackingField; } 
#line 94

#line 94
                                                                               set                                                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,15,this.lvStocks_ColumnHeader_3__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lvStocks_ColumnHeader_3_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvStocks_ColumnHeader_3_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvStocks_ColumnHeader_3__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 94
                                                                                    }

#line 95

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvStocks_ColumnHeader_4__k__BackingField;
#line 97


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvStocks_ColumnHeader_4_ 
#line 97
                                                                        { 
#line 97
                                                                          get                                                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvStocks_ColumnHeader_4_)<=0){this.lvStocks_ColumnHeader_4__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,16);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvStocks_ColumnHeader_4_;;} return this.lvStocks_ColumnHeader_4__k__BackingField; } 
#line 97

#line 97
                                                                               set                                                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,16,this.lvStocks_ColumnHeader_4__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lvStocks_ColumnHeader_4_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvStocks_ColumnHeader_4_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvStocks_ColumnHeader_4__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 97
                                                                                    }

#line 98

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvStocks_ColumnHeader_5__k__BackingField;
#line 100


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvStocks_ColumnHeader_5_ 
#line 100
                                                                        { 
#line 100
                                                                          get                                                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvStocks_ColumnHeader_5_)<=0){this.lvStocks_ColumnHeader_5__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,17);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvStocks_ColumnHeader_5_;;} return this.lvStocks_ColumnHeader_5__k__BackingField; } 
#line 100

#line 100
                                                                               set                                                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,17,this.lvStocks_ColumnHeader_5__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lvStocks_ColumnHeader_5_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvStocks_ColumnHeader_5_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvStocks_ColumnHeader_5__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 100
                                                                                    }

#line 101

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvStocks_ColumnHeader_6__k__BackingField;
#line 103


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvStocks_ColumnHeader_6_ 
#line 103
                                                                        { 
#line 103
                                                                          get                                                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvStocks_ColumnHeader_6_)<=0){this.lvStocks_ColumnHeader_6__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,18);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvStocks_ColumnHeader_6_;;} return this.lvStocks_ColumnHeader_6__k__BackingField; } 
#line 103

#line 103
                                                                               set                                                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,18,this.lvStocks_ColumnHeader_6__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvStocks_ColumnHeader_6_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvStocks_ColumnHeader_6_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvStocks_ColumnHeader_6__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 103
                                                                                    }

#line 104

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvStocks_ColumnHeader_7__k__BackingField;
#line 106


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvStocks_ColumnHeader_7_ 
#line 106
                                                                        { 
#line 106
                                                                          get                                                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvStocks_ColumnHeader_7_)<=0){this.lvStocks_ColumnHeader_7__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,19);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvStocks_ColumnHeader_7_;;} return this.lvStocks_ColumnHeader_7__k__BackingField; } 
#line 106

#line 106
                                                                               set                                                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,19,this.lvStocks_ColumnHeader_7__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvStocks_ColumnHeader_7_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvStocks_ColumnHeader_7_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvStocks_ColumnHeader_7__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 106
                                                                                    }

#line 107

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvStocks_ColumnHeader_8__k__BackingField;
#line 109


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvStocks_ColumnHeader_8_ 
#line 109
                                                                        { 
#line 109
                                                                          get                                                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvStocks_ColumnHeader_8_)<=0){this.lvStocks_ColumnHeader_8__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,20);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvStocks_ColumnHeader_8_;;} return this.lvStocks_ColumnHeader_8__k__BackingField; } 
#line 109

#line 109
                                                                               set                                                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,20,this.lvStocks_ColumnHeader_8__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvStocks_ColumnHeader_8_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvStocks_ColumnHeader_8_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvStocks_ColumnHeader_8__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 109
                                                                                    }

#line 110

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListView lvStocks_k__BackingField;
#line 112


      [Intercepted]
      public Mobilize.Web.ListView lvStocks 
#line 112
                                            { 
#line 112
                                              get                                                 
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvStocks)<=0){this.lvStocks_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListView>(this,_Mobilize_References,21);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvStocks;;} return this.lvStocks_k__BackingField; } 
#line 112

#line 112
                                                   set                                                      
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListView>(this,_Mobilize_References,21,this.lvStocks_k__BackingField,(Mobilize.Web.ListView)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvStocks;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvStocks;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvStocks_k__BackingField=(Mobilize.Web.ListView)value;} 
#line 112
                                                        }

#line 113

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.GroupBox Frame3_k__BackingField;
#line 115


      [Intercepted]
      public Mobilize.Web.GroupBox Frame3 
#line 115
                                          { 
#line 115
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Frame3)<=0){this.Frame3_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.GroupBox>(this,_Mobilize_References,22);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Frame3;;} return this.Frame3_k__BackingField; } 
#line 115

#line 115
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.GroupBox>(this,_Mobilize_References,22,this.Frame3_k__BackingField,(Mobilize.Web.GroupBox)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Frame3;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Frame3;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Frame3_k__BackingField=(Mobilize.Web.GroupBox)value;} 
#line 115
                                                      }

#line 116

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtCode_k__BackingField;
#line 118


      [Intercepted]
      public Mobilize.Web.TextBox txtCode 
#line 118
                                          { 
#line 118
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtCode)<=0){this.txtCode_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,23);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtCode;;} return this.txtCode_k__BackingField; } 
#line 118

#line 118
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,23,this.txtCode_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_txtCode;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtCode;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtCode_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 118
                                                      }

#line 119

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtName_k__BackingField;
#line 121


      [Intercepted]
      public Mobilize.Web.TextBox txtName 
#line 121
                                          { 
#line 121
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtName)<=0){this.txtName_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,24);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtName;;} return this.txtName_k__BackingField; } 
#line 121

#line 121
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,24,this.txtName_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_txtName;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtName;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtName_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 121
                                                      }

#line 122

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdProducts_k__BackingField;
#line 124


      [Intercepted]
      public Mobilize.Web.Button cmdProducts 
#line 124
                                             { 
#line 124
                                               get                                                  
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdProducts)<=0){this.cmdProducts_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,25);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdProducts;;} return this.cmdProducts_k__BackingField; } 
#line 124

#line 124
                                                    set                                                       
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,25,this.cmdProducts_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_cmdProducts;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdProducts;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdProducts_k__BackingField=(Mobilize.Web.Button)value;} 
#line 124
                                                         }

#line 125

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label5_k__BackingField;
#line 127


      [Intercepted]
      public Mobilize.Web.Label Label5 
#line 127
                                       { 
#line 127
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label5)<=0){this.Label5_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,26);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label5;;} return this.Label5_k__BackingField; } 
#line 127

#line 127
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,26,this.Label5_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label5;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label5;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label5_k__BackingField=(Mobilize.Web.Label)value;} 
#line 127
                                                   }

#line 128

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label4_k__BackingField;
#line 130


      [Intercepted]
      public Mobilize.Web.Label Label4 
#line 130
                                       { 
#line 130
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label4)<=0){this.Label4_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,27);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label4;;} return this.Label4_k__BackingField; } 
#line 130

#line 130
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,27,this.Label4_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label4;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label4;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label4_k__BackingField=(Mobilize.Web.Label)value;} 
#line 130
                                                   }

#line 131

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.GroupBox Frame1_k__BackingField;
#line 133


      [Intercepted]
      public Mobilize.Web.GroupBox Frame1 
#line 133
                                          { 
#line 133
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Frame1)<=0){this.Frame1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.GroupBox>(this,_Mobilize_References,28);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Frame1;;} return this.Frame1_k__BackingField; } 
#line 133

#line 133
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.GroupBox>(this,_Mobilize_References,28,this.Frame1_k__BackingField,(Mobilize.Web.GroupBox)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Frame1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Frame1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Frame1_k__BackingField=(Mobilize.Web.GroupBox)value;} 
#line 133
                                                      }

#line 134

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdClose_k__BackingField;
#line 136


      [Intercepted]
      public Mobilize.Web.Button cmdClose 
#line 136
                                          { 
#line 136
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdClose)<=0){this.cmdClose_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,29);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdClose;;} return this.cmdClose_k__BackingField; } 
#line 136

#line 136
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,29,this.cmdClose_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_cmdClose;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdClose;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdClose_k__BackingField=(Mobilize.Web.Button)value;} 
#line 136
                                                      }

#line 137

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdSave_k__BackingField;
#line 139


      [Intercepted]
      public Mobilize.Web.Button cmdSave 
#line 139
                                         { 
#line 139
                                           get                                              
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdSave)<=0){this.cmdSave_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,30);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdSave;;} return this.cmdSave_k__BackingField; } 
#line 139

#line 139
                                                set                                                   
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,30,this.cmdSave_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_cmdSave;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdSave;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdSave_k__BackingField=(Mobilize.Web.Button)value;} 
#line 139
                                                     }

#line 140

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_1__k__BackingField;
#line 142


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_1_ 
#line 142
                                                                          { 
#line 142
                                                                            get                                                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lvProducts_ColumnHeader_1_)<=0){this.lvProducts_ColumnHeader_1__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,31);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_1_;;} return this.lvProducts_ColumnHeader_1__k__BackingField; } 
#line 142

#line 142
                                                                                 set                                                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,31,this.lvProducts_ColumnHeader_1__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvProducts_ColumnHeader_1_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lvProducts_ColumnHeader_1_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProducts_ColumnHeader_1__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 142
                                                                                      }

#line 143

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_2__k__BackingField;
#line 145


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_2_ 
#line 145
                                                                          { 
#line 145
                                                                            get                                                                               
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_lvProducts_ColumnHeader_2_)<=0){this.lvProducts_ColumnHeader_2__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,32);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_lvProducts_ColumnHeader_2_;;} return this.lvProducts_ColumnHeader_2__k__BackingField; } 
#line 145

#line 145
                                                                                 set                                                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,32,this.lvProducts_ColumnHeader_2__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvProducts_ColumnHeader_2_;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_lvProducts_ColumnHeader_2_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProducts_ColumnHeader_2__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 145
                                                                                      }

#line 146

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_3__k__BackingField;
#line 148


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_3_ 
#line 148
                                                                          { 
#line 148
                                                                            get                                                                               
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_lvProducts_ColumnHeader_3_)<=0){this.lvProducts_ColumnHeader_3__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,33);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_lvProducts_ColumnHeader_3_;;} return this.lvProducts_ColumnHeader_3__k__BackingField; } 
#line 148

#line 148
                                                                                 set                                                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,33,this.lvProducts_ColumnHeader_3__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvProducts_ColumnHeader_3_;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_lvProducts_ColumnHeader_3_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProducts_ColumnHeader_3__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 148
                                                                                      }

#line 149

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_4__k__BackingField;
#line 151


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_4_ 
#line 151
                                                                          { 
#line 151
                                                                            get                                                                               
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_lvProducts_ColumnHeader_4_)<=0){this.lvProducts_ColumnHeader_4__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,34);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_lvProducts_ColumnHeader_4_;;} return this.lvProducts_ColumnHeader_4__k__BackingField; } 
#line 151

#line 151
                                                                                 set                                                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,34,this.lvProducts_ColumnHeader_4__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvProducts_ColumnHeader_4_;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_lvProducts_ColumnHeader_4_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProducts_ColumnHeader_4__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 151
                                                                                      }

#line 152

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_5__k__BackingField;
#line 154


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_5_ 
#line 154
                                                                          { 
#line 154
                                                                            get                                                                               
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_lvProducts_ColumnHeader_5_)<=0){this.lvProducts_ColumnHeader_5__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,35);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_lvProducts_ColumnHeader_5_;;} return this.lvProducts_ColumnHeader_5__k__BackingField; } 
#line 154

#line 154
                                                                                 set                                                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,35,this.lvProducts_ColumnHeader_5__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvProducts_ColumnHeader_5_;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_lvProducts_ColumnHeader_5_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProducts_ColumnHeader_5__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 154
                                                                                      }

#line 155

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_6__k__BackingField;
#line 157


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_6_ 
#line 157
                                                                          { 
#line 157
                                                                            get                                                                               
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_lvProducts_ColumnHeader_6_)<=0){this.lvProducts_ColumnHeader_6__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,36);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_lvProducts_ColumnHeader_6_;;} return this.lvProducts_ColumnHeader_6__k__BackingField; } 
#line 157

#line 157
                                                                                 set                                                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,36,this.lvProducts_ColumnHeader_6__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvProducts_ColumnHeader_6_;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_lvProducts_ColumnHeader_6_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProducts_ColumnHeader_6__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 157
                                                                                      }

#line 158

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_7__k__BackingField;
#line 160


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_7_ 
#line 160
                                                                          { 
#line 160
                                                                            get                                                                               
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_lvProducts_ColumnHeader_7_)<=0){this.lvProducts_ColumnHeader_7__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,37);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_lvProducts_ColumnHeader_7_;;} return this.lvProducts_ColumnHeader_7__k__BackingField; } 
#line 160

#line 160
                                                                                 set                                                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,37,this.lvProducts_ColumnHeader_7__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvProducts_ColumnHeader_7_;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_lvProducts_ColumnHeader_7_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProducts_ColumnHeader_7__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 160
                                                                                      }

#line 161

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListView lvProducts_k__BackingField;
#line 163


      [Intercepted]
      public Mobilize.Web.ListView lvProducts 
#line 163
                                              { 
#line 163
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_lvProducts)<=0){this.lvProducts_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListView>(this,_Mobilize_References,38);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_lvProducts;;} return this.lvProducts_k__BackingField; } 
#line 163

#line 163
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListView>(this,_Mobilize_References,38,this.lvProducts_k__BackingField,(Mobilize.Web.ListView)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lvProducts;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_lvProducts;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lvProducts_k__BackingField=(Mobilize.Web.ListView)value;} 
#line 163
                                                          }

#line 164

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label14_k__BackingField;
#line 166


      [Intercepted]
      public Mobilize.Web.Label Label14 
#line 166
                                        { 
#line 166
                                          get                                             
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label14)<=0){this.Label14_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,39);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label14;;} return this.Label14_k__BackingField; } 
#line 166

#line 166
                                               set                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,39,this.Label14_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label14;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label14;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label14_k__BackingField=(Mobilize.Web.Label)value;} 
#line 166
                                                    }

#line 167

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label lblNewQuantity_k__BackingField;
#line 169


      [Intercepted]
      public Mobilize.Web.Label lblNewQuantity 
#line 169
                                               { 
#line 169
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_lblNewQuantity)<=0){this.lblNewQuantity_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,40);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_lblNewQuantity;;} return this.lblNewQuantity_k__BackingField; } 
#line 169

#line 169
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,40,this.lblNewQuantity_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lblNewQuantity;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_lblNewQuantity;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lblNewQuantity_k__BackingField=(Mobilize.Web.Label)value;} 
#line 169
                                                           }

#line 170

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label12_k__BackingField;
#line 172


      [Intercepted]
      public Mobilize.Web.Label Label12 
#line 172
                                        { 
#line 172
                                          get                                             
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label12)<=0){this.Label12_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,41);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label12;;} return this.Label12_k__BackingField; } 
#line 172

#line 172
                                               set                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,41,this.Label12_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label12;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label12;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label12_k__BackingField=(Mobilize.Web.Label)value;} 
#line 172
                                                    }

#line 173

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label lblCurrentQuantity_k__BackingField;
#line 175


      [Intercepted]
      public Mobilize.Web.Label lblCurrentQuantity 
#line 175
                                                   { 
#line 175
                                                     get                                                        
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_lblCurrentQuantity)<=0){this.lblCurrentQuantity_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,42);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_lblCurrentQuantity;;} return this.lblCurrentQuantity_k__BackingField; } 
#line 175

#line 175
                                                          set                                                             
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,42,this.lblCurrentQuantity_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_lblCurrentQuantity;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_lblCurrentQuantity;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lblCurrentQuantity_k__BackingField=(Mobilize.Web.Label)value;} 
#line 175
                                                               }

#line 176

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label11_k__BackingField;
#line 178


      [Intercepted]
      public Mobilize.Web.Label Label11 
#line 178
                                        { 
#line 178
                                          get                                             
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label11)<=0){this.Label11_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,43);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label11;;} return this.Label11_k__BackingField; } 
#line 178

#line 178
                                               set                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,43,this.Label11_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label11;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label11;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label11_k__BackingField=(Mobilize.Web.Label)value;} 
#line 178
                                                    }

#line 179

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label10_k__BackingField;
#line 181


      [Intercepted]
      public Mobilize.Web.Label Label10 
#line 181
                                        { 
#line 181
                                          get                                             
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label10)<=0){this.Label10_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,44);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label10;;} return this.Label10_k__BackingField; } 
#line 181

#line 181
                                               set                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,44,this.Label10_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label10;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label10;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label10_k__BackingField=(Mobilize.Web.Label)value;} 
#line 181
                                                    }

#line 182

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label8_k__BackingField;
#line 184


      [Intercepted]
      public Mobilize.Web.Label Label8 
#line 184
                                       { 
#line 184
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label8)<=0){this.Label8_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,45);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label8;;} return this.Label8_k__BackingField; } 
#line 184

#line 184
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,45,this.Label8_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label8;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label8;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label8_k__BackingField=(Mobilize.Web.Label)value;} 
#line 184
                                                   }

#line 185

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label9_k__BackingField;
#line 187


      [Intercepted]
      public Mobilize.Web.Label Label9 
#line 187
                                       { 
#line 187
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label9)<=0){this.Label9_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,46);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label9;;} return this.Label9_k__BackingField; } 
#line 187

#line 187
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,46,this.Label9_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label9;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label9;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label9_k__BackingField=(Mobilize.Web.Label)value;} 
#line 187
                                                   }

#line 188

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label7_k__BackingField;
#line 190


      [Intercepted]
      public Mobilize.Web.Label Label7 
#line 190
                                       { 
#line 190
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label7)<=0){this.Label7_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,47);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label7;;} return this.Label7_k__BackingField; } 
#line 190

#line 190
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,47,this.Label7_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label7;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label7;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label7_k__BackingField=(Mobilize.Web.Label)value;} 
#line 190
                                                   }

#line 191

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label6_k__BackingField;
#line 193


      [Intercepted]
      public Mobilize.Web.Label Label6 
#line 193
                                       { 
#line 193
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label6)<=0){this.Label6_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,48);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label6;;} return this.Label6_k__BackingField; } 
#line 193

#line 193
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,48,this.Label6_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label6;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label6;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label6_k__BackingField=(Mobilize.Web.Label)value;} 
#line 193
                                                   }

#line 194

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label2_k__BackingField;
#line 196


      [Intercepted]
      public Mobilize.Web.Label Label2 
#line 196
                                       { 
#line 196
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label2)<=0){this.Label2_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,49);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label2;;} return this.Label2_k__BackingField; } 
#line 196

#line 196
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,49,this.Label2_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_1|=_Mobilize_Dirty_Label2;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label2;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label2_k__BackingField=(Mobilize.Web.Label)value;} 
#line 196
                                                   }

#line 197

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label1_k__BackingField;
#line 199


      [Intercepted]
      public Mobilize.Web.Label Label1 
#line 199
                                       { 
#line 199
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label1)<=0){this.Label1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,50);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label1;;} return this.Label1_k__BackingField; } 
#line 199

#line 199
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,50,this.Label1_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_2|=_Mobilize_Dirty_Label1;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label1_k__BackingField=(Mobilize.Web.Label)value;} 
#line 199
                                                   }

#line 200

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label3_k__BackingField;
#line 202


      [Intercepted]
      public Mobilize.Web.Label Label3 
#line 202
                                       { 
#line 202
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_Label3)<=0){this.Label3_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,51);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label3;;} return this.Label3_k__BackingField; } 
#line 202

#line 202
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,51,this.Label3_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_2|=_Mobilize_Dirty_Label3;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_Label3;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label3_k__BackingField=(Mobilize.Web.Label)value;} 
#line 202
                                                   }

#line 203

#line hidden
                                                            
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox[] txtValues_k__BackingField;
#line 205
                                                            

      [Intercepted]
      public Mobilize.Web.TextBox[] txtValues 
#line 205
                                              { 
#line 205
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_txtValues)<=0){this.txtValues_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<Mobilize.Web.TextBox[]>(this,_Mobilize_References,52);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_txtValues;}return this.txtValues_k__BackingField;} 
#line 205

#line 205
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Mobilize.Web.TextBox[] >(this,_Mobilize_References,52,this.txtValues_k__BackingField,(Mobilize.Web.TextBox[])value)){_Mobilize_DirtyFlag_2|=_Mobilize_Dirty_txtValues;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_txtValues;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtValues_k__BackingField=(Mobilize.Web.TextBox[])value;} 
#line 205
                                                          } 
#line 206

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListView listViewHelper1_k__BackingField;
#line 208


      [Intercepted]
      private Mobilize.Web.ListView listViewHelper1 
#line 208
                                                    { 
#line 208
                                                      get                                                         
#line hidden
{if((_Mobilize_LoadedFlag_1&_Mobilize_Loaded_listViewHelper1)<=0){this.listViewHelper1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListView>(this,_Mobilize_References,53);_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_listViewHelper1;;} return this.listViewHelper1_k__BackingField; } 
#line 208

#line 208
                                                           set                                                              
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListView>(this,_Mobilize_References,53,this.listViewHelper1_k__BackingField,(Mobilize.Web.ListView)value)){_Mobilize_DirtyFlag_2|=_Mobilize_Dirty_listViewHelper1;}_Mobilize_LoadedFlag_1|=_Mobilize_Loaded_listViewHelper1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.listViewHelper1_k__BackingField=(Mobilize.Web.ListView)value;} 
#line 208
                                                                }

#line 209
      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.

      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {

#line hidden
this.Controls.DesignTime=true;
#line 217
      	this.components = new System.ComponentModel.Container();
      	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdjustStockManual));
      	this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
      	this.sbStatusBar = new Mobilize.Web.StatusStrip();
      	this.sbStatusBar_Panels_Panel1 = new Mobilize.Web.ToolStripStatusLabel();
      	this.txtStockID = new Mobilize.Web.TextBox();
      	this.txtOriginalPrice = new Mobilize.Web.TextBox();
      	this._txtValues_0 = new Mobilize.Web.TextBox();
      	this.txtQuantityPerUnit = new Mobilize.Web.TextBox();
      	this.txtProductName = new Mobilize.Web.TextBox();
      	this.txtUnit = new Mobilize.Web.TextBox();
      	this._txtValues_1 = new Mobilize.Web.TextBox();
      	this.txtOriginalQuantity = new Mobilize.Web.TextBox();
      	this.Frame3 = new Mobilize.Web.GroupBox();
      	this.lvStocks = new Mobilize.Web.ListView();
      	this.lvStocks_ColumnHeader_1_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvStocks_ColumnHeader_2_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvStocks_ColumnHeader_3_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvStocks_ColumnHeader_4_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvStocks_ColumnHeader_5_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvStocks_ColumnHeader_6_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvStocks_ColumnHeader_7_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvStocks_ColumnHeader_8_ = new Mobilize.Web.ListViewColumnHeader();
      	this.Frame1 = new Mobilize.Web.GroupBox();
      	this.txtCode = new Mobilize.Web.TextBox();
      	this.txtName = new Mobilize.Web.TextBox();
      	this.cmdProducts = new Mobilize.Web.Button();
      	this.Label5 = new Mobilize.Web.Label();
      	this.Label4 = new Mobilize.Web.Label();
      	this.cmdClose = new Mobilize.Web.Button();
      	this.cmdSave = new Mobilize.Web.Button();
      	this.lvProducts = new Mobilize.Web.ListView();
      	this.lvProducts_ColumnHeader_1_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProducts_ColumnHeader_2_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProducts_ColumnHeader_3_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProducts_ColumnHeader_4_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProducts_ColumnHeader_5_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProducts_ColumnHeader_6_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvProducts_ColumnHeader_7_ = new Mobilize.Web.ListViewColumnHeader();
      	this.Label14 = new Mobilize.Web.Label();
      	this.lblNewQuantity = new Mobilize.Web.Label();
      	this.Label12 = new Mobilize.Web.Label();
      	this.lblCurrentQuantity = new Mobilize.Web.Label();
      	this.Label11 = new Mobilize.Web.Label();
      	this.Label10 = new Mobilize.Web.Label();
      	this.Label8 = new Mobilize.Web.Label();
      	this.Label9 = new Mobilize.Web.Label();
      	this.Label7 = new Mobilize.Web.Label();
      	this.Label6 = new Mobilize.Web.Label();
      	this.Label2 = new Mobilize.Web.Label();
      	this.Label1 = new Mobilize.Web.Label();
      	this.Label3 = new Mobilize.Web.Label();
      	this.sbStatusBar.SuspendLayout();
      	this.Frame3.SuspendLayout();
      	this.lvStocks.SuspendLayout();
      	this.Frame1.SuspendLayout();
      	this.lvProducts.SuspendLayout();
      	this.SuspendLayout();
      	this.listViewHelper1 = new Mobilize.Web.ListView(this.components);
      	// 
      	// sbStatusBar
      	// 
      	this.sbStatusBar.AllowDrop = true;
      	this.sbStatusBar.Properties().BackColor = Mobilize.Web.SystemColors.Control;
         this.sbStatusBar.Dock = Mobilize.Web.DockStyle.Bottom;
         this.sbStatusBar.Location = new System.Drawing.Point(0, 538);
         this.sbStatusBar.Name = "sbStatusBar";
         this.sbStatusBar.Properties().ShowItemToolTips = true;
         this.sbStatusBar.Size = new System.Drawing.Size(426, 25);
         this.sbStatusBar.TabIndex = 28;
         this.sbStatusBar.Items.AddRange(new Mobilize.Web.ToolStripItem[]{this.sbStatusBar_Panels_Panel1});
         // 
         // sbStatusBar_Panels_Panel1
         // 
         this.sbStatusBar_Panels_Panel1.Properties().BorderSides = (Mobilize.Web.ToolStripStatusLabelBorderSides) (Mobilize.Web.ToolStripStatusLabelBorderSides.Left | Mobilize.Web.ToolStripStatusLabelBorderSides.Top | Mobilize.Web.ToolStripStatusLabelBorderSides.Right | Mobilize.Web.ToolStripStatusLabelBorderSides.Bottom);
         this.sbStatusBar_Panels_Panel1.Properties().BorderStyle = Mobilize.Web.Border3DStyle.SunkenOuter;
         this.sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
         this.sbStatusBar_Panels_Panel1.Margin = new Mobilize.Web.Padding(0);
         this.sbStatusBar_Panels_Panel1.Properties().Size = new System.Drawing.Size(425, 25);
         this.sbStatusBar_Panels_Panel1.Properties().Spring = true;
         this.sbStatusBar_Panels_Panel1.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.sbStatusBar_Panels_Panel1.TextImageRelation = Mobilize.Web.TextImageRelation.ImageBeforeText;
         // 
         // txtStockID
         // 
         this.txtStockID.AcceptsReturn = true;
         this.txtStockID.AllowDrop = true;
         this.txtStockID.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtStockID.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtStockID.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtStockID.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtStockID.Location = new System.Drawing.Point(96, 374);
         this.txtStockID.MaxLength = 0;
         this.txtStockID.Name = "txtStockID";
         this.txtStockID.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtStockID.Size = new System.Drawing.Size(81, 20);
         this.txtStockID.TabIndex = 26;
         this.txtStockID.TabStop = false;
         // 
         // txtOriginalPrice
         // 
         this.txtOriginalPrice.AcceptsReturn = true;
         this.txtOriginalPrice.AllowDrop = true;
         this.txtOriginalPrice.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtOriginalPrice.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtOriginalPrice.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtOriginalPrice.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtOriginalPrice.Location = new System.Drawing.Point(96, 403);
         this.txtOriginalPrice.MaxLength = 0;
         this.txtOriginalPrice.Name = "txtOriginalPrice";
         this.txtOriginalPrice.ReadOnly = true;
         this.txtOriginalPrice.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtOriginalPrice.Size = new System.Drawing.Size(81, 20);
         this.txtOriginalPrice.TabIndex = 25;
         this.txtOriginalPrice.TabStop = false;
         this.txtOriginalPrice.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         // 
         // _txtValues_0
         // 
         this._txtValues_0.AcceptsReturn = true;
         this._txtValues_0.AllowDrop = true;
         this._txtValues_0.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtValues_0.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtValues_0.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this._txtValues_0.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtValues_0.Location = new System.Drawing.Point(328, 403);
         this._txtValues_0.MaxLength = 0;
         this._txtValues_0.Name = "_txtValues_0";
         this._txtValues_0.ReadOnly = true;
         this._txtValues_0.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtValues_0.Size = new System.Drawing.Size(81, 20);
         this._txtValues_0.TabIndex = 4;
         this._txtValues_0.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this._txtValues_0.Enter += new System.EventHandler(this.txtValues_Enter);
         this._txtValues_0.KeyPress += new Mobilize.Web.KeyPressEventHandler(this.txtValues_KeyPress);
         this._txtValues_0.TextChanged += new System.EventHandler(this.txtValues_TextChanged);
         // 
         // txtQuantityPerUnit
         // 
         this.txtQuantityPerUnit.AcceptsReturn = true;
         this.txtQuantityPerUnit.AllowDrop = true;
         this.txtQuantityPerUnit.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtQuantityPerUnit.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtQuantityPerUnit.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtQuantityPerUnit.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtQuantityPerUnit.Location = new System.Drawing.Point(328, 374);
         this.txtQuantityPerUnit.MaxLength = 0;
         this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
         this.txtQuantityPerUnit.ReadOnly = true;
         this.txtQuantityPerUnit.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtQuantityPerUnit.Size = new System.Drawing.Size(81, 20);
         this.txtQuantityPerUnit.TabIndex = 21;
         this.txtQuantityPerUnit.TabStop = false;
         this.txtQuantityPerUnit.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         // 
         // txtProductName
         // 
         this.txtProductName.AcceptsReturn = true;
         this.txtProductName.AllowDrop = true;
         this.txtProductName.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtProductName.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtProductName.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtProductName.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtProductName.Location = new System.Drawing.Point(96, 344);
         this.txtProductName.MaxLength = 0;
         this.txtProductName.Name = "txtProductName";
         this.txtProductName.ReadOnly = true;
         this.txtProductName.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtProductName.Size = new System.Drawing.Size(145, 20);
         this.txtProductName.TabIndex = 20;
         this.txtProductName.TabStop = false;
         // 
         // txtUnit
         // 
         this.txtUnit.AcceptsReturn = true;
         this.txtUnit.AllowDrop = true;
         this.txtUnit.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtUnit.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtUnit.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtUnit.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtUnit.Location = new System.Drawing.Point(328, 344);
         this.txtUnit.MaxLength = 0;
         this.txtUnit.Name = "txtUnit";
         this.txtUnit.ReadOnly = true;
         this.txtUnit.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtUnit.Size = new System.Drawing.Size(81, 20);
         this.txtUnit.TabIndex = 19;
         this.txtUnit.TabStop = false;
         // 
         // _txtValues_1
         // 
         this._txtValues_1.AcceptsReturn = true;
         this._txtValues_1.AllowDrop = true;
         this._txtValues_1.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtValues_1.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtValues_1.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this._txtValues_1.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtValues_1.Location = new System.Drawing.Point(328, 432);
         this._txtValues_1.MaxLength = 0;
         this._txtValues_1.Name = "_txtValues_1";
         this._txtValues_1.ReadOnly = true;
         this._txtValues_1.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._txtValues_1.Size = new System.Drawing.Size(81, 20);
         this._txtValues_1.TabIndex = 5;
         this._txtValues_1.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this._txtValues_1.Enter += new System.EventHandler(this.txtValues_Enter);
         this._txtValues_1.KeyPress += new Mobilize.Web.KeyPressEventHandler(this.txtValues_KeyPress);
         this._txtValues_1.TextChanged += new System.EventHandler(this.txtValues_TextChanged);
         // 
         // txtOriginalQuantity
         // 
         this.txtOriginalQuantity.AcceptsReturn = true;
         this.txtOriginalQuantity.AllowDrop = true;
         this.txtOriginalQuantity.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtOriginalQuantity.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtOriginalQuantity.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtOriginalQuantity.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtOriginalQuantity.Location = new System.Drawing.Point(96, 432);
         this.txtOriginalQuantity.MaxLength = 0;
         this.txtOriginalQuantity.Name = "txtOriginalQuantity";
         this.txtOriginalQuantity.ReadOnly = true;
         this.txtOriginalQuantity.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtOriginalQuantity.Size = new System.Drawing.Size(81, 20);
         this.txtOriginalQuantity.TabIndex = 14;
         this.txtOriginalQuantity.TabStop = false;
         this.txtOriginalQuantity.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         // 
         // Frame3
         // 
         this.Frame3.AllowDrop = true;
         this.Frame3.BackColor = Mobilize.Web.SystemColors.Control;
         this.Frame3.Controls.Add(this.lvStocks);
         this.Frame3.Enabled = true;
         this.Frame3.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Frame3.Location = new System.Drawing.Point(8, 200);
         this.Frame3.Name = "Frame3";
         this.Frame3.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Frame3.Size = new System.Drawing.Size(409, 137);
         this.Frame3.TabIndex = 13;
         this.Frame3.Visible = true;
         // 
         // lvStocks
         // 
         this.lvStocks.AllowDrop = true;
         this.lvStocks.BackColor = Mobilize.Web.SystemColors.Window;
         this.lvStocks.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.lvStocks.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.lvStocks.FullRowSelect = true;
         this.lvStocks.GridLines = true;
         this.lvStocks.HideSelection = false;
         this.lvStocks.Properties().HotTracking = true;
         this.lvStocks.LabelEdit = false;
         this.lvStocks.Location = new System.Drawing.Point(8, 16);
         this.lvStocks.MultiSelect = false;
         this.lvStocks.Name = "lvStocks";
         this.lvStocks.Size = new System.Drawing.Size(393, 113);
         this.lvStocks.TabIndex = 3;
         this.lvStocks.View = Mobilize.Web.ListViewMode.Details;
         this.lvStocks.Columns.Add(this.lvStocks_ColumnHeader_1_);
         this.lvStocks.Columns.Add(this.lvStocks_ColumnHeader_2_);
         this.lvStocks.Columns.Add(this.lvStocks_ColumnHeader_3_);
         this.lvStocks.Columns.Add(this.lvStocks_ColumnHeader_4_);
         this.lvStocks.Columns.Add(this.lvStocks_ColumnHeader_5_);
         this.lvStocks.Columns.Add(this.lvStocks_ColumnHeader_6_);
         this.lvStocks.Columns.Add(this.lvStocks_ColumnHeader_7_);
         this.lvStocks.Columns.Add(this.lvStocks_ColumnHeader_8_);
         // 
         // lvStocks_ColumnHeader_1_
         // 
         this.lvStocks_ColumnHeader_1_.Text = "Stock ID";
         this.lvStocks_ColumnHeader_1_.Width = 97;
         // 
         // lvStocks_ColumnHeader_2_
         // 
         this.lvStocks_ColumnHeader_2_.Text = "Current Stock";
         this.lvStocks_ColumnHeader_2_.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this.lvStocks_ColumnHeader_2_.Width = 97;
         // 
         // lvStocks_ColumnHeader_3_
         // 
         this.lvStocks_ColumnHeader_3_.Text = "Initial Stock";
         this.lvStocks_ColumnHeader_3_.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this.lvStocks_ColumnHeader_3_.Width = 97;
         // 
         // lvStocks_ColumnHeader_4_
         // 
         this.lvStocks_ColumnHeader_4_.Text = "Price";
         this.lvStocks_ColumnHeader_4_.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this.lvStocks_ColumnHeader_4_.Width = 97;
         // 
         // lvStocks_ColumnHeader_5_
         // 
         this.lvStocks_ColumnHeader_5_.Text = "Stock Price";
         this.lvStocks_ColumnHeader_5_.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this.lvStocks_ColumnHeader_5_.Width = 97;
         // 
         // lvStocks_ColumnHeader_6_
         // 
         this.lvStocks_ColumnHeader_6_.Text = "Created";
         this.lvStocks_ColumnHeader_6_.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this.lvStocks_ColumnHeader_6_.Width = 97;
         // 
         // lvStocks_ColumnHeader_7_
         // 
         this.lvStocks_ColumnHeader_7_.Text = "Modified";
         this.lvStocks_ColumnHeader_7_.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this.lvStocks_ColumnHeader_7_.Width = 97;
         // 
         // lvStocks_ColumnHeader_8_
         // 
         this.lvStocks_ColumnHeader_8_.Text = "User";
         this.lvStocks_ColumnHeader_8_.Width = 97;
         // 
         // Frame1
         // 
         this.Frame1.AllowDrop = true;
         this.Frame1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Frame1.Controls.Add(this.txtCode);
         this.Frame1.Controls.Add(this.txtName);
         this.Frame1.Controls.Add(this.cmdProducts);
         this.Frame1.Controls.Add(this.Label5);
         this.Frame1.Controls.Add(this.Label4);
         this.Frame1.Enabled = true;
         this.Frame1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Frame1.Location = new System.Drawing.Point(8, 32);
         this.Frame1.Name = "Frame1";
         this.Frame1.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Frame1.Size = new System.Drawing.Size(409, 65);
         this.Frame1.TabIndex = 9;
         this.Frame1.Text = "Search product ";
         this.Frame1.Visible = true;
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
         this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
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
         // cmdProducts
         // 
         this.cmdProducts.AllowDrop = true;
         this.cmdProducts.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdProducts.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdProducts.Location = new System.Drawing.Point(360, 16);
         this.cmdProducts.Name = "cmdProducts";
         this.cmdProducts.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdProducts.Size = new System.Drawing.Size(25, 21);
         this.cmdProducts.TabIndex = 10;
         this.cmdProducts.TabStop = false;
         this.cmdProducts.Text = "...";
         this.cmdProducts.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdProducts.UseVisualStyleBackColor = false;
         this.cmdProducts.Click += new System.EventHandler(this.cmdProducts_Click);
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
         this.Label5.TabIndex = 12;
         this.Label5.Text = "Code";
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
         this.Label4.TabIndex = 11;
         this.Label4.Text = "Name";
         // 
         // cmdClose
         // 
         this.cmdClose.AllowDrop = true;
         this.cmdClose.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdClose.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdClose.Location = new System.Drawing.Point(344, 504);
         this.cmdClose.Name = "cmdClose";
         this.cmdClose.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdClose.Size = new System.Drawing.Size(73, 25);
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
         this.cmdSave.Location = new System.Drawing.Point(264, 504);
         this.cmdSave.Name = "cmdSave";
         this.cmdSave.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdSave.Size = new System.Drawing.Size(73, 25);
         this.cmdSave.TabIndex = 6;
         this.cmdSave.Text = "&Save";
         this.cmdSave.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdSave.UseVisualStyleBackColor = false;
         this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
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
         this.lvProducts.Size = new System.Drawing.Size(409, 97);
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
         this.lvProducts_ColumnHeader_6_.Text = "Quantity per Unit";
         this.lvProducts_ColumnHeader_6_.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this.lvProducts_ColumnHeader_6_.Width = 97;
         // 
         // lvProducts_ColumnHeader_7_
         // 
         this.lvProducts_ColumnHeader_7_.Text = "Unit";
         this.lvProducts_ColumnHeader_7_.Width = 97;
         // 
         // Label14
         // 
         this.Label14.AllowDrop = true;
         this.Label14.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label14.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label14.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label14.Location = new System.Drawing.Point(216, 472);
         this.Label14.Name = "Label14";
         this.Label14.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label14.Size = new System.Drawing.Size(89, 17);
         this.Label14.TabIndex = 32;
         this.Label14.Text = "Adjusted quantity";
         // 
         // lblNewQuantity
         // 
         this.lblNewQuantity.AllowDrop = true;
         this.lblNewQuantity.BackColor = Mobilize.Web.SystemColors.Control;
         this.lblNewQuantity.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblNewQuantity.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.lblNewQuantity.Location = new System.Drawing.Point(312, 472);
         this.lblNewQuantity.Name = "lblNewQuantity";
         this.lblNewQuantity.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblNewQuantity.Size = new System.Drawing.Size(89, 17);
         this.lblNewQuantity.TabIndex = 31;
         // 
         // Label12
         // 
         this.Label12.AllowDrop = true;
         this.Label12.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label12.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label12.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label12.Location = new System.Drawing.Point(16, 472);
         this.Label12.Name = "Label12";
         this.Label12.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label12.Size = new System.Drawing.Size(89, 17);
         this.Label12.TabIndex = 30;
         this.Label12.Text = "Stock quantity";
         // 
         // lblCurrentQuantity
         // 
         this.lblCurrentQuantity.AllowDrop = true;
         this.lblCurrentQuantity.BackColor = Mobilize.Web.SystemColors.Control;
         this.lblCurrentQuantity.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblCurrentQuantity.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.lblCurrentQuantity.Location = new System.Drawing.Point(112, 472);
         this.lblCurrentQuantity.Name = "lblCurrentQuantity";
         this.lblCurrentQuantity.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblCurrentQuantity.Size = new System.Drawing.Size(89, 17);
         this.lblCurrentQuantity.TabIndex = 29;
         // 
         // Label11
         // 
         this.Label11.AllowDrop = true;
         this.Label11.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label11.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label11.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label11.Location = new System.Drawing.Point(16, 376);
         this.Label11.Name = "Label11";
         this.Label11.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label11.Size = new System.Drawing.Size(65, 17);
         this.Label11.TabIndex = 27;
         this.Label11.Text = "Stock ID:";
         // 
         // Label10
         // 
         this.Label10.AllowDrop = true;
         this.Label10.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label10.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label10.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label10.Location = new System.Drawing.Point(216, 376);
         this.Label10.Name = "Label10";
         this.Label10.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label10.Size = new System.Drawing.Size(73, 17);
         this.Label10.TabIndex = 24;
         this.Label10.Text = "Quantity";
         // 
         // Label8
         // 
         this.Label8.AllowDrop = true;
         this.Label8.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label8.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label8.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label8.Location = new System.Drawing.Point(16, 344);
         this.Label8.Name = "Label8";
         this.Label8.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label8.Size = new System.Drawing.Size(89, 17);
         this.Label8.TabIndex = 23;
         this.Label8.Text = "Product";
         // 
         // Label9
         // 
         this.Label9.AllowDrop = true;
         this.Label9.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label9.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label9.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label9.Location = new System.Drawing.Point(272, 344);
         this.Label9.Name = "Label9";
         this.Label9.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label9.Size = new System.Drawing.Size(41, 17);
         this.Label9.TabIndex = 22;
         this.Label9.Text = "Unit";
         // 
         // Label7
         // 
         this.Label7.AllowDrop = true;
         this.Label7.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label7.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label7.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label7.Location = new System.Drawing.Point(216, 435);
         this.Label7.Name = "Label7";
         this.Label7.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label7.Size = new System.Drawing.Size(89, 17);
         this.Label7.TabIndex = 18;
         this.Label7.Text = "New Quantity";
         // 
         // Label6
         // 
         this.Label6.AllowDrop = true;
         this.Label6.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label6.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label6.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label6.Location = new System.Drawing.Point(216, 406);
         this.Label6.Name = "Label6";
         this.Label6.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label6.Size = new System.Drawing.Size(73, 17);
         this.Label6.TabIndex = 17;
         this.Label6.Text = "New Price";
         // 
         // Label2
         // 
         this.Label2.AllowDrop = true;
         this.Label2.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label2.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label2.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label2.Location = new System.Drawing.Point(16, 435);
         this.Label2.Name = "Label2";
         this.Label2.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label2.Size = new System.Drawing.Size(81, 17);
         this.Label2.TabIndex = 16;
         this.Label2.Text = "Quantity";
         // 
         // Label1
         // 
         this.Label1.AllowDrop = true;
         this.Label1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label1.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label1.Location = new System.Drawing.Point(16, 406);
         this.Label1.Name = "Label1";
         this.Label1.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label1.Size = new System.Drawing.Size(73, 17);
         this.Label1.TabIndex = 15;
         this.Label1.Text = "Old Price";
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
         this.Label3.TabIndex = 8;
         this.Label3.Text = "Select a product first";
         // 
         // frmAdjustStockManual
         // 
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.AutoScroll = true;
         this.BackColor = Mobilize.Web.SystemColors.Control;
         this.Properties().ClientSize = new System.Drawing.Size(426, 563);
         this.Controls.Add(this.sbStatusBar);
         this.Controls.Add(this.txtStockID);
         this.Controls.Add(this.txtOriginalPrice);
         this.Controls.Add(this._txtValues_0);
         this.Controls.Add(this.txtQuantityPerUnit);
         this.Controls.Add(this.txtProductName);
         this.Controls.Add(this.txtUnit);
         this.Controls.Add(this._txtValues_1);
         this.Controls.Add(this.txtOriginalQuantity);
         this.Controls.Add(this.Frame3);
         this.Controls.Add(this.Frame1);
         this.Controls.Add(this.cmdClose);
         this.Controls.Add(this.cmdSave);
         this.Controls.Add(this.lvProducts);
         this.Controls.Add(this.Label14);
         this.Controls.Add(this.lblNewQuantity);
         this.Controls.Add(this.Label12);
         this.Controls.Add(this.lblCurrentQuantity);
         this.Controls.Add(this.Label11);
         this.Controls.Add(this.Label10);
         this.Controls.Add(this.Label8);
         this.Controls.Add(this.Label9);
         this.Controls.Add(this.Label7);
         this.Controls.Add(this.Label6);
         this.Controls.Add(this.Label2);
         this.Controls.Add(this.Label1);
         this.Controls.Add(this.Label3);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedSingle;
         this.Properties().Location = new System.Drawing.Point(3, 25);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmAdjustStockManual";
         this.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.Manual;
         this.Text = "Inventory Adjust";
         this.Closed += new System.EventHandler(this.Form_Closed);
         this.FormClosing += new Mobilize.Web.FormClosingEventHandler(this.Form_FormClosing);this.lvStocks.ItemClick += new Mobilize.Web.ListViewItemClickEventHandler(this.lvStocks_ItemClick);
         this.listViewHelper1.SetCorrectEventsBehavior(this.lvStocks, true);this.lvProducts.ItemClick += new Mobilize.Web.ListViewItemClickEventHandler(this.lvProducts_ItemClick);
         this.listViewHelper1.SetCorrectEventsBehavior(this.lvProducts, true);
         this.sbStatusBar.ResumeLayout(false);
         this.Frame3.ResumeLayout(false);
         this.lvStocks.ResumeLayout(false);
         this.Frame1.ResumeLayout(false);
         this.lvProducts.ResumeLayout(false);
         this.ResumeLayout(false);

#line hidden
this.Controls.DesignTime=false;
#line 937
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
      	this.txtValues = new Mobilize.Web.TextBox[2];
      	this.txtValues[0] = _txtValues_0;
      	this.txtValues[1] = _txtValues_1;
      }
      #endregion

   }
}
#pragma warning restore
