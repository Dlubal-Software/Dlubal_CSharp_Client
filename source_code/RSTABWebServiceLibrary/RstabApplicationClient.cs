//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dlubal.WS.Rstab9.Application
{
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RstabApplicationClient : System.ServiceModel.ClientBase<Dlubal.WS.Rstab9.Application.IRstabApplication>, Dlubal.WS.Rstab9.Application.IRstabApplication
    {
        
        public RstabApplicationClient()
        {
        }
        
        public RstabApplicationClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public RstabApplicationClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public RstabApplicationClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public RstabApplicationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.close_applicationResponse Dlubal.WS.Rstab9.Application.IRstabApplication.close_application(Dlubal.WS.Rstab9.Application.close_applicationRequest request)
        {
            return base.Channel.close_application(request);
        }
        
        public void close_application()
        {
            Dlubal.WS.Rstab9.Application.close_applicationRequest inValue = new Dlubal.WS.Rstab9.Application.close_applicationRequest();
            Dlubal.WS.Rstab9.Application.close_applicationResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).close_application(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.close_modelResponse Dlubal.WS.Rstab9.Application.IRstabApplication.close_model(Dlubal.WS.Rstab9.Application.close_modelRequest request)
        {
            return base.Channel.close_model(request);
        }
        
        public void close_model(int index, bool save_changes)
        {
            Dlubal.WS.Rstab9.Application.close_modelRequest inValue = new Dlubal.WS.Rstab9.Application.close_modelRequest();
            inValue.index = index;
            inValue.save_changes = save_changes;
            Dlubal.WS.Rstab9.Application.close_modelResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).close_model(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.delete_projectResponse Dlubal.WS.Rstab9.Application.IRstabApplication.delete_project(Dlubal.WS.Rstab9.Application.delete_projectRequest request)
        {
            return base.Channel.delete_project(request);
        }
        
        public void delete_project(string project_path)
        {
            Dlubal.WS.Rstab9.Application.delete_projectRequest inValue = new Dlubal.WS.Rstab9.Application.delete_projectRequest();
            inValue.project_path = project_path;
            Dlubal.WS.Rstab9.Application.delete_projectResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).delete_project(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.get_active_modelResponse Dlubal.WS.Rstab9.Application.IRstabApplication.get_active_model(Dlubal.WS.Rstab9.Application.get_active_modelRequest request)
        {
            return base.Channel.get_active_model(request);
        }
        
        public string get_active_model()
        {
            Dlubal.WS.Rstab9.Application.get_active_modelRequest inValue = new Dlubal.WS.Rstab9.Application.get_active_modelRequest();
            Dlubal.WS.Rstab9.Application.get_active_modelResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).get_active_model(inValue);
            return retVal.value;
        }
        
        public Dlubal.WS.Rstab9.Application.ConversionTables get_conversion_tables()
        {
            Dlubal.WS.Rstab9.Application.get_conversion_tablesRequest inValue = new Dlubal.WS.Rstab9.Application.get_conversion_tablesRequest();
            Dlubal.WS.Rstab9.Application.get_conversion_tablesResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).get_conversion_tables(inValue);
            return retVal.value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.get_conversion_tablesResponse Dlubal.WS.Rstab9.Application.IRstabApplication.get_conversion_tables(Dlubal.WS.Rstab9.Application.get_conversion_tablesRequest request)
        {
            return base.Channel.get_conversion_tables(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.get_current_projectResponse Dlubal.WS.Rstab9.Application.IRstabApplication.get_current_project(Dlubal.WS.Rstab9.Application.get_current_projectRequest request)
        {
            return base.Channel.get_current_project(request);
        }
        
        public Dlubal.WS.Rstab9.Application.project_info get_current_project()
        {
            Dlubal.WS.Rstab9.Application.get_current_projectRequest inValue = new Dlubal.WS.Rstab9.Application.get_current_projectRequest();
            Dlubal.WS.Rstab9.Application.get_current_projectResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).get_current_project(inValue);
            return retVal.value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.get_detailed_loggingResponse Dlubal.WS.Rstab9.Application.IRstabApplication.get_detailed_logging(Dlubal.WS.Rstab9.Application.get_detailed_loggingRequest request)
        {
            return base.Channel.get_detailed_logging(request);
        }
        
        public bool get_detailed_logging()
        {
            Dlubal.WS.Rstab9.Application.get_detailed_loggingRequest inValue = new Dlubal.WS.Rstab9.Application.get_detailed_loggingRequest();
            Dlubal.WS.Rstab9.Application.get_detailed_loggingResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).get_detailed_logging(inValue);
            return retVal.value;
        }
        
        public Dlubal.WS.Rstab9.Application.application_information get_information()
        {
            Dlubal.WS.Rstab9.Application.get_informationRequest inValue = new Dlubal.WS.Rstab9.Application.get_informationRequest();
            Dlubal.WS.Rstab9.Application.get_informationResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).get_information(inValue);
            return retVal.value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.get_informationResponse Dlubal.WS.Rstab9.Application.IRstabApplication.get_information(Dlubal.WS.Rstab9.Application.get_informationRequest request)
        {
            return base.Channel.get_information(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.get_list_of_existing_projectsResponse Dlubal.WS.Rstab9.Application.IRstabApplication.get_list_of_existing_projects(Dlubal.WS.Rstab9.Application.get_list_of_existing_projectsRequest request)
        {
            return base.Channel.get_list_of_existing_projects(request);
        }
        
        public Dlubal.WS.Rstab9.Application.project_info[] get_list_of_existing_projects()
        {
            Dlubal.WS.Rstab9.Application.get_list_of_existing_projectsRequest inValue = new Dlubal.WS.Rstab9.Application.get_list_of_existing_projectsRequest();
            Dlubal.WS.Rstab9.Application.get_list_of_existing_projectsResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).get_list_of_existing_projects(inValue);
            return retVal.value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.get_list_of_existing_templatesResponse Dlubal.WS.Rstab9.Application.IRstabApplication.get_list_of_existing_templates(Dlubal.WS.Rstab9.Application.get_list_of_existing_templatesRequest request)
        {
            return base.Channel.get_list_of_existing_templates(request);
        }
        
        public Dlubal.WS.Rstab9.Application.project_info[] get_list_of_existing_templates()
        {
            Dlubal.WS.Rstab9.Application.get_list_of_existing_templatesRequest inValue = new Dlubal.WS.Rstab9.Application.get_list_of_existing_templatesRequest();
            Dlubal.WS.Rstab9.Application.get_list_of_existing_templatesResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).get_list_of_existing_templates(inValue);
            return retVal.value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.get_modelResponse Dlubal.WS.Rstab9.Application.IRstabApplication.get_model(Dlubal.WS.Rstab9.Application.get_modelRequest request)
        {
            return base.Channel.get_model(request);
        }
        
        public string get_model(int index)
        {
            Dlubal.WS.Rstab9.Application.get_modelRequest inValue = new Dlubal.WS.Rstab9.Application.get_modelRequest();
            inValue.index = index;
            Dlubal.WS.Rstab9.Application.get_modelResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).get_model(inValue);
            return retVal.value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.get_model_listResponse Dlubal.WS.Rstab9.Application.IRstabApplication.get_model_list(Dlubal.WS.Rstab9.Application.get_model_listRequest request)
        {
            return base.Channel.get_model_list(request);
        }
        
        public string[] get_model_list()
        {
            Dlubal.WS.Rstab9.Application.get_model_listRequest inValue = new Dlubal.WS.Rstab9.Application.get_model_listRequest();
            Dlubal.WS.Rstab9.Application.get_model_listResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).get_model_list(inValue);
            return retVal.value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.get_model_list_with_indexesResponse Dlubal.WS.Rstab9.Application.IRstabApplication.get_model_list_with_indexes(Dlubal.WS.Rstab9.Application.get_model_list_with_indexesRequest request)
        {
            return base.Channel.get_model_list_with_indexes(request);
        }
        
        public Dlubal.WS.Rstab9.Application.model_name_and_index[] get_model_list_with_indexes()
        {
            Dlubal.WS.Rstab9.Application.get_model_list_with_indexesRequest inValue = new Dlubal.WS.Rstab9.Application.get_model_list_with_indexesRequest();
            Dlubal.WS.Rstab9.Application.get_model_list_with_indexesResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).get_model_list_with_indexes(inValue);
            return retVal.value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.get_projectResponse Dlubal.WS.Rstab9.Application.IRstabApplication.get_project(Dlubal.WS.Rstab9.Application.get_projectRequest request)
        {
            return base.Channel.get_project(request);
        }
        
        public Dlubal.WS.Rstab9.Application.project_info get_project(string project_path)
        {
            Dlubal.WS.Rstab9.Application.get_projectRequest inValue = new Dlubal.WS.Rstab9.Application.get_projectRequest();
            inValue.project_path = project_path;
            Dlubal.WS.Rstab9.Application.get_projectResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).get_project(inValue);
            return retVal.value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.get_saf_settingsResponse Dlubal.WS.Rstab9.Application.IRstabApplication.get_saf_settings(Dlubal.WS.Rstab9.Application.get_saf_settingsRequest request)
        {
            return base.Channel.get_saf_settings(request);
        }
        
        public Dlubal.WS.Rstab9.Application.SafConfiguration get_saf_settings()
        {
            Dlubal.WS.Rstab9.Application.get_saf_settingsRequest inValue = new Dlubal.WS.Rstab9.Application.get_saf_settingsRequest();
            Dlubal.WS.Rstab9.Application.get_saf_settingsResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).get_saf_settings(inValue);
            return retVal.value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.get_session_idResponse Dlubal.WS.Rstab9.Application.IRstabApplication.get_session_id(Dlubal.WS.Rstab9.Application.get_session_idRequest request)
        {
            return base.Channel.get_session_id(request);
        }
        
        public string get_session_id()
        {
            Dlubal.WS.Rstab9.Application.get_session_idRequest inValue = new Dlubal.WS.Rstab9.Application.get_session_idRequest();
            Dlubal.WS.Rstab9.Application.get_session_idResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).get_session_id(inValue);
            return retVal.value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.get_settings_program_languageResponse Dlubal.WS.Rstab9.Application.IRstabApplication.get_settings_program_language(Dlubal.WS.Rstab9.Application.get_settings_program_languageRequest request)
        {
            return base.Channel.get_settings_program_language(request);
        }
        
        public Dlubal.WS.Rstab9.Application.settings_program_language get_settings_program_language()
        {
            Dlubal.WS.Rstab9.Application.get_settings_program_languageRequest inValue = new Dlubal.WS.Rstab9.Application.get_settings_program_languageRequest();
            Dlubal.WS.Rstab9.Application.get_settings_program_languageResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).get_settings_program_language(inValue);
            return retVal.value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.get_templateResponse Dlubal.WS.Rstab9.Application.IRstabApplication.get_template(Dlubal.WS.Rstab9.Application.get_templateRequest request)
        {
            return base.Channel.get_template(request);
        }
        
        public Dlubal.WS.Rstab9.Application.project_info get_template(string template_path)
        {
            Dlubal.WS.Rstab9.Application.get_templateRequest inValue = new Dlubal.WS.Rstab9.Application.get_templateRequest();
            inValue.template_path = template_path;
            Dlubal.WS.Rstab9.Application.get_templateResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).get_template(inValue);
            return retVal.value;
        }
        
        public Dlubal.WS.Rstab9.Application.import_from_output import_from(string file_path)
        {
            Dlubal.WS.Rstab9.Application.import_fromRequest inValue = new Dlubal.WS.Rstab9.Application.import_fromRequest();
            inValue.file_path = file_path;
            Dlubal.WS.Rstab9.Application.import_fromResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).import_from(inValue);
            return retVal.value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.import_fromResponse Dlubal.WS.Rstab9.Application.IRstabApplication.import_from(Dlubal.WS.Rstab9.Application.import_fromRequest request)
        {
            return base.Channel.import_from(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.new_modelResponse Dlubal.WS.Rstab9.Application.IRstabApplication.new_model(Dlubal.WS.Rstab9.Application.new_modelRequest request)
        {
            return base.Channel.new_model(request);
        }
        
        public string new_model(string model_name)
        {
            Dlubal.WS.Rstab9.Application.new_modelRequest inValue = new Dlubal.WS.Rstab9.Application.new_modelRequest();
            inValue.model_name = model_name;
            Dlubal.WS.Rstab9.Application.new_modelResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).new_model(inValue);
            return retVal.value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.new_model_as_copyResponse Dlubal.WS.Rstab9.Application.IRstabApplication.new_model_as_copy(Dlubal.WS.Rstab9.Application.new_model_as_copyRequest request)
        {
            return base.Channel.new_model_as_copy(request);
        }
        
        public string new_model_as_copy(string model_name, string file_path)
        {
            Dlubal.WS.Rstab9.Application.new_model_as_copyRequest inValue = new Dlubal.WS.Rstab9.Application.new_model_as_copyRequest();
            inValue.model_name = model_name;
            inValue.file_path = file_path;
            Dlubal.WS.Rstab9.Application.new_model_as_copyResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).new_model_as_copy(inValue);
            return retVal.value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.new_model_from_templateResponse Dlubal.WS.Rstab9.Application.IRstabApplication.new_model_from_template(Dlubal.WS.Rstab9.Application.new_model_from_templateRequest request)
        {
            return base.Channel.new_model_from_template(request);
        }
        
        public string new_model_from_template(string model_name, string file_path)
        {
            Dlubal.WS.Rstab9.Application.new_model_from_templateRequest inValue = new Dlubal.WS.Rstab9.Application.new_model_from_templateRequest();
            inValue.model_name = model_name;
            inValue.file_path = file_path;
            Dlubal.WS.Rstab9.Application.new_model_from_templateResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).new_model_from_template(inValue);
            return retVal.value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.new_projectResponse Dlubal.WS.Rstab9.Application.IRstabApplication.new_project(Dlubal.WS.Rstab9.Application.new_projectRequest request)
        {
            return base.Channel.new_project(request);
        }
        
        public void new_project(Dlubal.WS.Rstab9.Application.project_info project_info)
        {
            Dlubal.WS.Rstab9.Application.new_projectRequest inValue = new Dlubal.WS.Rstab9.Application.new_projectRequest();
            inValue.project_info = project_info;
            Dlubal.WS.Rstab9.Application.new_projectResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).new_project(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.new_templateResponse Dlubal.WS.Rstab9.Application.IRstabApplication.new_template(Dlubal.WS.Rstab9.Application.new_templateRequest request)
        {
            return base.Channel.new_template(request);
        }
        
        public void new_template(Dlubal.WS.Rstab9.Application.project_info template_info)
        {
            Dlubal.WS.Rstab9.Application.new_templateRequest inValue = new Dlubal.WS.Rstab9.Application.new_templateRequest();
            inValue.template_info = template_info;
            Dlubal.WS.Rstab9.Application.new_templateResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).new_template(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.open_modelResponse Dlubal.WS.Rstab9.Application.IRstabApplication.open_model(Dlubal.WS.Rstab9.Application.open_modelRequest request)
        {
            return base.Channel.open_model(request);
        }
        
        public string open_model(string model_path)
        {
            Dlubal.WS.Rstab9.Application.open_modelRequest inValue = new Dlubal.WS.Rstab9.Application.open_modelRequest();
            inValue.model_path = model_path;
            Dlubal.WS.Rstab9.Application.open_modelResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).open_model(inValue);
            return retVal.value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.save_modelResponse Dlubal.WS.Rstab9.Application.IRstabApplication.save_model(Dlubal.WS.Rstab9.Application.save_modelRequest request)
        {
            return base.Channel.save_model(request);
        }
        
        public void save_model(int index)
        {
            Dlubal.WS.Rstab9.Application.save_modelRequest inValue = new Dlubal.WS.Rstab9.Application.save_modelRequest();
            inValue.index = index;
            Dlubal.WS.Rstab9.Application.save_modelResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).save_model(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.set_as_current_projectResponse Dlubal.WS.Rstab9.Application.IRstabApplication.set_as_current_project(Dlubal.WS.Rstab9.Application.set_as_current_projectRequest request)
        {
            return base.Channel.set_as_current_project(request);
        }
        
        public void set_as_current_project(string project_path)
        {
            Dlubal.WS.Rstab9.Application.set_as_current_projectRequest inValue = new Dlubal.WS.Rstab9.Application.set_as_current_projectRequest();
            inValue.project_path = project_path;
            Dlubal.WS.Rstab9.Application.set_as_current_projectResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).set_as_current_project(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.set_conversion_tablesResponse Dlubal.WS.Rstab9.Application.IRstabApplication.set_conversion_tables(Dlubal.WS.Rstab9.Application.set_conversion_tablesRequest request)
        {
            return base.Channel.set_conversion_tables(request);
        }
        
        public void set_conversion_tables(Dlubal.WS.Rstab9.Application.ConversionTables value)
        {
            Dlubal.WS.Rstab9.Application.set_conversion_tablesRequest inValue = new Dlubal.WS.Rstab9.Application.set_conversion_tablesRequest();
            inValue.value = value;
            Dlubal.WS.Rstab9.Application.set_conversion_tablesResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).set_conversion_tables(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.set_detailed_loggingResponse Dlubal.WS.Rstab9.Application.IRstabApplication.set_detailed_logging(Dlubal.WS.Rstab9.Application.set_detailed_loggingRequest request)
        {
            return base.Channel.set_detailed_logging(request);
        }
        
        public void set_detailed_logging(bool value)
        {
            Dlubal.WS.Rstab9.Application.set_detailed_loggingRequest inValue = new Dlubal.WS.Rstab9.Application.set_detailed_loggingRequest();
            inValue.value = value;
            Dlubal.WS.Rstab9.Application.set_detailed_loggingResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).set_detailed_logging(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.set_saf_settingsResponse Dlubal.WS.Rstab9.Application.IRstabApplication.set_saf_settings(Dlubal.WS.Rstab9.Application.set_saf_settingsRequest request)
        {
            return base.Channel.set_saf_settings(request);
        }
        
        public void set_saf_settings(Dlubal.WS.Rstab9.Application.SafConfiguration value)
        {
            Dlubal.WS.Rstab9.Application.set_saf_settingsRequest inValue = new Dlubal.WS.Rstab9.Application.set_saf_settingsRequest();
            inValue.value = value;
            Dlubal.WS.Rstab9.Application.set_saf_settingsResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).set_saf_settings(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dlubal.WS.Rstab9.Application.set_settings_program_languageResponse Dlubal.WS.Rstab9.Application.IRstabApplication.set_settings_program_language(Dlubal.WS.Rstab9.Application.set_settings_program_languageRequest request)
        {
            return base.Channel.set_settings_program_language(request);
        }
        
        public string set_settings_program_language(Dlubal.WS.Rstab9.Application.settings_program_language settings_program_language)
        {
            Dlubal.WS.Rstab9.Application.set_settings_program_languageRequest inValue = new Dlubal.WS.Rstab9.Application.set_settings_program_languageRequest();
            inValue.settings_program_language = settings_program_language;
            Dlubal.WS.Rstab9.Application.set_settings_program_languageResponse retVal = ((Dlubal.WS.Rstab9.Application.IRstabApplication)(this)).set_settings_program_language(inValue);
            return retVal.value;
        }
    }
}
