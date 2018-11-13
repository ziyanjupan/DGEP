using Abp.Web.Mvc.Views;

namespace QGEP.Web.Views
{
    public abstract class QGEPWebViewPageBase : QGEPWebViewPageBase<dynamic>
    {

    }

    public abstract class QGEPWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected QGEPWebViewPageBase()
        {
            LocalizationSourceName = QGEPConsts.LocalizationSourceName;
        }
    }
}