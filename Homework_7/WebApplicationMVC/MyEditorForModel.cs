using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Options;
using WebApplicationMVC.Models;

namespace WebApplicationMVC
{
    public static class Extensions
    {
        public static IHtmlContent MyEditorModel(this IHtmlHelper htmlHelper)
        {
            return new MyEditorForModels(htmlHelper.ViewData.Model! ?? htmlHelper.ViewData.ModelMetadata.ModelType
                .GetConstructor(Array.Empty<Type>())
                ?.Invoke(Array.Empty<object>()));
        }
    }
    public class MyEditorForModels : IHtmlContent
    {
        private object _model;
        private Type _type;
        private readonly StringBuilder _resultBuilder = new StringBuilder();
        
        public MyEditorForModels(object model)
        {
            _model = model;
            _type = model.GetType();
            CreateForms(model);
        }
        private void CreateForms(object model)
        {
            foreach (var property in _type.GetProperties())
            {
                _resultBuilder.Append(CreateDiv(property, model));
            }
        }
        private static IHtmlContent CreateLabel(PropertyInfo propertyInfo)
        {
            var label = new TagBuilder("label");
            
            return label;
        }
        private static IHtmlContent CreateDiv(PropertyInfo propertyInfo, object model)
        {
            var div = new TagBuilder("div");
            div.InnerHtml.AppendHtml(propertyInfo.PropertyType.IsEnum
                ? CreateEnum(propertyInfo)
                : CreateInput(propertyInfo, model));
            return div;
        }
        private static IHtmlContent CreateSelect(PropertyInfo propertyInfo)
        {
            var select = new TagBuilder("select");
            select.Attributes.Add("id", propertyInfo.Name);
            select.Attributes.Add("name", propertyInfo.Name);
            return select;
        }

        private static IHtmlContent CreateEnum(MemberInfo fieldInfo)
        {
            var options = new TagBuilder("options");
            options.Attributes.Add("value", fieldInfo.Name);
            return options;
        }
        private static IHtmlContent CreateInput(PropertyInfo propertyInfo, object model)
        {
            var input = new TagBuilder("input");
            input.Attributes.Add("class", "btn btn-primary");
            input.Attributes.Add("id", propertyInfo.Name);
            input.Attributes.Add("name", propertyInfo.Name);
            input.Attributes.Add("type", propertyInfo.Name);
            input.Attributes.Add("value",propertyInfo.GetValue(model)?.ToString());
            return input;
        }
        public void WriteTo(TextWriter writer, HtmlEncoder encoder)
        {
            Console.WriteLine(_resultBuilder.ToString());
        }
    }
}