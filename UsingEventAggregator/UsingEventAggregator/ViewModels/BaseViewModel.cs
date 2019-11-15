using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace UsingEventAggregator
{
    public class BaseViewModel : BindableBase, INavigationAware, IDisposable
    {
        #region Properties

        private string _title;
        public string Title {
        	get { return _title; }
        	set { SetProperty (ref _title, value); }
        }

        #endregion

        #region INavigationAware

        public virtual void OnNavigatedFrom(INavigationParameters parameters) { }

        public virtual void OnNavigatedTo(INavigationParameters parameters) { }

        public virtual void OnNavigatingTo(INavigationParameters parameters) { }

        #endregion

        #region IDisposable

        private bool _isDisposed = false;
        public virtual void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_isDisposed) return;

            if (disposing)
            {
                // Managed
            }

            // Unmanaged
            _isDisposed = true;
        }
        
        #endregion

    }
}
