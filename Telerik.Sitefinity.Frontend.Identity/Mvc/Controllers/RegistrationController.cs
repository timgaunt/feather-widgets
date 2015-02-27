﻿using System.ComponentModel;
using System.Web.Mvc;
using Telerik.Sitefinity.Frontend.Identity.Mvc.Models.Registration;
using Telerik.Sitefinity.Frontend.Identity.Mvc.StringResources;
using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Controllers;
using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Controllers.Attributes;
using Telerik.Sitefinity.Mvc;

namespace Telerik.Sitefinity.Frontend.Identity.Mvc.Controllers
{
    /// <summary>
    /// This class represents the controller of the Registration widget.
    /// </summary>
    [Localization(typeof(RegistrationResources))]
    [ControllerToolboxItem(Name = "Registration", Title = "Registration", SectionName = "MvcWidgets")]
    public class RegistrationController : Controller
    {
        #region Properties

        /// <summary>
        /// Gets the Registration widget model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public virtual IRegistrationModel Model
        {
            get
            {
                if (this.model == null)
                    this.model = this.InitializeModel();

                return this.model;
            }
        }

        /// <summary>
        /// Gets or sets the name of the template that widget will be displayed.
        /// </summary>
        /// <value></value>
        public string TemplateName
        {
            get
            {
                return this.templateName;
            }

            set
            {
                this.templateName = value;
            }
        }

        #endregion

        #region Actions

        /// <summary>
        /// Renders appropriate list view depending on the <see cref="TemplateName" />
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult" />.
        /// </returns>
        public ActionResult Index()
        {
            var fullTemplateName = this.templateNamePrefix + this.TemplateName;
            var viewModel = this.Model.GetViewModel();
            return this.View(fullTemplateName, viewModel);
        }

        /// <summary>
        /// Does the actual user registration and redirects to the configured page.
        /// </summary>
        /// <param name="model">The registration form model.</param>
        /// <returns>
        /// The <see cref="ActionResult" />.
        /// </returns>
        [HttpPost]
        public ActionResult Index(RegistrationViewModel model)
        {
            // TODO: Register and redirect to specified page.
            return this.Content("Registered!");
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Initializes the model.
        /// </summary>
        /// <returns>
        /// The <see cref="IRegistrationModel"/>.
        /// </returns>
        private IRegistrationModel InitializeModel()
        {
            return ControllerModelFactory.GetModel<IRegistrationModel>(this.GetType());
        }

        #endregion

        #region Private fields and constants

        private string templateName = "RegistrationForm";
        private IRegistrationModel model;
        private string templateNamePrefix = "Registration.";

        #endregion
    }
}
