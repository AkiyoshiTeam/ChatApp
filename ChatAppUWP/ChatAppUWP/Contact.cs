using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppUWP
{
    public class Contact
    {
        string _id;
        string _name;
        string _content;
        string _image;

        public Contact(string id, string name, string content, string image)
        {
            _name = name;
            _content = content;
            _image = image;
            _id = id;
        }

        public string Name { get => _name; set => _name = value; }
        public string Content { get => _content; set => _content = value; }
        public string Image { get => _image; set => _image = value; }
        public string Id { get => _id; set => _id = value; }
    }
}
