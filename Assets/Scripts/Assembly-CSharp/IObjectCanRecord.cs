public interface IObjectCanRecord
{
	IRecordData DataRecord(string path, int index);

	void RecoverFromData(IRecordData objectRecordData);

	void RecoverFromDataFallback();
}
