/**************************************************
* 创建作者：	咕咕咕
* 创建时间：	2020-12-31
* 作用描述：	#工厂接口
***************************************************/

namespace Utils
{
	public interface IFactory<T>
	{
		T Create();
	}
}