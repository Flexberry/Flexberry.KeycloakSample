﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TV.KeycloakSample
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Request person data.
    /// </summary>
    // *** Start programmer edit section *** (RequestPersonData CustomAttributes)

    // *** End programmer edit section *** (RequestPersonData CustomAttributes)
    [AutoAltered()]
    [Caption("Request person data")]
    [AccessType(ICSSoft.STORMNET.AccessType.@this)]
    [View("RequestPersonDataE", new string[] {
            "Body as \'Body\'",
            "Result as \'Result\'",
            "Person as \'Person\'",
            "Person.EsiaId as \'Esia id\'"}, Hidden=new string[] {
            "Person.EsiaId"})]
    [MasterViewDefineAttribute("RequestPersonDataE", "Person", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "EsiaId")]
    [View("RequestPersonDataL", new string[] {
            "Body as \'Body\'",
            "Result as \'Result\'",
            "Person.EsiaId as \'Esia id\'"})]
    public class RequestPersonData : ICSSoft.STORMNET.DataObject
    {
        
        private string fBody;
        
        private string fResult;
        
        private TV.KeycloakSample.Person fPerson;
        
        // *** Start programmer edit section *** (RequestPersonData CustomMembers)

        // *** End programmer edit section *** (RequestPersonData CustomMembers)

        
        /// <summary>
        /// Body.
        /// </summary>
        // *** Start programmer edit section *** (RequestPersonData.Body CustomAttributes)

        // *** End programmer edit section *** (RequestPersonData.Body CustomAttributes)
        [StrLen(255)]
        public virtual string Body
        {
            get
            {
                // *** Start programmer edit section *** (RequestPersonData.Body Get start)

                // *** End programmer edit section *** (RequestPersonData.Body Get start)
                string result = this.fBody;
                // *** Start programmer edit section *** (RequestPersonData.Body Get end)

                // *** End programmer edit section *** (RequestPersonData.Body Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (RequestPersonData.Body Set start)

                // *** End programmer edit section *** (RequestPersonData.Body Set start)
                this.fBody = value;
                // *** Start programmer edit section *** (RequestPersonData.Body Set end)

                // *** End programmer edit section *** (RequestPersonData.Body Set end)
            }
        }
        
        /// <summary>
        /// Result.
        /// </summary>
        // *** Start programmer edit section *** (RequestPersonData.Result CustomAttributes)

        // *** End programmer edit section *** (RequestPersonData.Result CustomAttributes)
        [StrLen(255)]
        public virtual string Result
        {
            get
            {
                // *** Start programmer edit section *** (RequestPersonData.Result Get start)

                // *** End programmer edit section *** (RequestPersonData.Result Get start)
                string result = this.fResult;
                // *** Start programmer edit section *** (RequestPersonData.Result Get end)

                // *** End programmer edit section *** (RequestPersonData.Result Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (RequestPersonData.Result Set start)

                // *** End programmer edit section *** (RequestPersonData.Result Set start)
                this.fResult = value;
                // *** Start programmer edit section *** (RequestPersonData.Result Set end)

                // *** End programmer edit section *** (RequestPersonData.Result Set end)
            }
        }
        
        /// <summary>
        /// Request person data.
        /// </summary>
        // *** Start programmer edit section *** (RequestPersonData.Person CustomAttributes)

        // *** End programmer edit section *** (RequestPersonData.Person CustomAttributes)
        [PropertyStorage(new string[] {
                "Person"})]
        public virtual TV.KeycloakSample.Person Person
        {
            get
            {
                // *** Start programmer edit section *** (RequestPersonData.Person Get start)

                // *** End programmer edit section *** (RequestPersonData.Person Get start)
                TV.KeycloakSample.Person result = this.fPerson;
                // *** Start programmer edit section *** (RequestPersonData.Person Get end)

                // *** End programmer edit section *** (RequestPersonData.Person Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (RequestPersonData.Person Set start)

                // *** End programmer edit section *** (RequestPersonData.Person Set start)
                this.fPerson = value;
                // *** Start programmer edit section *** (RequestPersonData.Person Set end)

                // *** End programmer edit section *** (RequestPersonData.Person Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "RequestPersonDataE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View RequestPersonDataE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("RequestPersonDataE", typeof(TV.KeycloakSample.RequestPersonData));
                }
            }
            
            /// <summary>
            /// "RequestPersonDataL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View RequestPersonDataL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("RequestPersonDataL", typeof(TV.KeycloakSample.RequestPersonData));
                }
            }
        }
    }
}
