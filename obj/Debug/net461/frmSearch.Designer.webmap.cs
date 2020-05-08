#pragma warning disable
#line 1 "frmSearch.Designer.cs"
#pragma warning disable
#line 1 "frmSearch.Designer.cs"
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmSearch
   {

      [Intercepted]

      #region "Upgrade Support "
      private static frmSearch m_vb6FormDefInstance 
#line 13
                                                    { 
#line 13
                                                      get                                                         
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (SKS.frmSearch)catalog.frmSearch.m_vb6FormDefInstance;} 
#line 13

#line 13
                                                           set                                                              
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmSearch.m_vb6FormDefInstance = value;} 
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
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (bool)catalog.frmSearch.m_InitializingDefInstance;} 
#line 16

#line 16
                                                           set                                                              
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.frmSearch.m_InitializingDefInstance = value;} 
#line 16
                                                                }

#line 17

      [Intercepted]
      public static frmSearch DefInstance
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

      public static frmSearch CreateInstance()
      {
      	frmSearch theInstance = new frmSearch();
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
private Mobilize.Web.Button cmdClose_k__BackingField;
#line 58


      [Intercepted]
      public Mobilize.Web.Button cmdClose 
#line 58
                                          { 
#line 58
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdClose)<=0){this.cmdClose_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,3);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdClose;;} return this.cmdClose_k__BackingField; } 
#line 58

#line 58
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,3,this.cmdClose_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdClose;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdClose;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdClose_k__BackingField=(Mobilize.Web.Button)value;} 
#line 58
                                                      }

#line 59

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Button cmdSearch_k__BackingField;
#line 61


      [Intercepted]
      public Mobilize.Web.Button cmdSearch 
#line 61
                                           { 
#line 61
                                             get                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cmdSearch)<=0){this.cmdSearch_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Button>(this,_Mobilize_References,4);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdSearch;;} return this.cmdSearch_k__BackingField; } 
#line 61

#line 61
                                                  set                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Button>(this,_Mobilize_References,4,this.cmdSearch_k__BackingField,(Mobilize.Web.Button)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cmdSearch;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cmdSearch;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cmdSearch_k__BackingField=(Mobilize.Web.Button)value;} 
#line 61
                                                       }

#line 62

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.PictureBox ctrlLiner1_k__BackingField;
#line 64


      [Intercepted]
      public Mobilize.Web.PictureBox ctrlLiner1 
#line 64
                                                { 
#line 64
                                                  get                                                     
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_ctrlLiner1)<=0){this.ctrlLiner1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.PictureBox>(this,_Mobilize_References,5);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_ctrlLiner1;;} return this.ctrlLiner1_k__BackingField; } 
#line 64

#line 64
                                                       set                                                          
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.PictureBox>(this,_Mobilize_References,5,this.ctrlLiner1_k__BackingField,(Mobilize.Web.PictureBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_ctrlLiner1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_ctrlLiner1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.ctrlLiner1_k__BackingField=(Mobilize.Web.PictureBox)value;} 
#line 64
                                                            }

#line 65

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.ComboBox cboSrchBy_k__BackingField;
#line 67


      [Intercepted]
      public Mobilize.Web.ComboBox cboSrchBy 
#line 67
                                             { 
#line 67
                                               get                                                  
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cboSrchBy)<=0){this.cboSrchBy_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.ComboBox>(this,_Mobilize_References,6);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cboSrchBy;;} return this.cboSrchBy_k__BackingField; } 
#line 67

#line 67
                                                    set                                                       
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.ComboBox>(this,_Mobilize_References,6,this.cboSrchBy_k__BackingField,(Mobilize.Web.ComboBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cboSrchBy;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cboSrchBy;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cboSrchBy_k__BackingField=(Mobilize.Web.ComboBox)value;} 
#line 67
                                                         }

#line 68

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.TextBox txtSrchStr_k__BackingField;
#line 70


      [Intercepted]
      public Mobilize.Web.TextBox txtSrchStr 
#line 70
                                             { 
#line 70
                                               get                                                  
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_txtSrchStr)<=0){this.txtSrchStr_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,7);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtSrchStr;;} return this.txtSrchStr_k__BackingField; } 
#line 70

#line 70
                                                    set                                                       
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.TextBox>(this,_Mobilize_References,7,this.txtSrchStr_k__BackingField,(Mobilize.Web.TextBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_txtSrchStr;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_txtSrchStr;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.txtSrchStr_k__BackingField=(Mobilize.Web.TextBox)value;} 
#line 70
                                                         }

#line 71

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label20_k__BackingField;
#line 73


      [Intercepted]
      public Mobilize.Web.Label Label20 
#line 73
                                        { 
#line 73
                                          get                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label20)<=0){this.Label20_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,8);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label20;;} return this.Label20_k__BackingField; } 
#line 73

#line 73
                                               set                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,8,this.Label20_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label20;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label20;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label20_k__BackingField=(Mobilize.Web.Label)value;} 
#line 73
                                                    }

#line 74

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label19_k__BackingField;
#line 76


      [Intercepted]
      public Mobilize.Web.Label Label19 
#line 76
                                        { 
#line 76
                                          get                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label19)<=0){this.Label19_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,9);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label19;;} return this.Label19_k__BackingField; } 
#line 76

#line 76
                                               set                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,9,this.Label19_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label19;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label19;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label19_k__BackingField=(Mobilize.Web.Label)value;} 
#line 76
                                                    }

#line 77

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.PictureBox Image3_k__BackingField;
#line 79


      [Intercepted]
      public Mobilize.Web.PictureBox Image3 
#line 79
                                            { 
#line 79
                                              get                                                 
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Image3)<=0){this.Image3_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.PictureBox>(this,_Mobilize_References,10);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Image3;;} return this.Image3_k__BackingField; } 
#line 79

#line 79
                                                   set                                                      
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.PictureBox>(this,_Mobilize_References,10,this.Image3_k__BackingField,(Mobilize.Web.PictureBox)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Image3;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Image3;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Image3_k__BackingField=(Mobilize.Web.PictureBox)value;} 
#line 79
                                                        }

#line 80

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label Label1_k__BackingField;
#line 82


      [Intercepted]
      public Mobilize.Web.Label Label1 
#line 82
                                       { 
#line 82
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Label1)<=0){this.Label1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,11);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label1;;} return this.Label1_k__BackingField; } 
#line 82

#line 82
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,11,this.Label1_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Label1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Label1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Label1_k__BackingField=(Mobilize.Web.Label)value;} 
#line 82
                                                   }

#line 83

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.Label lblSrchBy_k__BackingField;
#line 85


      [Intercepted]
      public Mobilize.Web.Label lblSrchBy 
#line 85
                                          { 
#line 85
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_lblSrchBy)<=0){this.lblSrchBy_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.Label>(this,_Mobilize_References,12);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lblSrchBy;;} return this.lblSrchBy_k__BackingField; } 
#line 85

#line 85
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.Label>(this,_Mobilize_References,12,this.lblSrchBy_k__BackingField,(Mobilize.Web.Label)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lblSrchBy;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_lblSrchBy;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lblSrchBy_k__BackingField=(Mobilize.Web.Label)value;} 
#line 85
                                                      }

#line 86
      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.

      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {

#line hidden
this.Controls.DesignTime=true;
#line 94
      	this.components = new System.ComponentModel.Container();
      	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
      	this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
      	this.cmdClose = new Mobilize.Web.Button();
      	this.cmdSearch = new Mobilize.Web.Button();
      	this.ctrlLiner1 = new Mobilize.Web.PictureBox();
      	this.cboSrchBy = new Mobilize.Web.ComboBox();
      	this.txtSrchStr = new Mobilize.Web.TextBox();
      	this.Label20 = new Mobilize.Web.Label();
      	this.Label19 = new Mobilize.Web.Label();
      	this.Image3 = new Mobilize.Web.PictureBox();
      	this.Label1 = new Mobilize.Web.Label();
      	this.lblSrchBy = new Mobilize.Web.Label();
      	this.SuspendLayout();
      	// 
      	// cmdClose
      	// 
      	this.cmdClose.AllowDrop = true;
      	this.cmdClose.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdClose.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdClose.Location = new System.Drawing.Point(272, 104);
         this.cmdClose.Name = "cmdClose";
         this.cmdClose.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdClose.Size = new System.Drawing.Size(81, 25);
         this.cmdClose.TabIndex = 8;
         this.cmdClose.Text = "&Close";
         this.cmdClose.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdClose.UseVisualStyleBackColor = false;
         this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
         // 
         // cmdSearch
         // 
         this.cmdSearch.AllowDrop = true;
         this.cmdSearch.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdSearch.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdSearch.Location = new System.Drawing.Point(184, 104);
         this.cmdSearch.Name = "cmdSearch";
         this.cmdSearch.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdSearch.Size = new System.Drawing.Size(81, 25);
         this.cmdSearch.TabIndex = 7;
         this.cmdSearch.Text = "&Search";
         this.cmdSearch.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdSearch.UseVisualStyleBackColor = false;
         this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
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
         this.ctrlLiner1.Size = new System.Drawing.Size(385, 2);
         this.ctrlLiner1.SizeMode = Mobilize.Web.PictureBoxSizeMode.Normal;
         this.ctrlLiner1.Properties().TabIndex = 6;
         this.ctrlLiner1.Properties().TabStop = true;
         this.ctrlLiner1.Visible = true;
         // 
         // cboSrchBy
         // 
         this.cboSrchBy.AllowDrop = true;
         this.cboSrchBy.BackColor = Mobilize.Web.SystemColors.Window;
         this.cboSrchBy.CausesValidation = true;
         this.cboSrchBy.DropDownStyle = Mobilize.Web.ComboBoxStyle.DropDownList;
         this.cboSrchBy.Enabled = true;
         this.cboSrchBy.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.cboSrchBy.IntegralHeight = true;
         this.cboSrchBy.Location = new System.Drawing.Point(208, 144);
         this.cboSrchBy.Name = "cboSrchBy";
         this.cboSrchBy.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cboSrchBy.Size = new System.Drawing.Size(145, 21);
         this.cboSrchBy.Sorted = false;
         this.cboSrchBy.TabIndex = 3;
         this.cboSrchBy.TabStop = true;
         this.cboSrchBy.Visible = true;
         this.cboSrchBy.SelectedIndexChanged += new System.EventHandler(this.cboSrchBy_SelectedIndexChanged);
         // 
         // txtSrchStr
         // 
         this.txtSrchStr.AcceptsReturn = true;
         this.txtSrchStr.AllowDrop = true;
         this.txtSrchStr.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtSrchStr.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtSrchStr.Properties().Cursor = Stub._System.Windows.Forms.Cursors.IBeam;
         this.txtSrchStr.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtSrchStr.Location = new System.Drawing.Point(136, 72);
         this.txtSrchStr.MaxLength = 0;
         this.txtSrchStr.Name = "txtSrchStr";
         this.txtSrchStr.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtSrchStr.Size = new System.Drawing.Size(217, 19);
         this.txtSrchStr.TabIndex = 0;
         // 
         // Label20
         // 
         this.Label20.AllowDrop = true;
         this.Label20.AutoSize = true;
         this.Label20.BackColor = System.Drawing.Color.Transparent;
         this.Label20.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label20.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         this.Label20.Location = new System.Drawing.Point(49, 32);
         this.Label20.Name = "Label20";
         this.Label20.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label20.Size = new System.Drawing.Size(119, 13);
         this.Label20.TabIndex = 5;
         this.Label20.Text = "Search for a specific item";
         // 
         // Label19
         // 
         this.Label19.AllowDrop = true;
         this.Label19.AutoSize = true;
         this.Label19.BackColor = System.Drawing.Color.Transparent;
         this.Label19.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label19.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 9.75f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label19.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         this.Label19.Location = new System.Drawing.Point(49, 8);
         this.Label19.Name = "Label19";
         this.Label19.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label19.Size = new System.Drawing.Size(50, 16);
         this.Label19.TabIndex = 4;
         this.Label19.Text = "Search";
         this.Label19.TextAlign = Mobilize.Web.ContentAlignment.TopRight;
         // 
         // Image3
         // 
         this.Image3.AllowDrop = true;
         this.Image3.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Image3.Enabled = true;
         this.Image3.Image = "assets/images/SKS.frmSearch.Image3.Image.png";
         this.Image3.Location = new System.Drawing.Point(8, 8);
         this.Image3.Name = "Image3";
         this.Image3.Size = new System.Drawing.Size(16, 16);
         this.Image3.SizeMode = Mobilize.Web.PictureBoxSizeMode.Normal;
         this.Image3.Visible = true;
         // 
         // Label1
         // 
         this.Label1.AllowDrop = true;
         this.Label1.AutoSize = true;
         this.Label1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label1.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         this.Label1.Location = new System.Drawing.Point(125, 144);
         this.Label1.Name = "Label1";
         this.Label1.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label1.Size = new System.Drawing.Size(62, 13);
         this.Label1.TabIndex = 2;
         this.Label1.Text = "Search by:";
         this.Label1.TextAlign = Mobilize.Web.ContentAlignment.TopRight;
         // 
         // lblSrchBy
         // 
         this.lblSrchBy.AllowDrop = true;
         this.lblSrchBy.AutoSize = true;
         this.lblSrchBy.BackColor = Mobilize.Web.SystemColors.Control;
         this.lblSrchBy.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblSrchBy.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lblSrchBy.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         this.lblSrchBy.Location = new System.Drawing.Point(7, 72);
         this.lblSrchBy.Name = "lblSrchBy";
         this.lblSrchBy.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblSrchBy.Size = new System.Drawing.Size(116, 13);
         this.lblSrchBy.TabIndex = 1;
         this.lblSrchBy.Text = "Field";
         this.lblSrchBy.TextAlign = Mobilize.Web.ContentAlignment.TopRight;
         // 
         // frmSearch
         // 
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = Mobilize.Web.SystemColors.Control;
         this.Properties().ClientSize = new System.Drawing.Size(378, 173);
         this.Controls.Add(this.cmdClose);
         this.Controls.Add(this.cmdSearch);
         this.Controls.Add(this.ctrlLiner1);
         this.Controls.Add(this.cboSrchBy);
         this.Controls.Add(this.txtSrchStr);
         this.Controls.Add(this.Label20);
         this.Controls.Add(this.Label19);
         this.Controls.Add(this.Image3);
         this.Controls.Add(this.Label1);
         this.Controls.Add(this.lblSrchBy);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedDialog;
         this.Icon = (Mobilize.Web.Icon)new Mobilize.Web.Icon("assets/images/SKS.frmSearch.frmSearch.Icon.png");
         this.Properties().Location = new System.Drawing.Point(486, 322);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmSearch";
         this.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Properties().ShowInTaskbar = false;
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.CenterScreen;
         this.Text = "Search";
         this.Closed += new System.EventHandler(this.Form_Closed);
         this.ResumeLayout(false);

#line hidden
this.Controls.DesignTime=false;
#line 292
      }
      #endregion

   }
}
#pragma warning restore
