using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateStructure
{
	internal class DicTreeNode<Type> : IComparable
		where Type : IComparable
	{
		internal char name;
		internal List<Type> diclist;
		internal Dictionary<char, DicTreeNode<Type>> next;

		public int CompareTo(object obj)
		{
			DicTreeNode<Type> other = obj as DicTreeNode<Type>;
			if(name > other.name) return 1;
			else if(name == other.name) return 0;
			else return -1;
		}

		internal DicTreeNode(char c)
		{
			name = c;
			diclist = new List<Type>();
			next = new Dictionary<char, DicTreeNode<Type>>();
		}

	}

	public class DicTree<Type> where Type : IComparable
	{
		private DicTreeNode<Type> root;

		public DicTree()
		{
			root = new DicTreeNode<Type>('$');
		}
		public void Insert(string s, Type val)
		{
			DicTreeNode<Type> now = root;
			for(int i = 0;i < s.Length;i++)
			{
				char tmp = s[i];
				if(now.next.ContainsKey(tmp)) now = now.next[tmp];
				else
				{
					now.next.Add(s[i], new DicTreeNode<Type>(tmp));
					now = now.next[tmp];
				}
			}
			now.diclist.Add(val);
		}
		public List<Type> Find(string s)
		{
			List<Type> res = new List<Type>();
			DicTreeNode<Type> now = root;

			for(int i = 0;i < s.Length;i++)
			{
				char tmp = s[i];
				if(!now.next.ContainsKey(tmp)) return null;
				else
				{
					now = now.next[tmp];
				}
			}
			AddToRes(now, ref res);
			return res;
		}
		public bool Erase(string s, Type val)
		{
			DicTreeNode<Type> now = root;

			for(int i = 0;i < s.Length;i++)
			{
				char tmp = s[i];
				if(!now.next.ContainsKey(tmp)) return false;
				else
				{
					now = now.next[tmp];
				}
			}
			return now.diclist.Remove(val);
		}
		private void AddToRes(DicTreeNode<Type> now, ref List<Type> res)
		{
			foreach(Type tmp in now.diclist)
			{
				res.Add(tmp);
			}
			foreach(KeyValuePair<char, DicTreeNode<Type>> pair in now.next)
			{
				AddToRes(pair.Value, ref res);
			}
		}
	}
}
