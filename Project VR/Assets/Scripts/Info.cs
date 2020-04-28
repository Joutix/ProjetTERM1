using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Info", menuName = "Info")]
public class Info : ScriptableObject
{
    public string[] sub_parts;    
    public Sprite image;
    [TextArea(3, 10)]
    public string description = "<size=50>Place Holder Descriotion :\n</size>" +
        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent gravida laoreet dolor vitae laoreet. Vivamus porttitor, felis non ornare ultricies, lacus lorem semper enim, vel molestie quam diam id elit. Interdum et malesuada fames ac ante ipsum primis in faucibus. Nulla sed auctor quam, a vulputate lectus. Nullam sit amet malesuada nisi. Vestibulum dignissim elementum ante, quis bibendum mi interdum eu. Quisque accumsan mattis ipsum, eget pretium ex scelerisque quis. Vestibulum sagittis velit arcu, fermentum dignissim lorem rhoncus id. Ut fermentum non velit ultrices blandit. Vestibulum at dui eu sem scelerisque sagittis ut at nunc. Maecenas in eros ut est ornare pellentesque sed vel nulla. Donec scelerisque odio eget ex molestie ultrices. Ut nec risus lacus. Nullam at lectus quam.\n" + 
        "Nulla facilisi.Morbi lobortis eget purus ut blandit.Suspendisse vulputate id tellus imperdiet sodales. Mauris vehicula neque at odio facilisis, fringilla mattis metus volutpat. Nam ultricies erat volutpat mi ornare, ut finibus turpis pretium. Cras ullamcorper bibendum varius. Vestibulum tempor tortor rhoncus, tincidunt justo luctus, mattis enim. In hac habitasse platea dictumst.Suspendisse potenti. Phasellus sit amet auctor enim.Donec non convallis ligula. Praesent tincidunt libero nulla, sit amet accumsan elit tincidunt et. Integer rutrum gravida tortor, dictum fermentum lacus mollis bibendum.\n" +
        "Integer vel elementum tortor. Vestibulum in eleifend eros. Vivamus at metus erat. Donec quis tincidunt odio. Sed cursus eleifend mauris, ut faucibus nisl tempus nec.Quisque cursus, nisl sit amet eleifend consequat, libero lectus aliquam nibh, elementum bibendum nunc tortor a lectus. Phasellus consectetur interdum dictum. Cras neque nisi, fermentum sed sem sit amet, vehicula dignissim neque.Nam laoreet varius orci eget egestas. Nunc vitae dictum nibh.";
}
