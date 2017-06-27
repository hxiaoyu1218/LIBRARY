using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateStructure
{
    /// <summary>
    /// 字典树节点类，使用map映射支持中文
    /// </summary>
    /// <typeparam name="Type">字典树节点指向的信息类型</typeparam>
    internal class DicTreeNode<Type>
        where Type : IComparable
    {
        internal char name;
        internal List<Type> diclist;
        internal Dictionary<char, DicTreeNode<Type>> next;

        /// <summary>
        /// 构造函数，传入节点名字
        /// </summary>
        /// <param name="c"></param>
        internal DicTreeNode(char c)
        {
            name = c;
            diclist = new List<Type>();
            next = new Dictionary<char, DicTreeNode<Type>>();
        }

    }
    /// <summary>
    /// 字典树，使用map以支持中文
    /// </summary>
    /// <typeparam name="Type">字典树节点指向的信息类型</typeparam>
    public class DicTree<Type> where Type : IComparable
    {
        private DicTreeNode<Type> root;
        /// <summary>
        /// 构造函数，只负责产生根节点
        /// </summary>
        public DicTree()
        {
            //根节点用特殊字符标识，作为所有字符串的公共前缀
            root = new DicTreeNode<Type>('$');
        }
        /// <summary>
        /// 插入函数
        /// </summary>
        /// <param name="s">待插入的字符串</param>
        /// <param name="val">字符串指向的信息</param>
        public void Insert(string s, Type val)
        {
            DicTreeNode<Type> now = root;
            for (int i = 0; i < s.Length; i++)
            {
                char tmp = s[i];
                if (now.next.ContainsKey(tmp)) now = now.next[tmp];
                else
                {
                    now.next.Add(s[i], new DicTreeNode<Type>(tmp));
                    now = now.next[tmp];
                }
            }
            now.diclist.Add(val);
        }
        /// <summary>
        /// 查找函数
        /// </summary>
        /// <param name="s">待查询的字符串</param>
        /// <returns>返回结果数组</returns>
        public List<Type> Find(string s)
        {
            List<Type> res = new List<Type>();
            DicTreeNode<Type> now = root;

            for (int i = 0; i < s.Length; i++)
            {
                char tmp = s[i];
                if (!now.next.ContainsKey(tmp)) return null;
                else
                {
                    now = now.next[tmp];
                }
            }
            AddToRes(now, ref res);
            return res;
        }
        /// <summary>
        /// 删除函数
        /// </summary>
        /// <param name="s">待删除的字符串</param>
        /// <param name="val">字符串对应的节点</param>
        /// <returns>成功/失败</returns>
        public bool Erase(string s, Type val)
        {
            DicTreeNode<Type> fa = null;
            DicTreeNode<Type> now = root;

            for (int i = 0; i < s.Length; i++)
            {
                char tmp = s[i];
                if (!now.next.ContainsKey(tmp)) return false;
                else
                {
                    fa = now;
                    now = now.next[tmp];
                }
            }
            if (now.diclist.Remove(val))
            {
                //如果now没有指向，也没有儿子，那么可以删除now
                if (!now.diclist.Any() && !now.next.Any())
                {
                    fa.next.Remove(now.name);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 递归添加结果的函数
        /// </summary>
        /// <param name="now">当前节点</param>
        /// <param name="res">结果数组引用</param>
        private void AddToRes(DicTreeNode<Type> now, ref List<Type> res)
        {
            foreach (Type tmp in now.diclist)
            {
                res.Add(tmp);
            }
            foreach (KeyValuePair<char, DicTreeNode<Type>> pair in now.next)
            {
                AddToRes(pair.Value, ref res);
            }
        }
    }
}
