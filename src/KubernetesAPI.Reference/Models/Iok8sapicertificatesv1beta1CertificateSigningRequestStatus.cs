// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kubeleans.KubernetesApi.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Iok8sapicertificatesv1beta1CertificateSigningRequestStatus
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicertificatesv1beta1CertificateSigningRequestStatus class.
        /// </summary>
        public Iok8sapicertificatesv1beta1CertificateSigningRequestStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicertificatesv1beta1CertificateSigningRequestStatus class.
        /// </summary>
        /// <param name="certificate">If request was approved, the controller
        /// will place the issued certificate here.</param>
        /// <param name="conditions">Conditions applied to the request, such as
        /// approval or denial.</param>
        public Iok8sapicertificatesv1beta1CertificateSigningRequestStatus(byte[] certificate = default(byte[]), IList<Iok8sapicertificatesv1beta1CertificateSigningRequestCondition> conditions = default(IList<Iok8sapicertificatesv1beta1CertificateSigningRequestCondition>))
        {
            Certificate = certificate;
            Conditions = conditions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets if request was approved, the controller will place the
        /// issued certificate here.
        /// </summary>
        [JsonProperty(PropertyName = "certificate")]
        public byte[] Certificate { get; set; }

        /// <summary>
        /// Gets or sets conditions applied to the request, such as approval or
        /// denial.
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public IList<Iok8sapicertificatesv1beta1CertificateSigningRequestCondition> Conditions { get; set; }

    }
}
