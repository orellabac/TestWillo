#pragma warning disable
#line 1 "frmUsersManage.Designer.cs"
#pragma warning disable
#line 1 "frmUsersManage.Designer.cs"
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmUsersManage
   {

      [Intercepted]

      #region "Upgrade Support "
      private static frmUsersManage m_vb6FormDefInstance 
#line 13
                                                         { 
#line 13
                                                           get                                                              
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (SKS.frmUsersManage)catalog.frmUsersManage.m_vb6FormDefInstance;} 
#line 13

#line 13
                                                                set                                                                   
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmUsersManage.m_vb6FormDefInstance = value;} 
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
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (bool)catalog.frmUsersManage.m_InitializingDefInstance;} 
#line 16

#line 16
                                                           set                                                              
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmUsersManage.m_InitializingDefInstance = value;} 
#line 16
                                                                }

#line 17

      [Intercepted]
      public static frmUsersManage DefInstance
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

      public static frmUsersManage CreateInstance()
      {
      	frmUsersManage theInstance = new frmUsersManage();
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
private Mobilize.Web.ListViewColumnHeader lstAccounts_ColumnHeader_1__k__BackingField;
#line 59


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lstAccounts_ColumnHeader_1_ 
#line 59
                                                                           { 
#line 59
                                                                             get                                                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lstAccounts_ColumnHeader_1_)<=0){this.lstAccounts_ColumnHeader_1__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,3);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lstAccounts_ColumnHeader_1_;;} return this.lstAccounts_ColumnHeader_1__k__BackingField; } 
#line 59

#line 59
                                                                                  set                                                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,3,this.lstAccounts_ColumnHeader_1__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lstAccounts_ColumnHeader_1_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lstAccounts_ColumnHeader_1_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lstAccounts_ColumnHeader_1__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 59
                                                                                       }

#line 60

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lstAccounts_ColumnHeader_2__k__BackingField;
#line 62


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lstAccounts_ColumnHeader_2_ 
#line 62
                                                                           { 
#line 62
                                                                             get                                                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lstAccounts_ColumnHeader_2_)<=0){this.lstAccounts_ColumnHeader_2__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,4);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lstAccounts_ColumnHeader_2_;;} return this.lstAccounts_ColumnHeader_2__k__BackingField; } 
#line 62

#line 62
                                                                                  set                                                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,4,this.lstAccounts_ColumnHeader_2__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lstAccounts_ColumnHeader_2_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lstAccounts_ColumnHeader_2_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lstAccounts_ColumnHeader_2__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 62
                                                                                       }

#line 63

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListViewColumnHeader lstAccounts_ColumnHeader_3__k__BackingField;
#line 65


      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lstAccounts_ColumnHeader_3_ 
#line 65
                                                                           { 
#line 65
                                                                             get                                                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lstAccounts_ColumnHeader_3_)<=0){this.lstAccounts_ColumnHeader_3__k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,5);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lstAccounts_ColumnHeader_3_;;} return this.lstAccounts_ColumnHeader_3__k__BackingField; } 
#line 65

#line 65
                                                                                  set                                                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListViewColumnHeader>(this,_Mobilize_References,5,this.lstAccounts_ColumnHeader_3__k__BackingField,(Mobilize.Web.ListViewColumnHeader)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lstAccounts_ColumnHeader_3_;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lstAccounts_ColumnHeader_3_;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lstAccounts_ColumnHeader_3__k__BackingField=(Mobilize.Web.ListViewColumnHeader)value;} 
#line 65
                                                                                       }

#line 66

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListView lstAccounts_k__BackingField;
#line 68


      [Intercepted]
      public Mobilize.Web.ListView lstAccounts 
#line 68
                                               { 
#line 68
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lstAccounts)<=0){this.lstAccounts_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListView>(this,_Mobilize_References,6);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lstAccounts;;} return this.lstAccounts_k__BackingField; } 
#line 68

#line 68
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListView>(this,_Mobilize_References,6,this.lstAccounts_k__BackingField,(Mobilize.Web.ListView)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lstAccounts;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lstAccounts;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lstAccounts_k__BackingField=(Mobilize.Web.ListView)value;} 
#line 68
                                                           }

#line 69

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdClear_k__BackingField;
#line 71


      [Intercepted]
      public Mobilize.Web.Button cmdClear 
#line 71
                                          { 
#line 71
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdClear)<=0){this.cmdClear_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,7);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdClear;;} return this.cmdClear_k__BackingField; } 
#line 71

#line 71
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,7,this.cmdClear_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdClear;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdClear;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdClear_k__BackingField=(Mobilize.Web.Button)value;} 
#line 71
                                                      }

#line 72

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdSave_k__BackingField;
#line 74


      [Intercepted]
      public Mobilize.Web.Button cmdSave 
#line 74
                                         { 
#line 74
                                           get                                              
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdSave)<=0){this.cmdSave_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,8);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdSave;;} return this.cmdSave_k__BackingField; } 
#line 74

#line 74
                                                set                                                   
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,8,this.cmdSave_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdSave;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdSave;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdSave_k__BackingField=(Mobilize.Web.Button)value;} 
#line 74
                                                     }

#line 75

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.PictureBox ctrlLiner1_k__BackingField;
#line 77


      [Intercepted]
      public Mobilize.Web.PictureBox ctrlLiner1 
#line 77
                                                { 
#line 77
                                                  get                                                     
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_ctrlLiner1)<=0){this.ctrlLiner1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.PictureBox>(this,_Mobilize_References,9);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_ctrlLiner1;;} return this.ctrlLiner1_k__BackingField; } 
#line 77

#line 77
                                                       set                                                          
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.PictureBox>(this,_Mobilize_References,9,this.ctrlLiner1_k__BackingField,(Mobilize.Web.PictureBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_ctrlLiner1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_ctrlLiner1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.ctrlLiner1_k__BackingField=(Mobilize.Web.PictureBox)value;} 
#line 77
                                                            }

#line 78

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtFullname_k__BackingField;
#line 80


      [Intercepted]
      public Mobilize.Web.TextBox txtFullname 
#line 80
                                              { 
#line 80
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtFullname)<=0){this.txtFullname_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,10);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtFullname;;} return this.txtFullname_k__BackingField; } 
#line 80

#line 80
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,10,this.txtFullname_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtFullname;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtFullname;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtFullname_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 80
                                                          }

#line 81

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtPassword_k__BackingField;
#line 83


      [Intercepted]
      public Mobilize.Web.TextBox txtPassword 
#line 83
                                              { 
#line 83
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtPassword)<=0){this.txtPassword_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,11);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtPassword;;} return this.txtPassword_k__BackingField; } 
#line 83

#line 83
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,11,this.txtPassword_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtPassword;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtPassword;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtPassword_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 83
                                                          }

#line 84

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtUsername_k__BackingField;
#line 86


      [Intercepted]
      public Mobilize.Web.TextBox txtUsername 
#line 86
                                              { 
#line 86
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtUsername)<=0){this.txtUsername_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,12);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtUsername;;} return this.txtUsername_k__BackingField; } 
#line 86

#line 86
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,12,this.txtUsername_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtUsername;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtUsername;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtUsername_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 86
                                                          }

#line 87

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ComboBox cboLevel_k__BackingField;
#line 89


      [Intercepted]
      public Mobilize.Web.ComboBox cboLevel 
#line 89
                                            { 
#line 89
                                              get                                                 
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cboLevel)<=0){this.cboLevel_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ComboBox>(this,_Mobilize_References,13);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cboLevel;;} return this.cboLevel_k__BackingField; } 
#line 89

#line 89
                                                   set                                                      
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ComboBox>(this,_Mobilize_References,13,this.cboLevel_k__BackingField,(Mobilize.Web.ComboBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cboLevel;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cboLevel;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cboLevel_k__BackingField=(Mobilize.Web.ComboBox)value;} 
#line 89
                                                        }

#line 90

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label _Label1_2_k__BackingField;
#line 92


      [Intercepted]
      private Mobilize.Web.Label _Label1_2 
#line 92
                                           { 
#line 92
                                             get                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__Label1_2)<=0){this._Label1_2_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,14);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__Label1_2;;} return this._Label1_2_k__BackingField; } 
#line 92

#line 92
                                                  set                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,14,this._Label1_2_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__Label1_2;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__Label1_2;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._Label1_2_k__BackingField=(Mobilize.Web.Label)value;} 
#line 92
                                                       }

#line 93

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label _Label1_0_k__BackingField;
#line 95


      [Intercepted]
      private Mobilize.Web.Label _Label1_0 
#line 95
                                           { 
#line 95
                                             get                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__Label1_0)<=0){this._Label1_0_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,15);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__Label1_0;;} return this._Label1_0_k__BackingField; } 
#line 95

#line 95
                                                  set                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,15,this._Label1_0_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__Label1_0;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__Label1_0;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._Label1_0_k__BackingField=(Mobilize.Web.Label)value;} 
#line 95
                                                       }

#line 96

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label _Label1_1_k__BackingField;
#line 98


      [Intercepted]
      private Mobilize.Web.Label _Label1_1 
#line 98
                                           { 
#line 98
                                             get                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__Label1_1)<=0){this._Label1_1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,16);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__Label1_1;;} return this._Label1_1_k__BackingField; } 
#line 98

#line 98
                                                  set                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,16,this._Label1_1_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__Label1_1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__Label1_1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._Label1_1_k__BackingField=(Mobilize.Web.Label)value;} 
#line 98
                                                       }

#line 99

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label _Label1_3_k__BackingField;
#line 101


      [Intercepted]
      private Mobilize.Web.Label _Label1_3 
#line 101
                                           { 
#line 101
                                             get                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__Label1_3)<=0){this._Label1_3_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,17);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__Label1_3;;} return this._Label1_3_k__BackingField; } 
#line 101

#line 101
                                                  set                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,17,this._Label1_3_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__Label1_3;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__Label1_3;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._Label1_3_k__BackingField=(Mobilize.Web.Label)value;} 
#line 101
                                                       }

#line 102

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label lblId_k__BackingField;
#line 104


      [Intercepted]
      public Mobilize.Web.Label lblId 
#line 104
                                      { 
#line 104
                                        get                                           
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lblId)<=0){this.lblId_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,18);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lblId;;} return this.lblId_k__BackingField; } 
#line 104

#line 104
                                             set                                                
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,18,this.lblId_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lblId;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lblId;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lblId_k__BackingField=(Mobilize.Web.Label)value;} 
#line 104
                                                  }

#line 105

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.GroupBox Frame1_k__BackingField;
#line 107


      [Intercepted]
      public Mobilize.Web.GroupBox Frame1 
#line 107
                                          { 
#line 107
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Frame1)<=0){this.Frame1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.GroupBox>(this,_Mobilize_References,19);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Frame1;;} return this.Frame1_k__BackingField; } 
#line 107

#line 107
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.GroupBox>(this,_Mobilize_References,19,this.Frame1_k__BackingField,(Mobilize.Web.GroupBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Frame1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Frame1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Frame1_k__BackingField=(Mobilize.Web.GroupBox)value;} 
#line 107
                                                      }

#line 108

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdClose_k__BackingField;
#line 110


      [Intercepted]
      public Mobilize.Web.Button cmdClose 
#line 110
                                          { 
#line 110
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdClose)<=0){this.cmdClose_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,20);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdClose;;} return this.cmdClose_k__BackingField; } 
#line 110

#line 110
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,20,this.cmdClose_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdClose;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdClose;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdClose_k__BackingField=(Mobilize.Web.Button)value;} 
#line 110
                                                      }

#line 111

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdEdit_k__BackingField;
#line 113


      [Intercepted]
      public Mobilize.Web.Button cmdEdit 
#line 113
                                         { 
#line 113
                                           get                                              
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdEdit)<=0){this.cmdEdit_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,21);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdEdit;;} return this.cmdEdit_k__BackingField; } 
#line 113

#line 113
                                                set                                                   
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,21,this.cmdEdit_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdEdit;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdEdit;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdEdit_k__BackingField=(Mobilize.Web.Button)value;} 
#line 113
                                                     }

#line 114

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdDelete_k__BackingField;
#line 116


      [Intercepted]
      public Mobilize.Web.Button cmdDelete 
#line 116
                                           { 
#line 116
                                             get                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdDelete)<=0){this.cmdDelete_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,22);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdDelete;;} return this.cmdDelete_k__BackingField; } 
#line 116

#line 116
                                                  set                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,22,this.cmdDelete_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdDelete;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdDelete;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdDelete_k__BackingField=(Mobilize.Web.Button)value;} 
#line 116
                                                       }

#line 117

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label _Label1_4_k__BackingField;
#line 119


      [Intercepted]
      private Mobilize.Web.Label _Label1_4 
#line 119
                                           { 
#line 119
                                             get                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__Label1_4)<=0){this._Label1_4_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,23);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__Label1_4;;} return this._Label1_4_k__BackingField; } 
#line 119

#line 119
                                                  set                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,23,this._Label1_4_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__Label1_4;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__Label1_4;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._Label1_4_k__BackingField=(Mobilize.Web.Label)value;} 
#line 119
                                                       }

#line 120

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label19_k__BackingField;
#line 122


      [Intercepted]
      public Mobilize.Web.Label Label19 
#line 122
                                        { 
#line 122
                                          get                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label19)<=0){this.Label19_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,24);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label19;;} return this.Label19_k__BackingField; } 
#line 122

#line 122
                                               set                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,24,this.Label19_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label19;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label19;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label19_k__BackingField=(Mobilize.Web.Label)value;} 
#line 122
                                                    }

#line 123

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label4_k__BackingField;
#line 125


      [Intercepted]
      public Mobilize.Web.Label Label4 
#line 125
                                       { 
#line 125
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label4)<=0){this.Label4_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,25);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label4;;} return this.Label4_k__BackingField; } 
#line 125

#line 125
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,25,this.Label4_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label4;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label4;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label4_k__BackingField=(Mobilize.Web.Label)value;} 
#line 125
                                                   }

#line 126

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.PictureBox Image1_k__BackingField;
#line 128


      [Intercepted]
      public Mobilize.Web.PictureBox Image1 
#line 128
                                            { 
#line 128
                                              get                                                 
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Image1)<=0){this.Image1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.PictureBox>(this,_Mobilize_References,26);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Image1;;} return this.Image1_k__BackingField; } 
#line 128

#line 128
                                                   set                                                      
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.PictureBox>(this,_Mobilize_References,26,this.Image1_k__BackingField,(Mobilize.Web.PictureBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Image1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Image1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Image1_k__BackingField=(Mobilize.Web.PictureBox)value;} 
#line 128
                                                        }

#line 129

#line hidden
                                                       
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label[] Label1_k__BackingField;
#line 131
                                                       

      [Intercepted]
      public Mobilize.Web.Label[] Label1 
#line 131
                                         { 
#line 131
                                           get                                              
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label1)<=0){this.Label1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<Mobilize.Web.Label[]>(this,_Mobilize_References,27);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label1;}return this.Label1_k__BackingField;} 
#line 131

#line 131
                                                set                                                   
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Mobilize.Web.Label[] >(this,_Mobilize_References,27,this.Label1_k__BackingField,(Mobilize.Web.Label[])value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label1_k__BackingField=(Mobilize.Web.Label[])value;} 
#line 131
                                                     } 
#line 132

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ListView listViewHelper1_k__BackingField;
#line 134


      [Intercepted]
      private Mobilize.Web.ListView listViewHelper1 
#line 134
                                                    { 
#line 134
                                                      get                                                         
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_listViewHelper1)<=0){this.listViewHelper1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ListView>(this,_Mobilize_References,28);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_listViewHelper1;;} return this.listViewHelper1_k__BackingField; } 
#line 134

#line 134
                                                           set                                                              
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ListView>(this,_Mobilize_References,28,this.listViewHelper1_k__BackingField,(Mobilize.Web.ListView)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_listViewHelper1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_listViewHelper1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.listViewHelper1_k__BackingField=(Mobilize.Web.ListView)value;} 
#line 134
                                                                }

#line 135
      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.

      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {

#line hidden
this.Controls.DesignTime=true;
#line 143
      	this.components = new System.ComponentModel.Container();
      	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersManage));
      	this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
      	this.lstAccounts = new Mobilize.Web.ListView();
      	this.lstAccounts_ColumnHeader_1_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lstAccounts_ColumnHeader_2_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lstAccounts_ColumnHeader_3_ = new Mobilize.Web.ListViewColumnHeader();
      	this.cmdClear = new Mobilize.Web.Button();
      	this.cmdSave = new Mobilize.Web.Button();
      	this.ctrlLiner1 = new Mobilize.Web.PictureBox();
      	this.Frame1 = new Mobilize.Web.GroupBox();
      	this.txtFullname = new Mobilize.Web.TextBox();
      	this.txtPassword = new Mobilize.Web.TextBox();
      	this.txtUsername = new Mobilize.Web.TextBox();
      	this.cboLevel = new Mobilize.Web.ComboBox();
      	this._Label1_2 = new Mobilize.Web.Label();
      	this._Label1_0 = new Mobilize.Web.Label();
      	this._Label1_1 = new Mobilize.Web.Label();
      	this._Label1_3 = new Mobilize.Web.Label();
      	this.lblId = new Mobilize.Web.Label();
      	this.cmdClose = new Mobilize.Web.Button();
      	this.cmdEdit = new Mobilize.Web.Button();
      	this.cmdDelete = new Mobilize.Web.Button();
      	this._Label1_4 = new Mobilize.Web.Label();
      	this.Label19 = new Mobilize.Web.Label();
      	this.Label4 = new Mobilize.Web.Label();
      	this.Image1 = new Mobilize.Web.PictureBox();
      	this.lstAccounts.SuspendLayout();
      	this.Frame1.SuspendLayout();
      	this.SuspendLayout();
      	this.listViewHelper1 = new Mobilize.Web.ListView(this.components);
      	// 
      	// lstAccounts
      	// 
      	this.lstAccounts.AllowDrop = true;
      	this.lstAccounts.BackColor = Mobilize.Web.SystemColors.Window;
         this.lstAccounts.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.lstAccounts.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.lstAccounts.FullRowSelect = true;
         this.lstAccounts.HideSelection = true;
         this.lstAccounts.LabelEdit = true;
         this.lstAccounts.Location = new System.Drawing.Point(0, 264);
         this.lstAccounts.MultiSelect = false;
         this.lstAccounts.Name = "lstAccounts";
         this.lstAccounts.Size = new System.Drawing.Size(337, 113);
         this.lstAccounts.TabIndex = 7;
         this.lstAccounts.View = Mobilize.Web.ListViewMode.Details;
         this.lstAccounts.Columns.Add(this.lstAccounts_ColumnHeader_1_);
         this.lstAccounts.Columns.Add(this.lstAccounts_ColumnHeader_2_);
         this.lstAccounts.Columns.Add(this.lstAccounts_ColumnHeader_3_);
         this.lstAccounts.DoubleClick += new System.EventHandler(this.lstAccounts_DoubleClick);
         // 
         // lstAccounts_ColumnHeader_1_
         // 
         this.lstAccounts_ColumnHeader_1_.Text = "UserId";
         this.lstAccounts_ColumnHeader_1_.Width = 97;
         // 
         // lstAccounts_ColumnHeader_2_
         // 
         this.lstAccounts_ColumnHeader_2_.Text = "Name";
         this.lstAccounts_ColumnHeader_2_.Width = 97;
         // 
         // lstAccounts_ColumnHeader_3_
         // 
         this.lstAccounts_ColumnHeader_3_.Text = "Level";
         this.lstAccounts_ColumnHeader_3_.Width = 97;
         // 
         // cmdClear
         // 
         this.cmdClear.AllowDrop = true;
         this.cmdClear.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdClear.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdClear.Location = new System.Drawing.Point(168, 232);
         this.cmdClear.Name = "cmdClear";
         this.cmdClear.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdClear.Size = new System.Drawing.Size(81, 25);
         this.cmdClear.TabIndex = 5;
         this.cmdClear.Text = "&New";
         this.cmdClear.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdClear.UseVisualStyleBackColor = false;
         this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
         // 
         // cmdSave
         // 
         this.cmdSave.AllowDrop = true;
         this.cmdSave.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdSave.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdSave.Location = new System.Drawing.Point(80, 232);
         this.cmdSave.Name = "cmdSave";
         this.cmdSave.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdSave.Size = new System.Drawing.Size(81, 25);
         this.cmdSave.TabIndex = 4;
         this.cmdSave.Text = "&Save";
         this.cmdSave.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdSave.UseVisualStyleBackColor = false;
         this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
         // 
         // ctrlLiner1
         // 
         this.ctrlLiner1.AllowDrop = true;
         this.ctrlLiner1.BackColor = Mobilize.Web.SystemColors.Control;
         this.ctrlLiner1.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.ctrlLiner1.Properties().CausesValidation = true;
         this.ctrlLiner1.Dock = Mobilize.Web.DockStyle.None;
         this.ctrlLiner1.Enabled = true;
         this.ctrlLiner1.Location = new System.Drawing.Point(0, 56);
         this.ctrlLiner1.Name = "ctrlLiner1";
         this.ctrlLiner1.Size = new System.Drawing.Size(313, 2);
         this.ctrlLiner1.SizeMode = Mobilize.Web.PictureBoxSizeMode.Normal;
         this.ctrlLiner1.Properties().TabIndex = 15;
         this.ctrlLiner1.Properties().TabStop = true;
         this.ctrlLiner1.Visible = true;
         // 
         // Frame1
         // 
         this.Frame1.AllowDrop = true;
         this.Frame1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Frame1.Controls.Add(this.txtFullname);
         this.Frame1.Controls.Add(this.txtPassword);
         this.Frame1.Controls.Add(this.txtUsername);
         this.Frame1.Controls.Add(this.cboLevel);
         this.Frame1.Controls.Add(this._Label1_2);
         this.Frame1.Controls.Add(this._Label1_0);
         this.Frame1.Controls.Add(this._Label1_1);
         this.Frame1.Controls.Add(this._Label1_3);
         this.Frame1.Controls.Add(this.lblId);
         this.Frame1.Enabled = true;
         this.Frame1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Frame1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Frame1.Location = new System.Drawing.Point(8, 64);
         this.Frame1.Name = "Frame1";
         this.Frame1.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Frame1.Size = new System.Drawing.Size(329, 153);
         this.Frame1.TabIndex = 10;
         this.Frame1.Text = "User information";
         this.Frame1.Visible = true;
         // 
         // txtFullname
         // 
         this.txtFullname.AcceptsReturn = true;
         this.txtFullname.AllowDrop = true;
         this.txtFullname.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtFullname.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtFullname.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtFullname.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtFullname.Properties().ImeMode = Mobilize.Web.ImeMode.Disable;
         this.txtFullname.Location = new System.Drawing.Point(120, 88);
         this.txtFullname.MaxLength = 50;
         this.txtFullname.Name = "txtFullname";
         this.txtFullname.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtFullname.Size = new System.Drawing.Size(193, 19);
         this.txtFullname.TabIndex = 2;
         this.txtFullname.Enter += new System.EventHandler(this.txtFullname_Enter);
         // 
         // txtPassword
         // 
         this.txtPassword.AcceptsReturn = true;
         this.txtPassword.AllowDrop = true;
         this.txtPassword.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtPassword.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtPassword.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtPassword.Font = new Mobilize.Web.Font("Wingdings", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 2);
         this.txtPassword.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtPassword.Properties().ImeMode = Mobilize.Web.ImeMode.Disable;
         this.txtPassword.Location = new System.Drawing.Point(120, 56);
         this.txtPassword.MaxLength = 50;
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.PasswordChar = (char) 108;
         this.txtPassword.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtPassword.Size = new System.Drawing.Size(193, 19);
         this.txtPassword.TabIndex = 1;
         this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
         // 
         // txtUsername
         // 
         this.txtUsername.AcceptsReturn = true;
         this.txtUsername.AllowDrop = true;
         this.txtUsername.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtUsername.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtUsername.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtUsername.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtUsername.Location = new System.Drawing.Point(120, 24);
         this.txtUsername.MaxLength = 50;
         this.txtUsername.Name = "txtUsername";
         this.txtUsername.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtUsername.Size = new System.Drawing.Size(193, 19);
         this.txtUsername.TabIndex = 0;
         this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
         // 
         // cboLevel
         // 
         this.cboLevel.AllowDrop = true;
         this.cboLevel.BackColor = Mobilize.Web.SystemColors.Window;
         this.cboLevel.CausesValidation = true;
         this.cboLevel.DropDownStyle = Mobilize.Web.ComboBoxStyle.DropDownList;
         this.cboLevel.Enabled = true;
         this.cboLevel.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.cboLevel.IntegralHeight = true;
         this.cboLevel.Location = new System.Drawing.Point(120, 120);
         this.cboLevel.Name = "cboLevel";
         this.cboLevel.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cboLevel.Size = new System.Drawing.Size(193, 21);
         this.cboLevel.Sorted = false;
         this.cboLevel.TabIndex = 3;
         this.cboLevel.TabStop = true;
         this.cboLevel.Visible = true;
         // 
         // _Label1_2
         // 
         this._Label1_2.AllowDrop = true;
         this._Label1_2.AutoSize = true;
         this._Label1_2.BackColor = Mobilize.Web.SystemColors.Control;
         this._Label1_2.BorderStyle = Mobilize.Web.BorderStyle.None;
         this._Label1_2.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this._Label1_2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         this._Label1_2.Location = new System.Drawing.Point(16, 88);
         this._Label1_2.Name = "_Label1_2";
         this._Label1_2.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._Label1_2.Size = new System.Drawing.Size(68, 13);
         this._Label1_2.TabIndex = 16;
         this._Label1_2.Text = "Full name: *";
         // 
         // _Label1_0
         // 
         this._Label1_0.AllowDrop = true;
         this._Label1_0.AutoSize = true;
         this._Label1_0.BackColor = Mobilize.Web.SystemColors.Control;
         this._Label1_0.BorderStyle = Mobilize.Web.BorderStyle.None;
         this._Label1_0.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this._Label1_0.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         this._Label1_0.Location = new System.Drawing.Point(16, 32);
         this._Label1_0.Name = "_Label1_0";
         this._Label1_0.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._Label1_0.Size = new System.Drawing.Size(70, 13);
         this._Label1_0.TabIndex = 14;
         this._Label1_0.Text = "Username: *";
         // 
         // _Label1_1
         // 
         this._Label1_1.AllowDrop = true;
         this._Label1_1.AutoSize = true;
         this._Label1_1.BackColor = Mobilize.Web.SystemColors.Control;
         this._Label1_1.BorderStyle = Mobilize.Web.BorderStyle.None;
         this._Label1_1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this._Label1_1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         this._Label1_1.Location = new System.Drawing.Point(16, 56);
         this._Label1_1.Name = "_Label1_1";
         this._Label1_1.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._Label1_1.Size = new System.Drawing.Size(96, 13);
         this._Label1_1.TabIndex = 13;
         this._Label1_1.Text = "New password: *";
         // 
         // _Label1_3
         // 
         this._Label1_3.AllowDrop = true;
         this._Label1_3.AutoSize = true;
         this._Label1_3.BackColor = Mobilize.Web.SystemColors.Control;
         this._Label1_3.BorderStyle = Mobilize.Web.BorderStyle.None;
         this._Label1_3.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this._Label1_3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         this._Label1_3.Location = new System.Drawing.Point(16, 120);
         this._Label1_3.Name = "_Label1_3";
         this._Label1_3.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._Label1_3.Size = new System.Drawing.Size(71, 13);
         this._Label1_3.TabIndex = 12;
         this._Label1_3.Text = "User level: *";
         // 
         // lblId
         // 
         this.lblId.AllowDrop = true;
         this.lblId.AutoSize = true;
         this.lblId.BackColor = Mobilize.Web.SystemColors.Control;
         this.lblId.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblId.Font = new Mobilize.Web.Font("Tahoma", 8.25f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lblId.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         this.lblId.Location = new System.Drawing.Point(128, 24);
         this.lblId.Name = "lblId";
         this.lblId.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblId.Size = new System.Drawing.Size(3, 13);
         this.lblId.TabIndex = 11;
         // 
         // cmdClose
         // 
         this.cmdClose.AllowDrop = true;
         this.cmdClose.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdClose.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdClose.Location = new System.Drawing.Point(256, 232);
         this.cmdClose.Name = "cmdClose";
         this.cmdClose.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdClose.Size = new System.Drawing.Size(81, 25);
         this.cmdClose.TabIndex = 6;
         this.cmdClose.Text = "&Close";
         this.cmdClose.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdClose.UseVisualStyleBackColor = false;
         this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
         // 
         // cmdEdit
         // 
         this.cmdEdit.AllowDrop = true;
         this.cmdEdit.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdEdit.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdEdit.Location = new System.Drawing.Point(168, 384);
         this.cmdEdit.Name = "cmdEdit";
         this.cmdEdit.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdEdit.Size = new System.Drawing.Size(81, 25);
         this.cmdEdit.TabIndex = 8;
         this.cmdEdit.Text = "&Edit";
         this.cmdEdit.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdEdit.UseVisualStyleBackColor = false;
         this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
         // 
         // cmdDelete
         // 
         this.cmdDelete.AllowDrop = true;
         this.cmdDelete.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdDelete.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdDelete.Location = new System.Drawing.Point(256, 384);
         this.cmdDelete.Name = "cmdDelete";
         this.cmdDelete.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdDelete.Size = new System.Drawing.Size(81, 25);
         this.cmdDelete.TabIndex = 9;
         this.cmdDelete.Text = "&Delete";
         this.cmdDelete.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdDelete.UseVisualStyleBackColor = false;
         this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
         // 
         // _Label1_4
         // 
         this._Label1_4.AllowDrop = true;
         this._Label1_4.AutoSize = true;
         this._Label1_4.BackColor = Mobilize.Web.SystemColors.Control;
         this._Label1_4.BorderStyle = Mobilize.Web.BorderStyle.None;
         this._Label1_4.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this._Label1_4.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         this._Label1_4.Location = new System.Drawing.Point(8, 392);
         this._Label1_4.Name = "_Label1_4";
         this._Label1_4.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this._Label1_4.Size = new System.Drawing.Size(95, 13);
         this._Label1_4.TabIndex = 19;
         this._Label1_4.Text = "* Required fields";
         // 
         // Label19
         // 
         this.Label19.AllowDrop = true;
         this.Label19.AutoSize = true;
         this.Label19.BackColor = System.Drawing.Color.Transparent;
         this.Label19.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label19.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 9.75f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label19.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         this.Label19.Location = new System.Drawing.Point(48, 8);
         this.Label19.Name = "Label19";
         this.Label19.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label19.Size = new System.Drawing.Size(34, 16);
         this.Label19.TabIndex = 18;
         this.Label19.Text = "User";
         this.Label19.TextAlign = Mobilize.Web.ContentAlignment.TopRight;
         // 
         // Label4
         // 
         this.Label4.AllowDrop = true;
         this.Label4.AutoSize = true;
         this.Label4.BackColor = System.Drawing.Color.Transparent;
         this.Label4.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label4.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         this.Label4.Location = new System.Drawing.Point(48, 32);
         this.Label4.Name = "Label4";
         this.Label4.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label4.Size = new System.Drawing.Size(176, 13);
         this.Label4.TabIndex = 17;
         this.Label4.Text = "Set user information and access level";
         // 
         // Image1
         // 
         this.Image1.AllowDrop = true;
         this.Image1.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Image1.Properties().Cursor = null;
         this.Image1.Enabled = true;
         this.Image1.Image = "assets/images/SKS.frmUsersManage.Image1.Image.png";
         this.Image1.Location = new System.Drawing.Point(8, 8);
         this.Image1.Name = "Image1";
         this.Image1.Size = new System.Drawing.Size(32, 32);
         this.Image1.SizeMode = Mobilize.Web.PictureBoxSizeMode.StretchImage;
         this.Image1.Visible = true;
         // 
         // frmUsersManage
         // 
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.AutoScroll = true;
         this.BackColor = Mobilize.Web.SystemColors.Control;
         this.Properties().ClientSize = new System.Drawing.Size(341, 414);
         this.Controls.Add(this.lstAccounts);
         this.Controls.Add(this.cmdClear);
         this.Controls.Add(this.cmdSave);
         this.Controls.Add(this.ctrlLiner1);
         this.Controls.Add(this.Frame1);
         this.Controls.Add(this.cmdClose);
         this.Controls.Add(this.cmdEdit);
         this.Controls.Add(this.cmdDelete);
         this.Controls.Add(this._Label1_4);
         this.Controls.Add(this.Label19);
         this.Controls.Add(this.Label4);
         this.Controls.Add(this.Image1);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedSingle;
         this.Icon = (Mobilize.Web.Icon)new Mobilize.Web.Icon("assets/images/SKS.frmUsersManage.frmUsersManage.Icon.png");
         this.Properties().Location = new System.Drawing.Point(327, 144);
         this.MaximizeBox = false;
         this.MinimizeBox = true;
         this.Name = "frmUsersManage";
         this.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.Manual;
         this.Text = "Users Management";
         //this.Image1.Cursor = vbCustom;
         this.ToolTipMain.SetToolTip(this.Image1, "View warnings");
         this.Closed += new System.EventHandler(this.Form_Closed);
         this.listViewHelper1.SetCorrectEventsBehavior(this.lstAccounts, true);
         this.lstAccounts.ResumeLayout(false);
         this.Frame1.ResumeLayout(false);
         this.ResumeLayout(false);

#line hidden
this.Controls.DesignTime=false;
#line 563
      }

      void ReLoadForm(bool addEvents)
      {
      	InitializeLabel1();
      	//This form is an MDI child.
      	//This code simulates the VB6 
      	// functionality of automatically
      	// loading and showing an MDI
      	// child's parent.
      	this.MdiParent = SKS.frmMain.DefInstance;
      	SKS.frmMain.DefInstance.Show();
      }

      void InitializeLabel1()
      {
      	this.Label1 = new Mobilize.Web.Label[5];
      	this.Label1[2] = _Label1_2;
      	this.Label1[0] = _Label1_0;
      	this.Label1[1] = _Label1_1;
      	this.Label1[3] = _Label1_3;
      	this.Label1[4] = _Label1_4;
      }
      #endregion

   }
}
#pragma warning restore
