using System.Web;
using System.Web.Optimization;

namespace WebApplication1
{
	public class BundleConfig
	{
		// バンドルの詳細については、http://go.microsoft.com/fwlink/?LinkId=301862  を参照してください
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
						"~/Scripts/jquery.validate*"));

			// 開発と学習には、Modernizr の開発バージョンを使用します。次に、実稼働の準備が
			// できたら、http://modernizr.com にあるビルド ツールを使用して、必要なテストのみを選択します。
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
						"~/Scripts/modernizr-*"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
					  "~/Scripts/bootstrap.js",
					  "~/Scripts/respond.js",
					  "~/Scripts/loader.js"));

			bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
					  "~/Scripts/knockout-{version}.js",
					  "~/Scripts/koGrid-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/sample").Include(
					  "~/Scripts/main.js",
					  "~/Scripts/test.js"));


			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/bootstrap.css",
					  "~/Content/site.css",
					  "~/Content/style.css",
					  "~/Content/fuelux.min.css",
					  "~/Content/koGrid.css"));

			// デバッグを行うには EnableOptimizations を false に設定します。詳細については、
			// http://go.microsoft.com/fwlink/?LinkId=301862 を参照してください
			BundleTable.EnableOptimizations = false;
		}
	}
}
