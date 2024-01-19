using AutoMapper;

using MCT.CCAlib.Models.customdb;
using MCT.CCAlib.Models.customdb.dto;

namespace MCT.ManagedCareAPI.BaseClasses
{
    // TODO : Comments
    /// <summary>
    /// 
    /// </summary>
    public class CCALibMappingConfig : Profile
    {
        // TODO : Comments
        /// <summary>
        /// 
        /// </summary>
        public CCALibMappingConfig()
        {
            #region ehtt_ext_common_process_param
            CreateMap<EhttExtCommonProcessParam, EhttExtCommonProcessParamDTO>();
            CreateMap<EhttExtCommonProcessParamDTO, EhttExtCommonProcessParam>();

            CreateMap<EhttExtCommonProcessParam, EhttExtCommonProcessParamCreateDTO>().ReverseMap();
            CreateMap<EhttExtCommonProcessParam, EhttExtCommonProcessParamUpdateDTO>().ReverseMap();
            #endregion ehtt_ext_common_process_param

            #region Assessment Manager
            #region T1468AssessmentManagerAssessment
            CreateMap<T1468AssessmentManagerAssessment, T1468AssessmentManagerAssessmentDTO>();
            CreateMap<T1468AssessmentManagerAssessmentDTO, T1468AssessmentManagerAssessment>();

            CreateMap<T1468AssessmentManagerAssessment, T1468AssessmentManagerAssessmentCreateDTO>().ReverseMap();
            CreateMap<T1468AssessmentManagerAssessment, T1468AssessmentManagerAssessmentUpdateDTO>().ReverseMap();
            #endregion T1468AssessmentManagerAssessment

            #region T1468AssessmentManagerQuestion
            CreateMap<T1468AssessmentManagerQuestion, T1468AssessmentManagerQuestionDTO>();
            CreateMap<T1468AssessmentManagerQuestionDTO, T1468AssessmentManagerQuestion>();

            CreateMap<T1468AssessmentManagerQuestion, T1468AssessmentManagerQuestionCreateDTO>().ReverseMap();
            CreateMap<T1468AssessmentManagerQuestion, T1468AssessmentManagerQuestionUpdateDTO>().ReverseMap();
            #endregion T1468AssessmentManagerQuestion

            #region T1468AssessmentManagerAnswer
            CreateMap<T1468AssessmentManagerAnswer, T1468AssessmentManagerAnswerDTO>();
            CreateMap<T1468AssessmentManagerAnswerDTO, T1468AssessmentManagerAnswer>();

            CreateMap<T1468AssessmentManagerAnswer, T1468AssessmentManagerAnswerCreateDTO>().ReverseMap();
            CreateMap<T1468AssessmentManagerAnswer, T1468AssessmentManagerAnswerUpdateDTO>().ReverseMap();
            #endregion T1468AssessmentManagerAnswer

            #region T1468AssessmentManagerQuestionAnswerLink
            CreateMap<T1468AssessmentManagerQuestionAnswerLink, T1468AssessmentManagerQuestionAnswerLinkDTO>();
            CreateMap<T1468AssessmentManagerQuestionAnswerLinkDTO, T1468AssessmentManagerQuestionAnswerLink>();

            CreateMap<T1468AssessmentManagerQuestionAnswerLink, T1468AssessmentManagerQuestionAnswerLinkCreateDTO>().ReverseMap();
            CreateMap<T1468AssessmentManagerQuestionAnswerLink, T1468AssessmentManagerQuestionAnswerLinkUpdateDTO>().ReverseMap();
            #endregion T1468AssessmentManagerQuestionAnswerLink
            #endregion Assessment Manager
        }
    }
}
