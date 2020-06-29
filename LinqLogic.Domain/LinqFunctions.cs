using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLogic.Domain
{
    public class LinqFunctions
    {
        /// <summary>
        /// Write a method that returns a boolean indicating if an object is in a given IEnumerable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool ExistsInTable<T>(T obj, IEnumerable<T> table) where T : IEquatable<T>
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Write a method that returns a List of Tuples of objects. We're only interested in distinct tuples.
        /// Eg. a list of { t1, t2, t3, t4 } should return { (t1,t2), (t1,t3), (t1,t4), (t2,t3), (t2,t4), (t3,t4) }
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public List<Tuple<T, T>> GetDistinctPairs<T>(List<T> list) where T : class
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Write a method that returns all unique objects from a list.
        /// Eg a list of { t1, t2, t3, t3 } should return { t1, t2, t3 }
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <returns></returns>
        public List<T> GetListOfDistinctObjects<T>(IEnumerable<T> table) where T : class
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Write a method that returns all the duplicate objects from a list.
        /// Eg a list of { t1, t2, t3, t3 } should return { t3 }
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <returns></returns>
        public List<T> GetDuplicatesFromList<T>(IEnumerable<T> table) where T : class
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Write a method that combines two lists, but only unique occurences.
        /// Eg list1 { t1, t2 } and list2 { t2, t3 } should return { t1, t2, t3 }
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public List<T> CombineLists<T>(IEnumerable<T> list1, IEnumerable<T> list2) where T : class
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Write a method that returns the identical objects from two lists, but only unique occurences.
        /// Eg list1 { t1, t2, t3, t3 } and list2 { t2, t3, t4 } should return { t2, t3 }
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public List<T> IntersectionOfLists<T>(IEnumerable<T> list1, IEnumerable<T> list2) where T : class
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Write a method thar returns the unidentical objects from two lists, but only unique occurences.
        /// Eg list1 { t1, t2, t2, t3 } and list2 { t3, t4 } returns { t1, t2, t4 }
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public List<T> ExceptOfLists<T>(IEnumerable<T> list1, IEnumerable<T> list2) where T : class
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Write a method that returns a list of unique objects, from a list of lists of objects.
        /// Eg list { list1 { t1, t2, t3 }, list2 { t3, t4, t5 } } return { t1, t2, t3, t4, t5 }
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listOfLists"></param>
        /// <returns></returns>
        public List<T> FlattenListOfLists<T>(IEnumerable<IEnumerable<T>> listOfLists) where T : class
        {
            throw new NotImplementedException();
        }
    }
}