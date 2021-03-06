﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SingleSimple.cs" company="DHGMS Solutions">
//   2004-2012 DHGMS Solutions. Some Rights Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace TestDhgms.DataManagerMocking.Model.Info
{
        using System;
        using System.ComponentModel.DataAnnotations;
        using System.Data.Entity;
        using System.Diagnostics;
        using System.Diagnostics.CodeAnalysis;
        using System.Runtime.Serialization;
        using System.Xml;
        using System.Xml.Linq;

        // ********** WARNING **********
        // This code is automatically generated! Any Changes you make to this file will be lost!
        // To make changes edit the corresponding .tt file!

        /// <summary>
        /// Represents a class containing properties that are simple
        /// </summary>
        [DataContract]
        public class SingleSimple
// ReSharper disable RedundantNameQualifier
            : Dhgms.DataManager.Model.Info.Base<SingleSimple>
// ReSharper restore RedundantNameQualifier
        {
        #region fields
        #endregion

        // ********** WARNING **********
        // This code is automatically generated! Any Changes you make to this file will be lost!
        // To make changes edit the corresponding .tt file!

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleSimple"/> class.
        /// </summary>
        public SingleSimple()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleSimple"/> class.
        /// </summary>
        /// <param name="other">
        /// Object to copy
        /// </param>
        public SingleSimple(SingleSimple other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("other");
            }

            this.Id = other.Id;
            this.Name = other.Name;
        }

        // ********** WARNING **********
        // This code is automatically generated! Any Changes you make to this file will be lost!
        // To make changes edit the corresponding .tt file!

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleSimple"/> class.
        /// </summary>
        /// <param name="id">Unique Id</param>
        /// <param name="name">The Name</param>
        public SingleSimple(
            int id,
            string name)
            {
            this.Id = id;
            this.Name = name;
        }

            /// <summary>
            /// The on disposing event
            /// </summary>
            protected override void OnDisposing()
            {
            }
        #region properties
        /// <summary>
        /// Gets or sets Unique Id
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1121:UseBuiltInTypeAlias", Justification = "Reviewed. Suppression is OK here.")]
        [DataMember(IsRequired = true,Order = 1)]
        [Required]
[Range(typeof(int), "", "")]
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets The Name
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1121:UseBuiltInTypeAlias", Justification = "Reviewed. Suppression is OK here.")]
        [DataMember(IsRequired = true,Order = 2)]
        [Required]

        public string Name
        {
            get;
            set;
        }

            /// <summary>
            /// Gets a header record for use for something like a CSV file
            /// </summary>
            /// <returns>a collection of strings representing the header record</returns>
            public override System.Collections.Generic.IList<string> HeaderRecord
            {
                get
                {
                    var result = new System.Collections.Generic.List<string>
                    {
                        "Id",
                        "Name"
                    };

                    return result;
                }
            }

        #endregion

        #region IComparable methods

        // ********** WARNING **********
        // This code is automatically generated! Any Changes you make to this file will be lost!
        // To make changes edit the corresponding .tt file!

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="other">
        /// The instance to compare to
        /// </param>
        /// <returns>
        /// 0 if equal, otherwise non zero
        /// </returns>
        public override int CompareTo(SingleSimple other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("other");
            }

            // Id
            var checkResult = this.Id.CompareTo(other.Id);

            if (checkResult != 0)
            {
                return (checkResult > 0) ? 1 : -1;
            }

            // Name
            checkResult = string.CompareOrdinal(this.Name, other.Name);

            if (checkResult != 0)
            {
                return (checkResult > 0) ? 2 : -2;
            }

            return 0;
        }

        #endregion
#region IEquatable methods
            /// <summary>
            /// Checks if the current instance matches another of the same type
            /// </summary>
            /// <param name="other">object to compare</param>
            /// <returns>true if equal, otherwise false</returns>
            public override bool Equals(SingleSimple other)
            {
                return this.CompareTo(other) == 0;
            }

#endregion

    #region our methods

        /// <summary>
        /// Gets the hash code for the object
        /// </summary>
        /// <returns>hash code</returns>
        public override int GetHashCode()
        {
            return
                this.Id.GetHashCode()
                ^ (this.Name != null ? this.Name.GetHashCode() : 0);
        }

        /// <summary>
        /// Checks a table to ensure it meets the required schema
        /// </summary>
        public override void DoTableValidation()
        {
        }

            /// <summary>
            /// Gets a collection of string data for use for something like a CSV file
            /// </summary>
            /// <returns>a collection of strings representing the data record</returns>
            public override System.Collections.Generic.IList<string> ToStringArray()
            {
                var result = new System.Collections.Generic.List<string>
                {
                    this.Id.ToString(System.Globalization.CultureInfo.InvariantCulture),
                    this.Name
                };

                return result;
            }

            /// <summary>
            /// Adds an XML Element to an XML Writer
            /// </summary>
            /// <param name="writer">
            /// The XML writer to add the element to.
            /// </param>
            /// <param name="parentElementName">
            /// The name for the parenet element being produced.
            /// </param>
            public override void DoXmlElement(
                    System.Xml.XmlWriter writer,
                    string parentElementName)
            {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }

            if (string.IsNullOrEmpty(parentElementName) || parentElementName.Trim().Length == 0)
            {
            throw new ArgumentNullException("parentElementName");
            }

                writer.WriteStartElement(parentElementName);

                // Id
                this.DoChildXmlCDataElement(writer, "Id", this.Id.ToString(System.Globalization.CultureInfo.InvariantCulture));

                // Name
                this.DoChildXmlElement(writer, "Name", this.Name);

                writer.WriteEndElement();
            }

        /// <summary>
        /// Checks this instance against another to see where there are differences
        /// </summary>
        /// <param name="other">other instance to compare</param>
        /// <returns>summary of where there are differences</returns>
// ReSharper disable RedundantNameQualifier
        public TestDhgms.DataManagerMocking.Model.Difference.SingleSimpleDifference GetDifferences(SingleSimple other)
// ReSharper restore RedundantNameQualifier
        {
            if (other == null)
            {
                throw new System.ArgumentNullException("other");
            }

            // Id
            var checkResult = this.Id.CompareTo(other.Id);

            var id = checkResult != 0;

            // Name
            checkResult = string.CompareOrdinal(this.Name, other.Name);

            var name = checkResult != 0;

// ReSharper disable RedundantNameQualifier
            return new TestDhgms.DataManagerMocking.Model.Difference.SingleSimpleDifference(
// ReSharper restore RedundantNameQualifier
                id
                ,name
                );
        }

        /// <summary>
        /// Gets the CDSL that defines the OData Vocabularies for this class
        /// </summary>
        public static XmlReader GetOdataVocabularies()
        {
            // Id

            // Name

        var schema = new XElement(
            "Schema",
            new XAttribute("Namespace", "TestDhgms.DataManagerMocking"),
            new XAttribute("xmlns", "http://schemas.microsoft.com/ado/2009/11/edm"),
            // using directive
            new XElement(
                "Using",
                new XAttribute("Namespace", "Org.OData.Validation.V1"),
                new XAttribute("Alias", "Validation"),
                new XElement(
                    "Annotations",
                    new XAttribute("Target", "TestDhgms.DataManagerMocking.SingleSimple/Id")),
                new XElement(
                    "Annotations",
                    new XAttribute("Target", "TestDhgms.DataManagerMocking.SingleSimple/Name"))));

        Debug.Assert(schema.Document != null, "schema.Document != null");
        return schema.Document.CreateReader();
        }
        #endregion
    }
}

namespace TestDhgms.DataManagerMocking.Model.ViewFilter
{
        using System;
        using System.ComponentModel.DataAnnotations;
        using System.Data.Entity;
        using System.Diagnostics;
        using System.Diagnostics.CodeAnalysis;
        using System.Runtime.Serialization;
        using System.Xml;
        using System.Xml.Linq;

        // ********** WARNING **********
        // This code is automatically generated! Any Changes you make to this file will be lost!
        // To make changes edit the corresponding .tt file!

        /// <summary>
        /// Represents a class containing properties that are simple
        /// </summary>
        [DataContract]
        public class SingleSimpleViewFilter
// ReSharper disable RedundantNameQualifier
            : Dhgms.DataManager.Model.Info.ViewFilter<SingleSimpleViewFilter>
// ReSharper restore RedundantNameQualifier
        {
        // ********** WARNING **********
        // This code is automatically generated! Any Changes you make to this file will be lost!
        // To make changes edit the corresponding .tt file!

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleSimpleViewFilter"/> class.
        /// </summary>
        public SingleSimpleViewFilter() : base(1,0)
        {
        }

        // ********** WARNING **********
        // This code is automatically generated! Any Changes you make to this file will be lost!
        // To make changes edit the corresponding .tt file!

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleSimpleViewFilter"/> class.
        /// </summary>
        /// <param name="id">Unique Id</param>
        /// <param name="name">The Name</param>
        /// <param name="pageNumber">The number of the page being retrieved</param>
        /// <param name="pageSize">The size of pages being retrieved</param>
        public SingleSimpleViewFilter(
            bool id,
            bool name,
            int pageNumber,
            int pageSize)
            : base(
                pageNumber,
                pageSize
                )
        {
            this.Id = id;
            this.Name = name;
        }

            /// <summary>
            /// The on disposing event
            /// </summary>
            protected override void OnDisposing()
            {
            }
        #region properties
        /// <summary>
        /// Unique Id
        /// </summary>
        public bool Id
        {
            get;
            set;
        }

        /// <summary>
        /// The Name
        /// </summary>
        public bool Name
        {
            get;
            set;
        }

            /// <summary>
            /// Gets a header record for use for something like a CSV file
            /// </summary>
            /// <returns>a collection of strings representing the header record</returns>
            public override System.Collections.Generic.IList<string> HeaderRecord
            {
                get
                {
                    var result = new System.Collections.Generic.List<string>
                    {
                        "Id",
                        "Name"
                    };

                    return result;
                }
            }

        #endregion

        #region IComparable methods

        // ********** WARNING **********
        // This code is automatically generated! Any Changes you make to this file will be lost!
        // To make changes edit the corresponding .tt file!

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="other">
        /// The instance to compare to
        /// </param>
        /// <returns>
        /// 0 if equal, otherwise non zero
        /// </returns>
        public override int CompareTo(SingleSimpleViewFilter other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("other");
            }

            int checkResult = Id.CompareTo(other.Id);
            if(checkResult != 0)
            {
                return (checkResult > 0) ? 1 : -1;
            }

            checkResult = Name.CompareTo(other.Name);
            if(checkResult != 0)
            {
                return (checkResult > 0) ? 2 : -2;
            }

            return 0;
        }

        #endregion
#region IEquatable methods
            /// <summary>
            /// Checks if the current instance matches another of the same type
            /// </summary>
            /// <param name="other">object to compare</param>
            /// <returns>true if equal, otherwise false</returns>
            public override bool Equals(SingleSimpleViewFilter other)
            {
                return this.CompareTo(other) == 0;
            }

#endregion

    #region our methods

        /// <summary>
        /// Gets the hash code for the object
        /// </summary>
        /// <returns>hash code</returns>
        public override int GetHashCode()
        {
            return
                this.Id.GetHashCode()
                ^ (this.Name != null ? this.Name.GetHashCode() : 0);
        }

        /// <summary>
        /// Checks a table to ensure it meets the required schema
        /// </summary>
        public override void DoTableValidation()
        {
        }

            /// <summary>
            /// Gets a collection of string data for use for something like a CSV file
            /// </summary>
            /// <returns>a collection of strings representing the data record</returns>
            public override System.Collections.Generic.IList<string> ToStringArray()
            {
                var result = new System.Collections.Generic.List<string>
                {
                    this.Id? "1" : "0",
                    this.Name? "1" : "0"
                };

                return result;
            }

            /// <summary>
            /// Adds an XML Element to an XML Writer
            /// </summary>
            /// <param name="writer">
            /// The XML writer to add the element to.
            /// </param>
            /// <param name="parentElementName">
            /// The name for the parenet element being produced.
            /// </param>
            public override void DoXmlElement(
                    System.Xml.XmlWriter writer,
                    string parentElementName)
            {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }

            if (string.IsNullOrEmpty(parentElementName) || parentElementName.Trim().Length == 0)
            {
            throw new ArgumentNullException("parentElementName");
            }

                writer.WriteStartElement(parentElementName);

                // Id
                this.DoChildXmlCDataElement(writer, "Id", this.Id? "1" : "0");

                // Name
                this.DoChildXmlElement(writer, "Name", this.Name? "1" : "0");

                writer.WriteEndElement();
            }

        /// <summary>
        /// Gets a comma separated list of column names
        /// </summary>
        /// <returns>a comma separated list of column names</returns>
        public override string GetSelectedColumnNames()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string comma = null;
            // Id
            if (Id)
            {
                sb.AppendLine("Id");

                comma = ",";
            }
            // Name
            if (Name)
            {
                sb.AppendLine(comma + "Name");

                if(comma == null)
                {
                    comma = ",";
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Gets the CDSL that defines the OData Vocabularies for this class
        /// </summary>
        public static XmlReader GetOdataVocabularies()
        {
            // Id

            // Name

        var schema = new XElement(
            "Schema",
            new XAttribute("Namespace", "TestDhgms.DataManagerMocking"),
            new XAttribute("xmlns", "http://schemas.microsoft.com/ado/2009/11/edm"),
            // using directive
            new XElement(
                "Using",
                new XAttribute("Namespace", "Org.OData.Validation.V1"),
                new XAttribute("Alias", "Validation"),
                new XElement(
                    "Annotations",
                    new XAttribute("Target", "TestDhgms.DataManagerMocking.SingleSimple/Id")),
                new XElement(
                    "Annotations",
                    new XAttribute("Target", "TestDhgms.DataManagerMocking.SingleSimple/Name"))));

        Debug.Assert(schema.Document != null, "schema.Document != null");
        return schema.Document.CreateReader();
        }
        #endregion
    }
}

namespace TestDhgms.DataManagerMocking.Model.Difference
{
        using System;
        using System.ComponentModel.DataAnnotations;
        using System.Data.Entity;
        using System.Diagnostics;
        using System.Diagnostics.CodeAnalysis;
        using System.Runtime.Serialization;
        using System.Xml;
        using System.Xml.Linq;

        // ********** WARNING **********
        // This code is automatically generated! Any Changes you make to this file will be lost!
        // To make changes edit the corresponding .tt file!

        /// <summary>
        /// Represents a class containing properties that are simple
        /// </summary>
        [DataContract]
        public class SingleSimpleDifference
// ReSharper disable RedundantNameQualifier
            : Dhgms.DataManager.Model.Info.Difference<SingleSimpleDifference>
// ReSharper restore RedundantNameQualifier
        {
        // ********** WARNING **********
        // This code is automatically generated! Any Changes you make to this file will be lost!
        // To make changes edit the corresponding .tt file!

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleSimpleDifference"/> class.
        /// </summary>
        public SingleSimpleDifference()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleSimpleDifference"/> class.
        /// </summary>
        /// <param name="other">
        /// Object to copy
        /// </param>
        public SingleSimpleDifference(SingleSimpleDifference other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("other");
            }

            this.Id = other.Id;
            this.Name = other.Name;
        }

        // ********** WARNING **********
        // This code is automatically generated! Any Changes you make to this file will be lost!
        // To make changes edit the corresponding .tt file!

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleSimpleDifference"/> class.
        /// </summary>
        /// <param name="id">Unique Id</param>
        /// <param name="name">The Name</param>
        public SingleSimpleDifference(
            bool id,
            bool name)
            {
            this.Id = id;
            this.Name = name;
        }

            /// <summary>
            /// The on disposing event
            /// </summary>
            protected override void OnDisposing()
            {
            }
        #region properties
        /// <summary>
        /// Unique Id
        /// </summary>
        public bool Id
        {
            get;
            set;
        }

        /// <summary>
        /// The Name
        /// </summary>
        public bool Name
        {
            get;
            set;
        }

            /// <summary>
            /// Gets a header record for use for something like a CSV file
            /// </summary>
            /// <returns>a collection of strings representing the header record</returns>
            public override System.Collections.Generic.IList<string> HeaderRecord
            {
                get
                {
                    var result = new System.Collections.Generic.List<string>
                    {
                        "Id",
                        "Name"
                    };

                    return result;
                }
            }

            /// <summary>
            /// Gets the number of properties that are different
            /// </summary>
            /// <return>
            /// the number of properties that are different
            /// </return>
            public override int Count
            {
                get
                {
                    return
                    ((Id) ? 1 : 0)
                    + ((Name) ? 1 : 0)
                    ;
                }
            }

        #endregion

        #region IComparable methods

        // ********** WARNING **********
        // This code is automatically generated! Any Changes you make to this file will be lost!
        // To make changes edit the corresponding .tt file!

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="other">
        /// The instance to compare to
        /// </param>
        /// <returns>
        /// 0 if equal, otherwise non zero
        /// </returns>
        public override int CompareTo(SingleSimpleDifference other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("other");
            }

            int             checkResult = Id.CompareTo(other.Id);
            if(checkResult != 0)
            {
                return (checkResult > 0) ? 1 : -1;
            }

                        checkResult = Name.CompareTo(other.Name);
            if(checkResult != 0)
            {
                return (checkResult > 0) ? 2 : -2;
            }

            return 0;
        }

        #endregion
#region IEquatable methods
            /// <summary>
            /// Checks if the current instance matches another of the same type
            /// </summary>
            /// <param name="other">object to compare</param>
            /// <returns>true if equal, otherwise false</returns>
            public override bool Equals(SingleSimpleDifference other)
            {
                return this.CompareTo(other) == 0;
            }

#endregion

    #region our methods

        /// <summary>
        /// Gets the hash code for the object
        /// </summary>
        /// <returns>hash code</returns>
        public override int GetHashCode()
        {
            return
                this.Id.GetHashCode()
                ^ this.Name.GetHashCode();
        }

        /// <summary>
        /// Checks a table to ensure it meets the required schema
        /// </summary>
        public override void DoTableValidation()
        {
        }

            /// <summary>
            /// Gets a collection of string data for use for something like a CSV file
            /// </summary>
            /// <returns>a collection of strings representing the data record</returns>
            public override System.Collections.Generic.IList<string> ToStringArray()
            {
                var result = new System.Collections.Generic.List<string>
                {
                    this.Id ? "1" : "0",
                    this.Name ? "1" : "0"
                };

                return result;
            }

            /// <summary>
            /// Adds an XML Element to an XML Writer
            /// </summary>
            /// <param name="writer">
            /// The XML writer to add the element to.
            /// </param>
            /// <param name="parentElementName">
            /// The name for the parenet element being produced.
            /// </param>
            public override void DoXmlElement(
                    System.Xml.XmlWriter writer,
                    string parentElementName)
            {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }

            if (string.IsNullOrEmpty(parentElementName) || parentElementName.Trim().Length == 0)
            {
            throw new ArgumentNullException("parentElementName");
            }

                writer.WriteStartElement(parentElementName);

                // Id
                this.DoChildXmlCDataElement(writer, "Id", this.Id ? "1" : "0");

                // Name
                this.DoChildXmlElement(writer, "Name", this.Name ? "1" : "0");

                writer.WriteEndElement();
            }


        /// <summary>
        /// Gets the names of the columns that are different
        /// </summary>
        /// <returns>
        /// list of names of the columns that are different
        /// </returns>
        public override System.Collections.Generic.IList<string> GetColumnNames()
        {
            var columns = new System.Collections.Generic.List<string>();
            if (this.Id)
            {
                columns.Add("Id");
            }

            if (this.Name)
            {
                columns.Add("Name");
            }

            return columns;
        }

        /// <summary>
        /// Gets the CDSL that defines the OData Vocabularies for this class
        /// </summary>
        public static XmlReader GetOdataVocabularies()
        {
            // Id

            // Name

        var schema = new XElement(
            "Schema",
            new XAttribute("Namespace", "TestDhgms.DataManagerMocking"),
            new XAttribute("xmlns", "http://schemas.microsoft.com/ado/2009/11/edm"),
            // using directive
            new XElement(
                "Using",
                new XAttribute("Namespace", "Org.OData.Validation.V1"),
                new XAttribute("Alias", "Validation"),
                new XElement(
                    "Annotations",
                    new XAttribute("Target", "TestDhgms.DataManagerMocking.SingleSimple/Id")),
                new XElement(
                    "Annotations",
                    new XAttribute("Target", "TestDhgms.DataManagerMocking.SingleSimple/Name"))));

        Debug.Assert(schema.Document != null, "schema.Document != null");
        return schema.Document.CreateReader();
        }
        #endregion
    }
}
