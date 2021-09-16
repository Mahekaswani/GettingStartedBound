using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace GettingStartedBound
{
    public class FileManager : INotifyPropertyChanged
    {
        #region Fields

        private string itemName;
        private ImageSource imageIcon;
        private ObservableCollection<FileManager> subFiles;
        private ObservableCollection<Tags> tagList;


        #endregion

        #region Constructor
        public FileManager()
        {
        }

        #endregion

        #region Properties
        public ObservableCollection<FileManager> SubFiles
        {
            get { return subFiles; }
            set
            {
                subFiles = value;
                RaisedOnPropertyChanged("SubFiles");
            }
        }

        public string ItemName
        {
            get { return itemName; }
            set
            {
                itemName = value;
                RaisedOnPropertyChanged("ItemName");
            }
        }
        public ImageSource ImageIcon
        {
            get { return imageIcon; }
            set
            {
                imageIcon = value;
                RaisedOnPropertyChanged("ImageIcon");
            }
        }

        public ObservableCollection<Tags> TagList
        {
            get { return tagList; }
            set
            {
                tagList = value;
                RaisedOnPropertyChanged("TagList");
            }
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }

        #endregion
    }
    public class Tags : INotifyPropertyChanged
    {
        private string tagName;
        private string updatedName;

        public string TagName
        {
            get { return tagName; }
            set
            {
                if (tagName != value)
                {
                    tagName = value;
                    this.RaisedOnPropertyChanged("TagName");
                }
            }
        }

        public string UpdatedName
        {
            get { return updatedName; }
            set
            {
                if (updatedName != value)
                {
                    updatedName = value;
                    this.RaisedOnPropertyChanged("UpdatedName");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }
    }
}