//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dlubal.WS.RSection1.Application
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="RSECTION_1.06.0008", ConfigurationName="Dlubal.WS.RSection1.Application.IRSectionApplication")]
    [System.Xml.Serialization.XmlSerializerAssembly]
    public interface IRSectionApplication
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/close_application", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.close_applicationResponse close_application(Dlubal.WS.RSection1.Application.close_applicationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/close_model", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.close_modelResponse close_model(Dlubal.WS.RSection1.Application.close_modelRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/delete_project", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.delete_projectResponse delete_project(Dlubal.WS.RSection1.Application.delete_projectRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_active_model", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.get_active_modelResponse get_active_model(Dlubal.WS.RSection1.Application.get_active_modelRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_current_project", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.get_current_projectResponse get_current_project(Dlubal.WS.RSection1.Application.get_current_projectRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_detailed_logging", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.get_detailed_loggingResponse get_detailed_logging(Dlubal.WS.RSection1.Application.get_detailed_loggingRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_information", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.get_informationResponse get_information(Dlubal.WS.RSection1.Application.get_informationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_list_of_existing_projects", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.get_list_of_existing_projectsResponse get_list_of_existing_projects(Dlubal.WS.RSection1.Application.get_list_of_existing_projectsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_model", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.get_modelResponse get_model(Dlubal.WS.RSection1.Application.get_modelRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_model_list", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.get_model_listResponse get_model_list(Dlubal.WS.RSection1.Application.get_model_listRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_model_list_with_indexes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.get_model_list_with_indexesResponse get_model_list_with_indexes(Dlubal.WS.RSection1.Application.get_model_list_with_indexesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_program_options", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.get_program_optionsResponse get_program_options(Dlubal.WS.RSection1.Application.get_program_optionsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_program_settings", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.get_program_settingsResponse get_program_settings(Dlubal.WS.RSection1.Application.get_program_settingsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_project", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.get_projectResponse get_project(Dlubal.WS.RSection1.Application.get_projectRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_session_id", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.get_session_idResponse get_session_id(Dlubal.WS.RSection1.Application.get_session_idRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/get_settings_program_language", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.get_settings_program_languageResponse get_settings_program_language(Dlubal.WS.RSection1.Application.get_settings_program_languageRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/import_from", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.import_fromResponse import_from(Dlubal.WS.RSection1.Application.import_fromRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/new_model", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.new_modelResponse new_model(Dlubal.WS.RSection1.Application.new_modelRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/new_model_as_copy", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.new_model_as_copyResponse new_model_as_copy(Dlubal.WS.RSection1.Application.new_model_as_copyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/new_model_from_template", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.new_model_from_templateResponse new_model_from_template(Dlubal.WS.RSection1.Application.new_model_from_templateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/new_project", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.new_projectResponse new_project(Dlubal.WS.RSection1.Application.new_projectRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/open_model", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.open_modelResponse open_model(Dlubal.WS.RSection1.Application.open_modelRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/save_model", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.save_modelResponse save_model(Dlubal.WS.RSection1.Application.save_modelRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/set_as_current_project", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.set_as_current_projectResponse set_as_current_project(Dlubal.WS.RSection1.Application.set_as_current_projectRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/set_detailed_logging", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.set_detailed_loggingResponse set_detailed_logging(Dlubal.WS.RSection1.Application.set_detailed_loggingRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/set_program_options", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.set_program_optionsResponse set_program_options(Dlubal.WS.RSection1.Application.set_program_optionsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/set_program_settings", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.set_program_settingsResponse set_program_settings(Dlubal.WS.RSection1.Application.set_program_settingsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8081/set_settings_program_language", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Dlubal.WS.RSection1.Application.set_settings_program_languageResponse set_settings_program_language(Dlubal.WS.RSection1.Application.set_settings_program_languageRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRSectionApplicationChannel : Dlubal.WS.RSection1.Application.IRSectionApplication, System.ServiceModel.IClientChannel
    {
    }
}
