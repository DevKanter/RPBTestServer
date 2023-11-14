using RPBNet.Packets;
using RPBUtilities;
using System.Runtime.CompilerServices;

namespace RPBTestServer.Packets;

public partial class C2SCharacterCreate : RPBPacket
{
    private static int _id = BitConverter.ToInt32(new byte[]{0,1,0,0});
    public override int PacketId
    {
        get { return _id;  }
    }
    public override int GetSize()
    {
        return sizeof(Int32) + CharName.Length +2;
    }

    public override void Serialize(ByteBuffer buffer)
    {
	    buffer.Write(CharID);
	    buffer.Write(CharName);

    }
    public override T Deserialize<T>(ByteBuffer buffer)
    {
        return Unsafe.As<T>(new C2SCharacterCreate()
        {
	    CharID = buffer.Read<Int32>(),
	    CharName = buffer.ReadString()

        });
    }
}