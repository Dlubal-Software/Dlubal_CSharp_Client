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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="RSTAB_9.06.0007", ConfigurationName="Dlubal.WS.Rstab9.Application.IRstabApplication")]
    [System.Xml.Serialization.XmlSerializerAssembly]
    public interface IRstabApplication
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/close_application", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.close_applicationResponse close_application(Dlubal.WS.Rstab9.Application.close_applicationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/close_model", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.close_modelResponse close_model(Dlubal.WS.Rstab9.Application.close_modelRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/delete_project", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.delete_projectResponse delete_project(Dlubal.WS.Rstab9.Application.delete_projectRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_active_model", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.get_active_modelResponse get_active_model(Dlubal.WS.Rstab9.Application.get_active_modelRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_conversion_tables", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.get_conversion_tablesResponse get_conversion_tables(Dlubal.WS.Rstab9.Application.get_conversion_tablesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_current_project", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.get_current_projectResponse get_current_project(Dlubal.WS.Rstab9.Application.get_current_projectRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_detailed_logging", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.get_detailed_loggingResponse get_detailed_logging(Dlubal.WS.Rstab9.Application.get_detailed_loggingRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_information", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.get_informationResponse get_information(Dlubal.WS.Rstab9.Application.get_informationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_list_of_existing_projects", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.get_list_of_existing_projectsResponse get_list_of_existing_projects(Dlubal.WS.Rstab9.Application.get_list_of_existing_projectsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_list_of_existing_templates", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.get_list_of_existing_templatesResponse get_list_of_existing_templates(Dlubal.WS.Rstab9.Application.get_list_of_existing_templatesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_model", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.get_modelResponse get_model(Dlubal.WS.Rstab9.Application.get_modelRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_model_list", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.get_model_listResponse get_model_list(Dlubal.WS.Rstab9.Application.get_model_listRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_model_list_with_indexes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.get_model_list_with_indexesResponse get_model_list_with_indexes(Dlubal.WS.Rstab9.Application.get_model_list_with_indexesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_program_options", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.get_program_optionsResponse get_program_options(Dlubal.WS.Rstab9.Application.get_program_optionsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_program_settings", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.get_program_settingsResponse get_program_settings(Dlubal.WS.Rstab9.Application.get_program_settingsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_project", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.get_projectResponse get_project(Dlubal.WS.Rstab9.Application.get_projectRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_saf_settings", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.get_saf_settingsResponse get_saf_settings(Dlubal.WS.Rstab9.Application.get_saf_settingsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_session_id", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.get_session_idResponse get_session_id(Dlubal.WS.Rstab9.Application.get_session_idRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_settings_program_language", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.get_settings_program_languageResponse get_settings_program_language(Dlubal.WS.Rstab9.Application.get_settings_program_languageRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_template", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.get_templateResponse get_template(Dlubal.WS.Rstab9.Application.get_templateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/import_from", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.import_fromResponse import_from(Dlubal.WS.Rstab9.Application.import_fromRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/new_model", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.new_modelResponse new_model(Dlubal.WS.Rstab9.Application.new_modelRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/new_model_as_copy", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.new_model_as_copyResponse new_model_as_copy(Dlubal.WS.Rstab9.Application.new_model_as_copyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/new_model_from_template", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.new_model_from_templateResponse new_model_from_template(Dlubal.WS.Rstab9.Application.new_model_from_templateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/new_project", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.new_projectResponse new_project(Dlubal.WS.Rstab9.Application.new_projectRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/new_template", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.new_templateResponse new_template(Dlubal.WS.Rstab9.Application.new_templateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/open_model", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.open_modelResponse open_model(Dlubal.WS.Rstab9.Application.open_modelRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/save_model", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.save_modelResponse save_model(Dlubal.WS.Rstab9.Application.save_modelRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/set_as_current_project", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.set_as_current_projectResponse set_as_current_project(Dlubal.WS.Rstab9.Application.set_as_current_projectRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/set_conversion_tables", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.set_conversion_tablesResponse set_conversion_tables(Dlubal.WS.Rstab9.Application.set_conversion_tablesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/set_detailed_logging", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.set_detailed_loggingResponse set_detailed_logging(Dlubal.WS.Rstab9.Application.set_detailed_loggingRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/set_program_options", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.set_program_optionsResponse set_program_options(Dlubal.WS.Rstab9.Application.set_program_optionsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/set_program_settings", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.set_program_settingsResponse set_program_settings(Dlubal.WS.Rstab9.Application.set_program_settingsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/set_saf_settings", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.set_saf_settingsResponse set_saf_settings(Dlubal.WS.Rstab9.Application.set_saf_settingsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/set_settings_program_language", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.Rstab9.Application.set_settings_program_languageResponse set_settings_program_language(Dlubal.WS.Rstab9.Application.set_settings_program_languageRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRstabApplicationChannel : Dlubal.WS.Rstab9.Application.IRstabApplication, System.ServiceModel.IClientChannel
    {
    }
}
