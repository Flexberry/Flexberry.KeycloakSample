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
    /// Chat bot message.
    /// </summary>
    // *** Start programmer edit section *** (ChatBotMessage CustomAttributes)

    // *** End programmer edit section *** (ChatBotMessage CustomAttributes)
    [AutoAltered()]
    [Caption("Chat bot message")]
    [AccessType(ICSSoft.STORMNET.AccessType.@base)]
    [View("ChatBotMessageE", new string[] {
            "DateTime as \'Date time\'",
            "Text as \'Text\'",
            "ChatMessageType as \'Chat message type\'",
            "Person as \'Person\'",
            "Person.EsiaId as \'Esia id\'"}, Hidden=new string[] {
            "Person.EsiaId"})]
    [MasterViewDefineAttribute("ChatBotMessageE", "Person", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "EsiaId")]
    [View("ChatBotMessageL", new string[] {
            "DateTime as \'Date time\'",
            "Text as \'Text\'",
            "ChatMessageType as \'Chat message type\'",
            "Person.EsiaId as \'Esia id\'"})]
    public class ChatBotMessage : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fDateTime = System.DateTime.UtcNow;
        
        private string fText;
        
        private TV.KeycloakSample.ChatMessageType fChatMessageType;
        
        private TV.KeycloakSample.Person fPerson;
        
        // *** Start programmer edit section *** (ChatBotMessage CustomMembers)

        // *** End programmer edit section *** (ChatBotMessage CustomMembers)

        
        /// <summary>
        /// DateTime.
        /// </summary>
        // *** Start programmer edit section *** (ChatBotMessage.DateTime CustomAttributes)

        // *** End programmer edit section *** (ChatBotMessage.DateTime CustomAttributes)
        public virtual System.DateTime DateTime
        {
            get
            {
                // *** Start programmer edit section *** (ChatBotMessage.DateTime Get start)

                // *** End programmer edit section *** (ChatBotMessage.DateTime Get start)
                System.DateTime result = this.fDateTime;
                // *** Start programmer edit section *** (ChatBotMessage.DateTime Get end)

                // *** End programmer edit section *** (ChatBotMessage.DateTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ChatBotMessage.DateTime Set start)

                // *** End programmer edit section *** (ChatBotMessage.DateTime Set start)
                this.fDateTime = value;
                // *** Start programmer edit section *** (ChatBotMessage.DateTime Set end)

                // *** End programmer edit section *** (ChatBotMessage.DateTime Set end)
            }
        }
        
        /// <summary>
        /// Text.
        /// </summary>
        // *** Start programmer edit section *** (ChatBotMessage.Text CustomAttributes)

        // *** End programmer edit section *** (ChatBotMessage.Text CustomAttributes)
        [StrLen(255)]
        public virtual string Text
        {
            get
            {
                // *** Start programmer edit section *** (ChatBotMessage.Text Get start)

                // *** End programmer edit section *** (ChatBotMessage.Text Get start)
                string result = this.fText;
                // *** Start programmer edit section *** (ChatBotMessage.Text Get end)

                // *** End programmer edit section *** (ChatBotMessage.Text Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ChatBotMessage.Text Set start)

                // *** End programmer edit section *** (ChatBotMessage.Text Set start)
                this.fText = value;
                // *** Start programmer edit section *** (ChatBotMessage.Text Set end)

                // *** End programmer edit section *** (ChatBotMessage.Text Set end)
            }
        }
        
        /// <summary>
        /// ChatMessageType.
        /// </summary>
        // *** Start programmer edit section *** (ChatBotMessage.ChatMessageType CustomAttributes)

        // *** End programmer edit section *** (ChatBotMessage.ChatMessageType CustomAttributes)
        public virtual TV.KeycloakSample.ChatMessageType ChatMessageType
        {
            get
            {
                // *** Start programmer edit section *** (ChatBotMessage.ChatMessageType Get start)

                // *** End programmer edit section *** (ChatBotMessage.ChatMessageType Get start)
                TV.KeycloakSample.ChatMessageType result = this.fChatMessageType;
                // *** Start programmer edit section *** (ChatBotMessage.ChatMessageType Get end)

                // *** End programmer edit section *** (ChatBotMessage.ChatMessageType Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ChatBotMessage.ChatMessageType Set start)

                // *** End programmer edit section *** (ChatBotMessage.ChatMessageType Set start)
                this.fChatMessageType = value;
                // *** Start programmer edit section *** (ChatBotMessage.ChatMessageType Set end)

                // *** End programmer edit section *** (ChatBotMessage.ChatMessageType Set end)
            }
        }
        
        /// <summary>
        /// Chat bot message.
        /// </summary>
        // *** Start programmer edit section *** (ChatBotMessage.Person CustomAttributes)

        // *** End programmer edit section *** (ChatBotMessage.Person CustomAttributes)
        [PropertyStorage(new string[] {
                "Person"})]
        [NotNull()]
        public virtual TV.KeycloakSample.Person Person
        {
            get
            {
                // *** Start programmer edit section *** (ChatBotMessage.Person Get start)

                // *** End programmer edit section *** (ChatBotMessage.Person Get start)
                TV.KeycloakSample.Person result = this.fPerson;
                // *** Start programmer edit section *** (ChatBotMessage.Person Get end)

                // *** End programmer edit section *** (ChatBotMessage.Person Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ChatBotMessage.Person Set start)

                // *** End programmer edit section *** (ChatBotMessage.Person Set start)
                this.fPerson = value;
                // *** Start programmer edit section *** (ChatBotMessage.Person Set end)

                // *** End programmer edit section *** (ChatBotMessage.Person Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ChatBotMessageE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ChatBotMessageE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ChatBotMessageE", typeof(TV.KeycloakSample.ChatBotMessage));
                }
            }
            
            /// <summary>
            /// "ChatBotMessageL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ChatBotMessageL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ChatBotMessageL", typeof(TV.KeycloakSample.ChatBotMessage));
                }
            }
        }
    }
}
